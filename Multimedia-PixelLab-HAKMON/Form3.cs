using OpenTK;
using OpenTK.Graphics.OpenGL;
using ColorMine.ColorSpaces;
// ─────────────────────────────────────────────
//  Enums
// ─────────────────────────────────────────────
enum ColorSystem
{
    RGB,
    HSV,
    CMYK,
    YUV,
    LAB,
    YCbCr
}

namespace Multimedia_PixelLab_HAKMON
{
    public partial class Form3 : Form
    {
        // ─────────────────────────────────────────────
        //  Fields
        // ─────────────────────────────────────────────

        private ColorSystem _currentSystem = ColorSystem.HSV;
        private float _angle = 0f;
        private float _rotX = 20f;
        private float _rotY = 30f;
        private float _zoom = 3.5f;

        private System.Drawing.Point _lastMouse;
        private bool _isDragging = false;

        private Bitmap _image;

        // ─────────────────────────────────────────────
        //  Constructor
        // ─────────────────────────────────────────────

        public Form3()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            glControl1.Paint += GlControl1_Paint;
            glControl1.Load += GlControl1_Load;
            glControl1.Resize += GlControl1_Resize;
            glControl1.MouseDown += GlControl1_MouseDown;
            glControl1.MouseMove += GlControl1_MouseMove;
            glControl1.MouseUp += GlControl1_MouseUp;
            glControl1.MouseWheel += GlControl1_MouseWheel;

        }

        // ─────────────────────────────────────────────
        //  OpenGL Lifecycle
        // ─────────────────────────────────────────────

        private void GlControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.1f, 0.1f, 0.1f, 1f);
            GL.Enable(EnableCap.DepthTest);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            float aspect = glControl1.Width / (float)glControl1.Height;
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(45f), aspect, 0.1f, 100f);

            GL.LoadMatrix(ref perspective);
        }

        private void GlControl1_Resize(object sender, EventArgs e)
        {
            glControl1.MakeCurrent();
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            glControl1.Invalidate();
        }

        private void GlControl1_Paint(object sender, PaintEventArgs e)
        {
            glControl1.MakeCurrent();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            Matrix4 lookAt = Matrix4.LookAt(0f, 0.5f, _zoom, 0f, 0f, 0f, 0f, 1f, 0f);
            GL.LoadMatrix(ref lookAt);

            GL.Rotate(_rotX, 1f, 0f, 0f);
            GL.Rotate(_rotY, 0f, 1f, 0f);

            DrawAxes();

            switch (_currentSystem)
            {
                case ColorSystem.RGB: DrawRGB(); break;
                case ColorSystem.HSV: DrawHSV(); break;
                case ColorSystem.CMYK: DrawCMYK(); break;
                case ColorSystem.YUV: DrawYUV(); break;
                case ColorSystem.LAB: DrawLAB(); break;
                case ColorSystem.YCbCr: DrawYCbCr(); break;
            }

            GL.Flush();
            glControl1.SwapBuffers();
        }

        // ─────────────────────────────────────────────
        //  Mouse Events
        // ─────────────────────────────────────────────

        private void GlControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            _isDragging = true;
            _lastMouse = e.Location;
            glControl1.Cursor = Cursors.SizeAll;
        }

        private void GlControl1_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
            glControl1.Cursor = Cursors.Default;
        }

        private void GlControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                _rotY += (e.X - _lastMouse.X) * 0.5f;
                _rotX += (e.Y - _lastMouse.Y) * 0.5f;
                _rotX = Math.Max(-89f, Math.Min(89f, _rotX));

                _lastMouse = e.Location;
                glControl1.Invalidate();
                return;
            }

            // Hover — read pixel color
            glControl1.MakeCurrent();
            int glY = glControl1.Height - e.Y;

            byte[] pixel = new byte[3];
            GL.ReadPixels(e.X, glY, 1, 1, PixelFormat.Rgb, PixelType.UnsignedByte, pixel);

            if (IsBackground(pixel)) return;
        }

        private void GlControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            _zoom -= e.Delta * 0.002f;
            _zoom = Math.Max(0.5f, Math.Min(8f, _zoom));
            glControl1.Invalidate();
        }

        private void GlControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            glControl1.MakeCurrent();

            int glY = glControl1.Height - e.Y;
            byte[] pixel = new byte[3];
            GL.ReadPixels(e.X, glY, 1, 1, PixelFormat.Rgb, PixelType.UnsignedByte, pixel);

            if (IsBackground(pixel))
            {
                num1.Value = num2.Value = num3.Value = num4.Value = 0;
                return;
            }

            ShowColorComponents(Color.FromArgb(pixel[0], pixel[1], pixel[2]));
        }

        // ─────────────────────────────────────────────
        //  UI Events
        // ─────────────────────────────────────────────

  
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentSystem = comboBox1.SelectedIndex switch
            {
                0 => ColorSystem.RGB,
                1 => ColorSystem.HSV,
                2 => ColorSystem.CMYK,
                3 => ColorSystem.YUV,
                4 => ColorSystem.LAB,
                5 => ColorSystem.YCbCr,
                _ => ColorSystem.RGB
            };

            glControl1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _currentSystem++;
            if (_currentSystem > ColorSystem.YCbCr)
                _currentSystem = ColorSystem.RGB;

            glControl1.Invalidate();
        }

        // ─────────────────────────────────────────────
        //  Stubs required by Designer.cs (do not remove)
        // ─────────────────────────────────────────────

        // Designer.cs registers this name — forwards to the renamed handler
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            => ComboBox1_SelectedIndexChanged(sender, e);

        // Designer.cs registers this name — empty, Load logic is in GlControl1_Load
        private void glControl1_Load_1(object sender, EventArgs e) { }

        // Designer.cs registers this name — forwards to the renamed handler
        private void glControl1_MouseClick(object sender, MouseEventArgs e)
            => GlControl1_MouseClick(sender, e);

        // Designer.cs registers this name — empty stub
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }

        // ─────────────────────────────────────────────
        //  Color Display
        // ─────────────────────────────────────────────

        private void ShowColorComponents(Color c)
        {
            switch (_currentSystem)
            {
                case ColorSystem.RGB:
                    num1.Value = c.R;
                    num2.Value = c.G;
                    num3.Value = c.B;
                    num4.Value = 0;
                    break;

                case ColorSystem.HSV:
                    RGBtoHSV(c, out double h, out double s, out double v);
                    num1.Value = (decimal)h;
                    num2.Value = (decimal)(s * 100);
                    num3.Value = (decimal)(v * 100);
                    num4.Value = 0;
                    break;

                case ColorSystem.CMYK:
                    RGBtoCMYK(c, out double cy, out double m, out double y, out double k);
                    num1.Value = (decimal)(cy * 100);
                    num2.Value = (decimal)(m * 100);
                    num3.Value = (decimal)(y * 100);
                    num4.Value = (decimal)(k * 100);
                    break;

                case ColorSystem.LAB:
                    RGBtoLAB(c, out double l, out double a, out double b);

                    num1.Value = (decimal)l;
                    num2.Value = (decimal)a;
                    num3.Value = (decimal)b;
                    num4.Value = 0;
                    break;

                case ColorSystem.YCbCr:
                    RGBtoYCbCr(c, out int Y, out int Cb, out int Cr);
                    num1.Value = Y;
                    num2.Value = Cb;
                    num3.Value = Cr;
                    num4.Value = 0;
                    break;
                case ColorSystem.YUV:
                    RGBtoYUV(c, out double yuvY, out double u, out double vv);

                    num1.Value = (decimal)yuvY;
                    num2.Value = (decimal)u;
                    num3.Value = (decimal)vv;
                    num4.Value = 0;
                    break;
            }
        }

        // ─────────────────────────────────────────────
        //  Drawing Helpers
        // ─────────────────────────────────────────────

        private static bool IsBackground(byte[] pixel)
            => pixel[0] < 8 && pixel[1] < 8 && pixel[2] < 8;

        private void DrawAxes()
        {
            GL.LineWidth(3f);
            GL.Begin(PrimitiveType.Lines);

            GL.Color3(Color.Red); GL.Vertex3(0f, 0f, 0f); GL.Vertex3(3f, 0f, 0f);
            GL.Color3(Color.Lime); GL.Vertex3(0f, 0f, 0f); GL.Vertex3(0f, 3f, 0f);
            GL.Color3(Color.Blue); GL.Vertex3(0f, 0f, 0f); GL.Vertex3(0f, 0f, 3f);

            GL.End();
        }

        // shared cube topology
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

        // ─────────────────────────────────────────────
        //  RGB
        // ─────────────────────────────────────────────

        private void DrawRGB()
        {
            GL.Begin(PrimitiveType.Quads);

            // Front  Z=0
            GL.Color3(0f, 0f, 0f); GL.Vertex3(0f, 0f, 0f);
            GL.Color3(1f, 0f, 0f); GL.Vertex3(1f, 0f, 0f);
            GL.Color3(1f, 1f, 0f); GL.Vertex3(1f, 1f, 0f);
            GL.Color3(0f, 1f, 0f); GL.Vertex3(0f, 1f, 0f);

            // Back   Z=1
            GL.Color3(0f, 0f, 1f); GL.Vertex3(0f, 0f, 1f);
            GL.Color3(1f, 0f, 1f); GL.Vertex3(1f, 0f, 1f);
            GL.Color3(1f, 1f, 1f); GL.Vertex3(1f, 1f, 1f);
            GL.Color3(0f, 1f, 1f); GL.Vertex3(0f, 1f, 1f);

            // Left   X=0
            GL.Color3(0f, 0f, 0f); GL.Vertex3(0f, 0f, 0f);
            GL.Color3(0f, 0f, 1f); GL.Vertex3(0f, 0f, 1f);
            GL.Color3(0f, 1f, 1f); GL.Vertex3(0f, 1f, 1f);
            GL.Color3(0f, 1f, 0f); GL.Vertex3(0f, 1f, 0f);

            // Right  X=1
            GL.Color3(1f, 0f, 0f); GL.Vertex3(1f, 0f, 0f);
            GL.Color3(1f, 0f, 1f); GL.Vertex3(1f, 0f, 1f);
            GL.Color3(1f, 1f, 1f); GL.Vertex3(1f, 1f, 1f);
            GL.Color3(1f, 1f, 0f); GL.Vertex3(1f, 1f, 0f);

            // Bottom Y=0
            GL.Color3(0f, 0f, 0f); GL.Vertex3(0f, 0f, 0f);
            GL.Color3(1f, 0f, 0f); GL.Vertex3(1f, 0f, 0f);
            GL.Color3(1f, 0f, 1f); GL.Vertex3(1f, 0f, 1f);
            GL.Color3(0f, 0f, 1f); GL.Vertex3(0f, 0f, 1f);

            // Top    Y=1
            GL.Color3(0f, 1f, 0f); GL.Vertex3(0f, 1f, 0f);
            GL.Color3(1f, 1f, 0f); GL.Vertex3(1f, 1f, 0f);
            GL.Color3(1f, 1f, 1f); GL.Vertex3(1f, 1f, 1f);
            GL.Color3(0f, 1f, 1f); GL.Vertex3(0f, 1f, 1f);

            GL.End();

            // Edges with brightened vertex colors
            GL.LineWidth(1.5f);
            GL.Begin(PrimitiveType.Lines);

            for (int i = 0; i < CubeEdges.GetLength(0); i++)
            {
                int a = CubeEdges[i, 0], b = CubeEdges[i, 1];

                void EmitRGBEdgeVertex(int idx)
                {
                    float r = Math.Min(1f, CubeVerts[idx, 0] * 0.6f + 0.4f);
                    float g = Math.Min(1f, CubeVerts[idx, 1] * 0.6f + 0.4f);
                    float bv = Math.Min(1f, CubeVerts[idx, 2] * 0.6f + 0.4f);
                    GL.Color3(r, g, bv);
                    GL.Vertex3(CubeVerts[idx, 0], CubeVerts[idx, 1], CubeVerts[idx, 2]);
                }

                EmitRGBEdgeVertex(a);
                EmitRGBEdgeVertex(b);
            }

            GL.End();
        }

        // ─────────────────────────────────────────────
        //  CMYK
        // ─────────────────────────────────────────────

        private void DrawCMYK()
        {
            const float K = 0f;

            void VertexCMYK(float c, float m, float y)
            {
                GL.Color3((1f - c) * (1f - K),
                          (1f - m) * (1f - K),
                          (1f - y) * (1f - K));
                GL.Vertex3(c, m, y);
            }

            GL.Begin(PrimitiveType.Quads);

            // Front  Y=0
            VertexCMYK(0, 0, 0); VertexCMYK(1, 0, 0); VertexCMYK(1, 1, 0); VertexCMYK(0, 1, 0);
            // Back   Y=1
            VertexCMYK(0, 0, 1); VertexCMYK(1, 0, 1); VertexCMYK(1, 1, 1); VertexCMYK(0, 1, 1);
            // Left   C=0
            VertexCMYK(0, 0, 0); VertexCMYK(0, 0, 1); VertexCMYK(0, 1, 1); VertexCMYK(0, 1, 0);
            // Right  C=1
            VertexCMYK(1, 0, 0); VertexCMYK(1, 0, 1); VertexCMYK(1, 1, 1); VertexCMYK(1, 1, 0);
            // Bottom M=0
            VertexCMYK(0, 0, 0); VertexCMYK(1, 0, 0); VertexCMYK(1, 0, 1); VertexCMYK(0, 0, 1);
            // Top    M=1
            VertexCMYK(0, 1, 0); VertexCMYK(1, 1, 0); VertexCMYK(1, 1, 1); VertexCMYK(0, 1, 1);

            GL.End();

            // Edges
            GL.LineWidth(1.5f);
            GL.Begin(PrimitiveType.Lines);

            for (int i = 0; i < CubeEdges.GetLength(0); i++)
            {
                int a = CubeEdges[i, 0], b = CubeEdges[i, 1];

                void EmitCMYKEdgeVertex(int idx)
                {
                    float r = Math.Min(1f, (1f - CubeVerts[idx, 0]) * (1f - K) + 0.15f);
                    float g = Math.Min(1f, (1f - CubeVerts[idx, 1]) * (1f - K) + 0.15f);
                    float bv = Math.Min(1f, (1f - CubeVerts[idx, 2]) * (1f - K) + 0.15f);
                    GL.Color3(r, g, bv);
                    GL.Vertex3(CubeVerts[idx, 0], CubeVerts[idx, 1], CubeVerts[idx, 2]);
                }

                EmitCMYKEdgeVertex(a);
                EmitCMYKEdgeVertex(b);
            }

            GL.End();
        }

        // ─────────────────────────────────────────────
        //  YCbCr
        // ─────────────────────────────────────────────

        private void DrawYCbCr()
        {
            GL.Begin(PrimitiveType.Quads);

            SetYCbCrVertex(0, 0, 0); SetYUVVertex(1, 0, 0); SetYUVVertex(1, 1, 0); SetYUVVertex(0, 1, 0);
            SetYCbCrVertex(0, 0, 1); SetYUVVertex(1, 0, 1); SetYUVVertex(1, 1, 1); SetYUVVertex(0, 1, 1);
            SetYCbCrVertex(0, 0, 0); SetYUVVertex(0, 0, 1); SetYUVVertex(0, 1, 1); SetYUVVertex(0, 1, 0);
            SetYCbCrVertex(1, 0, 0); SetYUVVertex(1, 0, 1); SetYUVVertex(1, 1, 1); SetYUVVertex(1, 1, 0);
            SetYCbCrVertex(0, 0, 0); SetYUVVertex(1, 0, 0); SetYUVVertex(1, 0, 1); SetYUVVertex(0, 0, 1);
            SetYCbCrVertex(0, 1, 0); SetYUVVertex(1, 1, 0); SetYUVVertex(1, 1, 1); SetYUVVertex(0, 1, 1);

            GL.End();

            DrawCubeEdgesWhite();
        }

        private void SetYCbCrVertex(float x, float y, float z)
        {
            float Y = 16f + x * (235f - 16f);
            float Cb = 16f + y * (240f - 16f);
            float Cr = 16f + z * (240f - 16f);

            Color c = YCbCrToColor(Y, Cb, Cr);
            GL.Color3(c);
            GL.Vertex3(x, y, z);
        }

        // ─────────────────────────────────────────────
        //  YUV
        // ─────────────────────────────────────────────

        private void DrawYUV()
        {
            GL.Begin(PrimitiveType.Quads);

            SetYUVVertex(0, 0, 0); SetYUVVertex(1, 0, 0); SetYUVVertex(1, 1, 0); SetYUVVertex(0, 1, 0);
            SetYUVVertex(0, 0, 1); SetYUVVertex(1, 0, 1); SetYUVVertex(1, 1, 1); SetYUVVertex(0, 1, 1);
            SetYUVVertex(0, 0, 0); SetYUVVertex(0, 0, 1); SetYUVVertex(0, 1, 1); SetYUVVertex(0, 1, 0);
            SetYUVVertex(1, 0, 0); SetYUVVertex(1, 0, 1); SetYUVVertex(1, 1, 1); SetYUVVertex(1, 1, 0);
            SetYUVVertex(0, 0, 0); SetYUVVertex(1, 0, 0); SetYUVVertex(1, 0, 1); SetYUVVertex(0, 0, 1);
            SetYUVVertex(0, 1, 0); SetYUVVertex(1, 1, 0); SetYUVVertex(1, 1, 1); SetYUVVertex(0, 1, 1);

            GL.End();

            DrawCubeEdgesWhite();
        }

        private void SetYUVVertex(float x, float y, float z)
        {
            Color c = YUVtoColor(
                Y: x,
                u: y - 0.5f,
                v: z - 0.5f);

            GL.Color3(c);
            GL.Vertex3(x, y, z);
        }

        private Color YUVtoColor(float Y, float u, float v)
        {
            double r = Math.Max(0, Math.Min(1, Y + 1.13983 * v));
            double g = Math.Max(0, Math.Min(1, Y - 0.39465 * u - 0.58060 * v));
            double b = Math.Max(0, Math.Min(1, Y + 2.03211 * u));

            return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
        }

        private void DrawCubeEdgesWhite()
        {
            GL.LineWidth(1.5f);
            GL.Color3(Color.White);
            GL.Begin(PrimitiveType.Lines);

            for (int i = 0; i < CubeEdges.GetLength(0); i++)
            {
                int a = CubeEdges[i, 0], b = CubeEdges[i, 1];
                GL.Vertex3(CubeVerts[a, 0], CubeVerts[a, 1], CubeVerts[a, 2]);
                GL.Vertex3(CubeVerts[b, 0], CubeVerts[b, 1], CubeVerts[b, 2]);
            }

            GL.End();
        }

        // ─────────────────────────────────────────────
        //  LAB (Sphere)
        // ─────────────────────────────────────────────

        private void DrawLAB()
        {
            const int stacks = 30;
            const int slices = 30;
            const float radius = 1.2f;

            for (int i = 0; i < stacks; i++)
            {
                double lat0 = Math.PI * (-0.5 + (double)i / stacks);
                double lat1 = Math.PI * (-0.5 + (double)(i + 1) / stacks);

                double z0 = Math.Sin(lat0), zr0 = Math.Cos(lat0);
                double z1 = Math.Sin(lat1), zr1 = Math.Cos(lat1);

                GL.Begin(PrimitiveType.QuadStrip);

                for (int j = 0; j <= slices; j++)
                {
                    double lng = 2 * Math.PI * (j - 1) / slices;
                    double x = Math.Cos(lng);
                    double y = Math.Sin(lng);

                    DrawLABPoint(x * zr0, y * zr0, z0, radius);
                    DrawLABPoint(x * zr1, y * zr1, z1, radius);
                }

                GL.End();
            }
        }

        private void DrawLABPoint(double x, double y, double z, float radius)
        {
            float px = (float)(x * radius);
            float py = (float)(y * radius);
            float pz = (float)(z * radius);

            float L = (py / radius + 1f) / 2f;
            float A = px / radius;
            float B = pz / radius;

            GL.Color3(LABtoColor(L, A, B));
            GL.Vertex3(px, py, pz);
        }

        private Color LABtoColor(float l, float a, float b)
        {
            float brightness = (float)Math.Pow(l, 1.2f);

            float r = Math.Max(0f, Math.Min(1f, brightness + a * 0.5f + b * 0.25f));
            float g = Math.Max(0f, Math.Min(1f, brightness - a * 0.5f + b * 0.25f));
            float bv = Math.Max(0f, Math.Min(1f, brightness - b * 0.5f));

            return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(bv * 255));
        }

        // ─────────────────────────────────────────────
        //  HSV (Cone)
        // ─────────────────────────────────────────────

        private void DrawHSV()
        {
            const int stepsH = 60;
            const int stepsV = 30;
            const float scale = 1.2f;

            // Cone surface
            GL.Begin(PrimitiveType.Quads);

            for (int i = 0; i < stepsH; i++)
            {
                float h1 = (i / (float)stepsH) * 360f;
                float h2 = ((i + 1) / (float)stepsH) * 360f;
                float a1 = MathHelper.DegreesToRadians(h1);
                float a2 = MathHelper.DegreesToRadians(h2);

                for (int j = 0; j < stepsV; j++)
                {
                    float v1 = j / (float)stepsV;
                    float v2 = (j + 1) / (float)stepsV;
                    float r1 = v1 * scale;
                    float r2 = v2 * scale;

                    Vector3 p1 = new(r1 * (float)Math.Cos(a1), v1 * 2f - 1f, r1 * (float)Math.Sin(a1));
                    Vector3 p2 = new(r1 * (float)Math.Cos(a2), v1 * 2f - 1f, r1 * (float)Math.Sin(a2));
                    Vector3 p3 = new(r2 * (float)Math.Cos(a2), v2 * 2f - 1f, r2 * (float)Math.Sin(a2));
                    Vector3 p4 = new(r2 * (float)Math.Cos(a1), v2 * 2f - 1f, r2 * (float)Math.Sin(a1));

                    GL.Color3(HSVtoColor(h1, 1f, v1)); GL.Vertex3(p1);
                    GL.Color3(HSVtoColor(h2, 1f, v1)); GL.Vertex3(p2);
                    GL.Color3(HSVtoColor(h2, 1f, v2)); GL.Vertex3(p3);
                    GL.Color3(HSVtoColor(h1, 1f, v2)); GL.Vertex3(p4);
                }
            }

            GL.End();

            // Top cap (V=1) — colored disk
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color3(Color.White);
            GL.Vertex3(0f, 1f, 0f);

            for (int i = 0; i <= stepsH; i++)
            {
                float h = (i / (float)stepsH) * 360f;
                float a = MathHelper.DegreesToRadians(h);
                float r = scale;
                GL.Color3(HSVtoColor(h, 1f, 1f));
                GL.Vertex3(r * (float)Math.Cos(a), 1f, r * (float)Math.Sin(a));
            }

            GL.End();

            // Bottom tip (V=0) — black point
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color3(Color.Black);
            GL.Vertex3(0f, -1f, 0f);

            float vSmall = 1f / stepsV;
            for (int i = 0; i <= stepsH; i++)
            {
                float h = (i / (float)stepsH) * 360f;
                float a = MathHelper.DegreesToRadians(h);
                float r = vSmall * scale;
                GL.Color3(HSVtoColor(h, 1f, vSmall));
                GL.Vertex3(r * (float)Math.Cos(a), vSmall * 2f - 1f, r * (float)Math.Sin(a));
            }

            GL.End();
        }

        private Color HSVtoColor(float h, float s, float v)
        {
            int hi = (int)(h / 60) % 6;
            float f = (h / 60) - (int)(h / 60);

            float vf = v * 255;
            byte V = (byte)vf;
            byte p = (byte)(vf * (1 - s));
            byte q = (byte)(vf * (1 - f * s));
            byte t = (byte)(vf * (1 - (1 - f) * s));

            return hi switch
            {
                0 => Color.FromArgb(V, t, p),
                1 => Color.FromArgb(q, V, p),
                2 => Color.FromArgb(p, V, t),
                3 => Color.FromArgb(p, q, V),
                4 => Color.FromArgb(t, p, V),
                _ => Color.FromArgb(V, p, q),
            };
        }

        private Color YCbCrToColor(float Y, float Cb, float Cr)
        {
            double y = (Y - 16f) / (235f - 16f);
            double cb = (Cb - 16f) / (240f - 16f) - 0.5;
            double cr = (Cr - 16f) / (240f - 16f) - 0.5;

            double r = y + 1.402 * cr;
            double g = y - 0.34414 * cb - 0.71414 * cr;
            double b = y + 1.772 * cb;

            r = Math.Max(0, Math.Min(1, r));
            g = Math.Max(0, Math.Min(1, g));
            b = Math.Max(0, Math.Min(1, b));

            return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
        }

        // ─────────────────────────────────────────────
        //  Color Space Conversions (static utilities)
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

            C = cmyk.C;
            M = cmyk.M;
            Y = cmyk.Y;
            K = cmyk.K;
        }

        public static void RGBtoYUV(Color c, out double Y, out double U, out double V)
        {
            double r = c.R / 255.0;
            double g = c.G / 255.0;
            double b = c.B / 255.0;

            Y = 0.299 * r + 0.587 * g + 0.114 * b;
            U = -0.14713 * r - 0.28886 * g + 0.436 * b;
            V = 0.615 * r - 0.51499 * g - 0.10001 * b;
        }

        public static void RGBtoLAB(Color c, out double L, out double a, out double b)
        {
            var rgb = new Rgb { R = c.R, G = c.G, B = c.B };
            var lab = rgb.To<Lab>();

            L = lab.L;
            a = lab.A;
            b = lab.B;
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