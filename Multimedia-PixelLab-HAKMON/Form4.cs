using OpenTK;
using OpenTK.Graphics.OpenGL;
using ColorMine.ColorSpaces;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Multimedia_PixelLab_HAKMON
{
    public partial class Form4 : Form
    {
        // ─────────────────────────────────────────────
        //  Color System Enum
        // ─────────────────────────────────────────────
        public enum CSystem { RGB, HSV, CMYK, YUV, LAB, YCbCr }

        // ─────────────────────────────────────────────
        //  View state
        // ─────────────────────────────────────────────
        private CSystem _currentSystem = CSystem.RGB;
        private float _rotX = 20f;
        private float _rotY = 30f;
        private float _zoom = 3.5f;

        private System.Drawing.Point _lastMouse;
        private System.Drawing.Point _dragStart;
        private bool _isDragging = false;
        private bool _dragOccurred = false;
        private bool _glReady = false;

        // ─────────────────────────────────────────────
        //  Image + pixel cache (used to plot pixels in space)
        //  Cache holds (R,G,B) for a sub-sampled set of pixels.
        // ─────────────────────────────────────────────
        private Bitmap? _image;
        private byte[]? _pixelsRGB;   // [n*3]  → R,G,B,R,G,B,…
        private int _pixelCount = 0;

        public Form4() : this(null) { }

        public Form4(Bitmap? sourceImage)
        {
            InitializeComponent();
            _image = sourceImage;

            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            btnResetView.Click += BtnResetView_Click;
            chkShowImageInSpace.CheckedChanged += (s, e) => glControl1.Invalidate();
            chkShowShape.CheckedChanged += (s, e) => glControl1.Invalidate();

            glControl1.Paint += GlControl1_Paint;
            glControl1.Load += GlControl1_Load;
            glControl1.Resize += GlControl1_Resize;
            glControl1.MouseDown += GlControl1_MouseDown;
            glControl1.MouseMove += GlControl1_MouseMove;
            glControl1.MouseUp += GlControl1_MouseUp;
            glControl1.MouseWheel += GlControl1_MouseWheel;
            glControl1.MouseClick += GlControl1_MouseClick;

            CachePixels();
            //UpdateImageInfoLabel();
            UpdateAllSystemDisplays(Color.White);
        }

        // ─────────────────────────────────────────────
        //  Pixel cache (sub-sample to ≤ ~25 000 points)
        // ─────────────────────────────────────────────
        private void CachePixels()
        {
            _pixelsRGB = null;
            _pixelCount = 0;
            if (_image == null) return;

            const int targetMax = 25000;
            int total = _image.Width * _image.Height;
            int step = Math.Max(1, (int)Math.Sqrt(total / (double)targetMax));

            int w = _image.Width, h = _image.Height;
            int countX = (w + step - 1) / step;
            int countY = (h + step - 1) / step;
            int n = countX * countY;

            _pixelsRGB = new byte[n * 3];
            int idx = 0;

            var data = _image.LockBits(
                new Rectangle(0, 0, w, h),
                System.Drawing.Imaging.ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            try
            {
                int stride = data.Stride;
                byte[] all = new byte[stride * h];
                Marshal.Copy(data.Scan0, all, 0, all.Length);

                for (int y = 0; y < h; y += step)
                {
                    int rowOff = y * stride;
                    for (int x = 0; x < w; x += step)
                    {
                        int p = rowOff + x * 3;
                        // Format24bppRgb is stored as B,G,R in memory
                        byte b = all[p];
                        byte g = all[p + 1];
                        byte r = all[p + 2];
                        _pixelsRGB[idx++] = r;
                        _pixelsRGB[idx++] = g;
                        _pixelsRGB[idx++] = b;
                    }
                }
            }
            finally
            {
                _image.UnlockBits(data);
            }

            _pixelCount = idx / 3;
        }

  /*      private void UpdateImageInfoLabel()
        {
            if (_image == null)
                lblImageInfo.Text = "No image loaded (open one in main window)";
            else
                lblImageInfo.Text = $"Image: {_image.Width}×{_image.Height} ({_pixelCount:N0} sampled points)";
        }
*/
        // ─────────────────────────────────────────────
        //  OpenGL lifecycle
        // ─────────────────────────────────────────────
        private void GlControl1_Load(object? sender, EventArgs e)
        {
            _glReady = true;
            GL.ClearColor(0.08f, 0.08f, 0.1f, 1f);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.PointSmooth);
            GL.Hint(HintTarget.PointSmoothHint, HintMode.Nicest);
            ApplyProjection();
        }

        private void ApplyProjection()
        {
            glControl1.MakeCurrent();
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            float aspect = glControl1.Width / (float)Math.Max(1, glControl1.Height);
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(45f), aspect, 0.1f, 100f);
            GL.LoadMatrix(ref perspective);
        }

        private void GlControl1_Resize(object? sender, EventArgs e)
        {
            if (!_glReady) return;
            ApplyProjection();
            glControl1.Invalidate();
        }

        private void GlControl1_Paint(object? sender, PaintEventArgs e)
        {
            if (!_glReady) return;
            glControl1.MakeCurrent();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            Matrix4 lookAt = Matrix4.LookAt(0f, 0.5f, _zoom, 0f, 0f, 0f, 0f, 1f, 0f);
            GL.LoadMatrix(ref lookAt);

            // Center each shape around the origin
            GL.Rotate(_rotX, 1f, 0f, 0f);
            GL.Rotate(_rotY, 0f, 1f, 0f);
            GL.Translate(-0.5f, -0.5f, -0.5f);

            DrawAxes();

            if (chkShowShape.Checked)
            {
                // Translucent shape so the pixel cloud stays visible
                GL.Enable(EnableCap.Blend);
                GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);

                switch (_currentSystem)
                {
                    case CSystem.RGB: DrawRGBCube(0.35f); break;
                    case CSystem.HSV: DrawHSVCone(0.35f); break;
                    case CSystem.CMYK: DrawCMYKCube(0.35f); break;
                    case CSystem.YUV: DrawYUVCube(0.35f); break;
                    case CSystem.LAB: DrawLABSphere(0.35f); break;
                    case CSystem.YCbCr: DrawYCbCrCube(0.35f); break;
                }

                GL.Disable(EnableCap.Blend);
            }

            // Always draw the wireframe so we can still see the shape's bounds
            DrawCurrentWireframe();

            if (chkShowImageInSpace.Checked && _pixelCount > 0)
                DrawImagePixels();

            GL.Flush();
            glControl1.SwapBuffers();
        }

        // ─────────────────────────────────────────────
        //  Mouse interaction
        // ─────────────────────────────────────────────
        private void GlControl1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _isDragging = true;
            _dragOccurred = false;
            _dragStart = e.Location;
            _lastMouse = e.Location;
            glControl1.Cursor = Cursors.SizeAll;
        }

        private void GlControl1_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!_isDragging) return;

            int dx = e.X - _lastMouse.X;
            int dy = e.Y - _lastMouse.Y;
            if (Math.Abs(e.X - _dragStart.X) + Math.Abs(e.Y - _dragStart.Y) > 3)
                _dragOccurred = true;

            _rotY += dx * 0.5f;
            _rotX += dy * 0.5f;
            _rotX = Math.Max(-89f, Math.Min(89f, _rotX));

            _lastMouse = e.Location;
            glControl1.Invalidate();
        }

        private void GlControl1_MouseUp(object? sender, MouseEventArgs e)
        {
            _isDragging = false;
            glControl1.Cursor = Cursors.Default;
        }

        private void GlControl1_MouseWheel(object? sender, MouseEventArgs e)
        {
            _zoom -= e.Delta * 0.002f;
            _zoom = Math.Max(0.6f, Math.Min(10f, _zoom));
            glControl1.Invalidate();
        }

        private void GlControl1_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (_dragOccurred) return;

            glControl1.MakeCurrent();
            int glY = glControl1.Height - e.Y;
            byte[] pixel = new byte[3];
            GL.ReadPixels(e.X, glY, 1, 1, PixelFormat.Rgb, PixelType.UnsignedByte, pixel);

            if (pixel[0] < 8 && pixel[1] < 8 && pixel[2] < 8) return;

            Color picked = Color.FromArgb(pixel[0], pixel[1], pixel[2]);
            UpdateAllSystemDisplays(picked);
        }

        // ─────────────────────────────────────────────
        //  Controls
        // ─────────────────────────────────────────────
        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            _currentSystem = comboBox1.SelectedIndex switch
            {
                0 => CSystem.RGB,
                1 => CSystem.HSV,
                2 => CSystem.CMYK,
                3 => CSystem.YUV,
                4 => CSystem.LAB,
                5 => CSystem.YCbCr,
                _ => CSystem.RGB
            };
            glControl1.Invalidate();
        }

        private void BtnResetView_Click(object? sender, EventArgs e)
        {
            _rotX = 20f;
            _rotY = 30f;
            _zoom = 3.5f;
            glControl1.Invalidate();
        }

        // ─────────────────────────────────────────────
        //  Synchronized display of all 6 systems
        // ─────────────────────────────────────────────
        private void UpdateAllSystemDisplays(Color c)
        {
            panelColorPreview.BackColor = c;
            lblHex.Text = $"#{c.R:X2}{c.G:X2}{c.B:X2}";

            // RGB
            txtRGB_R.Text = c.R.ToString(CultureInfo.InvariantCulture);
            txtRGB_G.Text = c.G.ToString(CultureInfo.InvariantCulture);
            txtRGB_B.Text = c.B.ToString(CultureInfo.InvariantCulture);

            // CMYK
            RGBtoCMYK(c, out double cy, out double m, out double yC, out double k);
            txtCMYK_C.Text = (cy * 100).ToString("0.0");
            txtCMYK_M.Text = (m * 100).ToString("0.0");
            txtCMYK_Y.Text = (yC * 100).ToString("0.0");
            txtCMYK_K.Text = (k * 100).ToString("0.0");

            // HSV
            RGBtoHSV(c, out double h, out double s, out double v);
            txtHSV_H.Text = h.ToString("0.0");
            txtHSV_S.Text = (s * 100).ToString("0.0");
            txtHSV_V.Text = (v * 100).ToString("0.0");

            // YUV
            RGBtoYUV(c, out double yY, out double yU, out double yV);
            txtYUV_Y.Text = (yY * 255).ToString("0.0");
            txtYUV_U.Text = (yU * 255).ToString("0.0");
            txtYUV_V.Text = (yV * 255).ToString("0.0");

            // LAB
            RGBtoLAB(c, out double L, out double labA, out double labB);
            txtLAB_L.Text = L.ToString("0.0");
            txtLAB_A.Text = labA.ToString("0.0");
            txtLAB_B.Text = labB.ToString("0.0");

            // YCbCr
            RGBtoYCbCr(c, out int Y2, out int Cb2, out int Cr2);
            txtYCbCr_Y.Text = Y2.ToString(CultureInfo.InvariantCulture);
            txtYCbCr_Cb.Text = Cb2.ToString(CultureInfo.InvariantCulture);
            txtYCbCr_Cr.Text = Cr2.ToString(CultureInfo.InvariantCulture);
        }

        // ─────────────────────────────────────────────
        //  Image pixels plotted inside current color space
        // ─────────────────────────────────────────────
        private void DrawImagePixels()
        {
            if (_pixelsRGB == null) return;

            GL.PointSize(2.2f);
            GL.Begin(PrimitiveType.Points);

            for (int i = 0; i < _pixelCount; i++)
            {
                byte r = _pixelsRGB[i * 3 + 0];
                byte g = _pixelsRGB[i * 3 + 1];
                byte b = _pixelsRGB[i * 3 + 2];

                MapRGBtoSpace(r, g, b, out float x, out float y, out float z);

                GL.Color3(r / 255f, g / 255f, b / 255f);
                GL.Vertex3(x, y, z);
            }

            GL.End();
        }

        // Maps an RGB pixel to (x,y,z) inside [0..1]^3 of the active space.
        private void MapRGBtoSpace(byte r, byte g, byte b, out float x, out float y, out float z)
        {
            switch (_currentSystem)
            {
                case CSystem.RGB:
                    x = r / 255f; y = g / 255f; z = b / 255f;
                    return;

                case CSystem.CMYK:
                    {
                        // C,M,Y on three axes (K folded into them)
                        double rr = r / 255.0, gg = g / 255.0, bb = b / 255.0;
                        double k = 1.0 - Math.Max(rr, Math.Max(gg, bb));
                        double cc = (k < 1.0) ? (1.0 - rr - k) / (1.0 - k) : 0;
                        double mm = (k < 1.0) ? (1.0 - gg - k) / (1.0 - k) : 0;
                        double yy = (k < 1.0) ? (1.0 - bb - k) / (1.0 - k) : 0;
                        x = (float)cc; y = (float)mm; z = (float)yy;
                        return;
                    }

                case CSystem.HSV:
                    {
                        RGBtoHSV(Color.FromArgb(r, g, b), out double h, out double s, out double v);
                        // place inside the cone of radius v*scale
                        double ang = h * Math.PI / 180.0;
                        double rad = s * v * 0.5;           // radius from axis (0..0.5)
                        x = (float)(0.5 + rad * Math.Cos(ang));
                        y = (float)v;                       // height
                        z = (float)(0.5 + rad * Math.Sin(ang));
                        return;
                    }

                case CSystem.YUV:
                    {
                        RGBtoYUV(Color.FromArgb(r, g, b), out double Y, out double U, out double V);
                        // Y ∈ [0..1] → x      U ∈ [-0.436..0.436] → y       V ∈ [-0.615..0.615] → z
                        x = (float)Y;
                        y = (float)((U + 0.436) / 0.872);
                        z = (float)((V + 0.615) / 1.230);
                        return;
                    }

                case CSystem.LAB:
                    {
                        RGBtoLAB(Color.FromArgb(r, g, b), out double L, out double aa, out double bb);
                        // L 0..100, a/b roughly -128..127
                        x = (float)((aa + 128) / 255.0);
                        y = (float)(L / 100.0);
                        z = (float)((bb + 128) / 255.0);
                        return;
                    }

                case CSystem.YCbCr:
                    {
                        RGBtoYCbCr(Color.FromArgb(r, g, b), out int Y, out int Cb, out int Cr);
                        x = (Y - 16) / (235f - 16f);
                        y = (Cb - 16) / (240f - 16f);
                        z = (Cr - 16) / (240f - 16f);
                        return;
                    }

                default:
                    x = r / 255f; y = g / 255f; z = b / 255f;
                    return;
            }
        }

        // ─────────────────────────────────────────────
        //  Axes
        // ─────────────────────────────────────────────
        private void DrawAxes()
        {
            GL.LineWidth(2.5f);
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(1f, 0.3f, 0.3f); GL.Vertex3(0f, 0f, 0f); GL.Vertex3(1.4f, 0f, 0f);
            GL.Color3(0.3f, 1f, 0.3f); GL.Vertex3(0f, 0f, 0f); GL.Vertex3(0f, 1.4f, 0f);
            GL.Color3(0.3f, 0.5f, 1f); GL.Vertex3(0f, 0f, 0f); GL.Vertex3(0f, 0f, 1.4f);
            GL.End();
        }

        // ─────────────────────────────────────────────
        //  Cube topology
        // ─────────────────────────────────────────────
        private static readonly int[,] CubeEdges =
        {
            {0,1},{1,3},{3,2},{2,0},
            {4,5},{5,7},{7,6},{6,4},
            {0,4},{1,5},{2,6},{3,7}
        };

        private static readonly float[,] CubeVerts =
        {
            {0,0,0},{1,0,0},{0,1,0},{1,1,0},
            {0,0,1},{1,0,1},{0,1,1},{1,1,1}
        };

        private void DrawCubeEdgesWhite()
        {
            GL.LineWidth(1.2f);
            GL.Color3(1f, 1f, 1f);
            GL.Begin(PrimitiveType.Lines);
            for (int i = 0; i < CubeEdges.GetLength(0); i++)
            {
                int a = CubeEdges[i, 0], b = CubeEdges[i, 1];
                GL.Vertex3(CubeVerts[a, 0], CubeVerts[a, 1], CubeVerts[a, 2]);
                GL.Vertex3(CubeVerts[b, 0], CubeVerts[b, 1], CubeVerts[b, 2]);
            }
            GL.End();
        }

        private void DrawCurrentWireframe()
        {
            switch (_currentSystem)
            {
                case CSystem.HSV: DrawHSVConeWireframe(); break;
                case CSystem.LAB: /* sphere wireframe omitted */ break;
                default: DrawCubeEdgesWhite(); break;
            }
        }

        // ─────────────────────────────────────────────
        //  RGB cube
        // ─────────────────────────────────────────────
        private void DrawRGBCube(float alpha)
        {
            GL.Begin(PrimitiveType.Quads);

            // Front Z=0
            GL.Color4(0f, 0f, 0f, alpha); GL.Vertex3(0f, 0f, 0f);
            GL.Color4(1f, 0f, 0f, alpha); GL.Vertex3(1f, 0f, 0f);
            GL.Color4(1f, 1f, 0f, alpha); GL.Vertex3(1f, 1f, 0f);
            GL.Color4(0f, 1f, 0f, alpha); GL.Vertex3(0f, 1f, 0f);

            // Back Z=1
            GL.Color4(0f, 0f, 1f, alpha); GL.Vertex3(0f, 0f, 1f);
            GL.Color4(1f, 0f, 1f, alpha); GL.Vertex3(1f, 0f, 1f);
            GL.Color4(1f, 1f, 1f, alpha); GL.Vertex3(1f, 1f, 1f);
            GL.Color4(0f, 1f, 1f, alpha); GL.Vertex3(0f, 1f, 1f);

            // Left X=0
            GL.Color4(0f, 0f, 0f, alpha); GL.Vertex3(0f, 0f, 0f);
            GL.Color4(0f, 0f, 1f, alpha); GL.Vertex3(0f, 0f, 1f);
            GL.Color4(0f, 1f, 1f, alpha); GL.Vertex3(0f, 1f, 1f);
            GL.Color4(0f, 1f, 0f, alpha); GL.Vertex3(0f, 1f, 0f);

            // Right X=1
            GL.Color4(1f, 0f, 0f, alpha); GL.Vertex3(1f, 0f, 0f);
            GL.Color4(1f, 0f, 1f, alpha); GL.Vertex3(1f, 0f, 1f);
            GL.Color4(1f, 1f, 1f, alpha); GL.Vertex3(1f, 1f, 1f);
            GL.Color4(1f, 1f, 0f, alpha); GL.Vertex3(1f, 1f, 0f);

            // Bottom Y=0
            GL.Color4(0f, 0f, 0f, alpha); GL.Vertex3(0f, 0f, 0f);
            GL.Color4(1f, 0f, 0f, alpha); GL.Vertex3(1f, 0f, 0f);
            GL.Color4(1f, 0f, 1f, alpha); GL.Vertex3(1f, 0f, 1f);
            GL.Color4(0f, 0f, 1f, alpha); GL.Vertex3(0f, 0f, 1f);

            // Top Y=1
            GL.Color4(0f, 1f, 0f, alpha); GL.Vertex3(0f, 1f, 0f);
            GL.Color4(1f, 1f, 0f, alpha); GL.Vertex3(1f, 1f, 0f);
            GL.Color4(1f, 1f, 1f, alpha); GL.Vertex3(1f, 1f, 1f);
            GL.Color4(0f, 1f, 1f, alpha); GL.Vertex3(0f, 1f, 1f);

            GL.End();
        }

        // ─────────────────────────────────────────────
        //  CMYK cube
        // ─────────────────────────────────────────────
        private void DrawCMYKCube(float alpha)
        {
            void V(float c, float m, float y)
            {
                GL.Color4(1f - c, 1f - m, 1f - y, alpha);
                GL.Vertex3(c, m, y);
            }

            GL.Begin(PrimitiveType.Quads);
            V(0, 0, 0); V(1, 0, 0); V(1, 1, 0); V(0, 1, 0);
            V(0, 0, 1); V(1, 0, 1); V(1, 1, 1); V(0, 1, 1);
            V(0, 0, 0); V(0, 0, 1); V(0, 1, 1); V(0, 1, 0);
            V(1, 0, 0); V(1, 0, 1); V(1, 1, 1); V(1, 1, 0);
            V(0, 0, 0); V(1, 0, 0); V(1, 0, 1); V(0, 0, 1);
            V(0, 1, 0); V(1, 1, 0); V(1, 1, 1); V(0, 1, 1);
            GL.End();
        }

        // ─────────────────────────────────────────────
        //  YUV cube
        // ─────────────────────────────────────────────
        private void DrawYUVCube(float alpha)
        {
            void V(float x, float y, float z)
            {
                float Y = x;
                float U = (y - 0.5f) * 0.872f;
                float Vv = (z - 0.5f) * 1.230f;
                double r = Math.Max(0, Math.Min(1, Y + 1.13983 * Vv));
                double g = Math.Max(0, Math.Min(1, Y - 0.39465 * U - 0.58060 * Vv));
                double b = Math.Max(0, Math.Min(1, Y + 2.03211 * U));
                GL.Color4((float)r, (float)g, (float)b, alpha);
                GL.Vertex3(x, y, z);
            }

            GL.Begin(PrimitiveType.Quads);
            V(0, 0, 0); V(1, 0, 0); V(1, 1, 0); V(0, 1, 0);
            V(0, 0, 1); V(1, 0, 1); V(1, 1, 1); V(0, 1, 1);
            V(0, 0, 0); V(0, 0, 1); V(0, 1, 1); V(0, 1, 0);
            V(1, 0, 0); V(1, 0, 1); V(1, 1, 1); V(1, 1, 0);
            V(0, 0, 0); V(1, 0, 0); V(1, 0, 1); V(0, 0, 1);
            V(0, 1, 0); V(1, 1, 0); V(1, 1, 1); V(0, 1, 1);
            GL.End();
        }

        // ─────────────────────────────────────────────
        //  YCbCr cube
        // ─────────────────────────────────────────────
        private void DrawYCbCrCube(float alpha)
        {
            void V(float x, float y, float z)
            {
                float Y = 16f + x * 219f;
                float Cb = 16f + y * 224f;
                float Cr = 16f + z * 224f;
                double yy = (Y - 16f) / 219f;
                double cb = (Cb - 16f) / 224f - 0.5;
                double cr = (Cr - 16f) / 224f - 0.5;
                double r = Math.Max(0, Math.Min(1, yy + 1.402 * cr));
                double g = Math.Max(0, Math.Min(1, yy - 0.34414 * cb - 0.71414 * cr));
                double b = Math.Max(0, Math.Min(1, yy + 1.772 * cb));
                GL.Color4((float)r, (float)g, (float)b, alpha);
                GL.Vertex3(x, y, z);
            }

            GL.Begin(PrimitiveType.Quads);
            V(0, 0, 0); V(1, 0, 0); V(1, 1, 0); V(0, 1, 0);
            V(0, 0, 1); V(1, 0, 1); V(1, 1, 1); V(0, 1, 1);
            V(0, 0, 0); V(0, 0, 1); V(0, 1, 1); V(0, 1, 0);
            V(1, 0, 0); V(1, 0, 1); V(1, 1, 1); V(1, 1, 0);
            V(0, 0, 0); V(1, 0, 0); V(1, 0, 1); V(0, 0, 1);
            V(0, 1, 0); V(1, 1, 0); V(1, 1, 1); V(0, 1, 1);
            GL.End();
        }

        // ─────────────────────────────────────────────
        //  HSV cone — fits inside [0..1]^3 (axis from (0.5,0,0.5) to (0.5,1,0.5))
        // ─────────────────────────────────────────────
        private void DrawHSVCone(float alpha)
        {
            const int slices = 60;
            const int stacks = 24;
            const float maxR = 0.5f;

            GL.Begin(PrimitiveType.Quads);
            for (int j = 0; j < stacks; j++)
            {
                float v1 = j / (float)stacks;
                float v2 = (j + 1) / (float)stacks;
                float r1 = v1 * maxR;
                float r2 = v2 * maxR;

                for (int i = 0; i < slices; i++)
                {
                    float h1 = (i / (float)slices) * 360f;
                    float h2 = ((i + 1) / (float)slices) * 360f;
                    float a1 = (float)(h1 * Math.PI / 180.0);
                    float a2 = (float)(h2 * Math.PI / 180.0);

                    Vector3 p1 = new(0.5f + r1 * (float)Math.Cos(a1), v1, 0.5f + r1 * (float)Math.Sin(a1));
                    Vector3 p2 = new(0.5f + r1 * (float)Math.Cos(a2), v1, 0.5f + r1 * (float)Math.Sin(a2));
                    Vector3 p3 = new(0.5f + r2 * (float)Math.Cos(a2), v2, 0.5f + r2 * (float)Math.Sin(a2));
                    Vector3 p4 = new(0.5f + r2 * (float)Math.Cos(a1), v2, 0.5f + r2 * (float)Math.Sin(a1));

                    SetHSVColor(h1, 1f, v1, alpha); GL.Vertex3(p1);
                    SetHSVColor(h2, 1f, v1, alpha); GL.Vertex3(p2);
                    SetHSVColor(h2, 1f, v2, alpha); GL.Vertex3(p3);
                    SetHSVColor(h1, 1f, v2, alpha); GL.Vertex3(p4);
                }
            }
            GL.End();

            // Top cap (V=1)
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color4(1f, 1f, 1f, alpha);
            GL.Vertex3(0.5f, 1f, 0.5f);
            for (int i = 0; i <= slices; i++)
            {
                float h = (i / (float)slices) * 360f;
                float a = (float)(h * Math.PI / 180.0);
                SetHSVColor(h, 1f, 1f, alpha);
                GL.Vertex3(0.5f + maxR * (float)Math.Cos(a), 1f, 0.5f + maxR * (float)Math.Sin(a));
            }
            GL.End();
        }

        private void DrawHSVConeWireframe()
        {
            const int slices = 36;
            const float maxR = 0.5f;
            GL.LineWidth(1.2f);
            GL.Color3(0.85f, 0.85f, 0.85f);

            // top circle
            GL.Begin(PrimitiveType.LineLoop);
            for (int i = 0; i < slices; i++)
            {
                float a = (float)(i / (float)slices * 2 * Math.PI);
                GL.Vertex3(0.5f + maxR * (float)Math.Cos(a), 1f, 0.5f + maxR * (float)Math.Sin(a));
            }
            GL.End();

            // 4 cone lines from tip to circumference
            GL.Begin(PrimitiveType.Lines);
            for (int k = 0; k < 4; k++)
            {
                float a = (float)(k / 4f * 2 * Math.PI);
                GL.Vertex3(0.5f, 0f, 0.5f);
                GL.Vertex3(0.5f + maxR * (float)Math.Cos(a), 1f, 0.5f + maxR * (float)Math.Sin(a));
            }
            GL.End();
        }

        private static void SetHSVColor(float h, float s, float v, float alpha)
        {
            int hi = (int)(h / 60) % 6;
            float f = (h / 60f) - (int)(h / 60f);
            float V = v;
            float p = v * (1 - s);
            float q = v * (1 - f * s);
            float t = v * (1 - (1 - f) * s);
            switch (hi)
            {
                case 0: GL.Color4(V, t, p, alpha); break;
                case 1: GL.Color4(q, V, p, alpha); break;
                case 2: GL.Color4(p, V, t, alpha); break;
                case 3: GL.Color4(p, q, V, alpha); break;
                case 4: GL.Color4(t, p, V, alpha); break;
                default: GL.Color4(V, p, q, alpha); break;
            }
        }

        // ─────────────────────────────────────────────
        //  LAB sphere (centered at 0.5,0.5,0.5 with radius 0.5)
        // ─────────────────────────────────────────────
        private void DrawLABSphere(float alpha)
        {
            const int stacks = 30;
            const int slices = 30;
            const float radius = 0.5f;

            for (int i = 0; i < stacks; i++)
            {
                double lat0 = Math.PI * (-0.5 + (double)i / stacks);
                double lat1 = Math.PI * (-0.5 + (double)(i + 1) / stacks);
                double z0 = Math.Sin(lat0), zr0 = Math.Cos(lat0);
                double z1 = Math.Sin(lat1), zr1 = Math.Cos(lat1);

                GL.Begin(PrimitiveType.QuadStrip);
                for (int j = 0; j <= slices; j++)
                {
                    double lng = 2 * Math.PI * j / slices;
                    double x = Math.Cos(lng);
                    double y = Math.Sin(lng);
                    EmitLABVertex(x * zr0, y * zr0, z0, radius, alpha);
                    EmitLABVertex(x * zr1, y * zr1, z1, radius, alpha);
                }
                GL.End();
            }
        }

        private static void EmitLABVertex(double x, double y, double z, float radius, float alpha)
        {
            float px = 0.5f + (float)(x * radius);
            float py = 0.5f + (float)(y * radius);
            float pz = 0.5f + (float)(z * radius);

            float L = py;
            float A = (float)x;
            float B = (float)z;

            float brightness = (float)Math.Pow(L, 1.2);
            float r = Math.Max(0f, Math.Min(1f, brightness + A * 0.5f + B * 0.25f));
            float g = Math.Max(0f, Math.Min(1f, brightness - A * 0.5f + B * 0.25f));
            float b = Math.Max(0f, Math.Min(1f, brightness - B * 0.5f));

            GL.Color4(r, g, b, alpha);
            GL.Vertex3(px, py, pz);
        }

        // ─────────────────────────────────────────────
        //  Color space conversions (static utilities)
        // ─────────────────────────────────────────────
        public static void RGBtoHSV(Color c, out double h, out double s, out double v)
        {
            var rgb = new Rgb { R = c.R, G = c.G, B = c.B };
            var hsv = rgb.To<Hsv>();
            h = hsv.H;
            s = hsv.S;
            v = hsv.V;
        }

        public static void RGBtoCMYK(Color c, out double C, out double M, out double Y, out double K)
        {
            var rgb = new Rgb { R = c.R, G = c.G, B = c.B };
            var cmyk = rgb.To<Cmyk>();
            C = cmyk.C; M = cmyk.M; Y = cmyk.Y; K = cmyk.K;
        }

        public static void RGBtoYUV(Color c, out double Y, out double U, out double V)
        {
            double r = c.R / 255.0, g = c.G / 255.0, b = c.B / 255.0;
            Y = 0.299 * r + 0.587 * g + 0.114 * b;
            U = -0.14713 * r - 0.28886 * g + 0.436 * b;
            V = 0.615 * r - 0.51499 * g - 0.10001 * b;
        }

        public static void RGBtoLAB(Color c, out double L, out double a, out double b)
        {
            var rgb = new Rgb { R = c.R, G = c.G, B = c.B };
            var lab = rgb.To<Lab>();
            L = lab.L; a = lab.A; b = lab.B;
        }

        public static void RGBtoYCbCr(Color c, out int Y, out int Cb, out int Cr)
        {
            double r = c.R, g = c.G, b = c.B;
            Y = (int)(16 + 65.481 * r / 255 + 128.553 * g / 255 + 24.966 * b / 255);
            Cb = (int)(128 - 37.797 * r / 255 - 74.203 * g / 255 + 112.000 * b / 255);
            Cr = (int)(128 + 112.000 * r / 255 - 93.786 * g / 255 - 18.214 * b / 255);
            Y = Math.Max(16, Math.Min(235, Y));
            Cb = Math.Max(16, Math.Min(240, Cb));
            Cr = Math.Max(16, Math.Min(240, Cr));
        }
    }
}
