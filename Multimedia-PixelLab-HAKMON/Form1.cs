using OpenTK;
using OpenTK.Graphics.OpenGL;
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

    public partial class Form1 : Form
    {

        ColorSystem currentSystem = ColorSystem.HSV;
        float angle = 0;
        private float rotX = 20f, rotY = 30f;
        private Point lastMouse;
        private bool isDragging = false;
        private float zoom = 3.5f;

        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            glControl1.Paint += glControl1_Paint;
            glControl1.Load += glControl1_Load;
            glControl1.Resize += glControl1_Resize;
            glControl1.MouseDown += glControl1_MouseDown;
            glControl1.MouseMove += glControl1_MouseMove;
            glControl1.MouseUp += glControl1_MouseUp;
            glControl1.MouseWheel += glControl1_MouseWheel;
            pictureBox1.AllowDrop = true;
        }
        Bitmap image;
        private void openImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void pictureBox1_DragDrop_1(object sender, DragEventArgs e)
        {
            // ÃÎÐ ÇáãáÝÇÊ
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // ÚÑÖ Ãæá ÕæÑÉ
            if (files.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(files[0]);
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            // ÇáÊÃßÏ Ãä ÇáãáÝ ÕæÑÉ
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void glControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMouse = e.Location;
                glControl1.Cursor = Cursors.SizeAll;
            }
        }

        private void glControl1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            glControl1.Cursor = Cursors.Default;
        }

        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // التدوير بالسحب
                rotY += (e.X - lastMouse.X) * 0.5f;
                rotX += (e.Y - lastMouse.Y) * 0.5f;

                // تقييد التدوير الرأسي
                rotX = Math.Max(-89f, Math.Min(89f, rotX));

                lastMouse = e.Location;
                glControl1.Invalidate(); // أعد الرسم
                return;
            }

            // Hover — اقرأ لون البكسل
            glControl1.MakeCurrent();
            int glY = glControl1.Height - e.Y;
            byte[] pixel = new byte[3];
            GL.ReadPixels(e.X, glY, 1, 1,
                PixelFormat.Rgb, PixelType.UnsignedByte, pixel);

            if (pixel[0] < 8 && pixel[1] < 8 && pixel[2] < 8) return;
            //ShowColorComponents(Color.FromArgb(pixel[0], pixel[1], pixel[2]));
        }

        private void glControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            zoom -= e.Delta * 0.002f;
            zoom = Math.Max(0.5f, Math.Min(8f, zoom));
            glControl1.Invalidate();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.1f, 0.1f, 0.1f, 1f); // خلفية داكنة تظهر المخروط أوضح
            GL.Enable(EnableCap.DepthTest);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            float aspect = glControl1.Width / (float)glControl1.Height;
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(45f),  // زاوية أضيق = أقل تشويه
                aspect, 0.1f, 100f
            );
            GL.LoadMatrix(ref perspective);
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            glControl1.MakeCurrent();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            Matrix4 lookAt = Matrix4.LookAt(
                0f, 0.5f, zoom,  // ✅ شاهد من الأمام مع ارتفاع طفيف
                0f, 0f, 0f,    // انظر للمركز
                0f, 1f, 0f
            );
            GL.LoadMatrix(ref lookAt);

            // دوران تلقائي أو بالماوس
           // GL.Rotate(angle, 0f, 1f, 0f);

            GL.Rotate(rotX, 1f, 0f, 0f);
            GL.Rotate(rotY, 0f, 1f, 0f);

            DrawAxes();

            switch (currentSystem)
            {
                case ColorSystem.RGB: DrawRGB(); break;
                case ColorSystem.HSV: DrawHSV(); break;
                case ColorSystem.CMYK: DrawCMYK(); break;
            }

            GL.Flush();
            glControl1.SwapBuffers();
        }

        private void DrawAxes()
        {
            GL.LineWidth(3f);

            GL.Begin(PrimitiveType.Lines);

            // ================= X Axis =================
            // أحمر
            GL.Color3(Color.Red);
            GL.Vertex3(0f, 0f, 0f);
            GL.Vertex3(3f, 0f, 0f);

            // ================= Y Axis =================
            // أخضر
            GL.Color3(Color.Lime);
            GL.Vertex3(0f, 0f, 0f);
            GL.Vertex3(0f, 3f, 0f);

            // ================= Z Axis =================
            // أزرق
            GL.Color3(Color.Blue);
            GL.Vertex3(0f, 0f, 0f);
            GL.Vertex3(0f, 0f, 3f);

            GL.End();
        }
        private void DrawRGB()
        {
            // كل وجه يُرسم بـ GL_QUADS مع تدرج لوني حقيقي
            // كل vertex له لونه الصحيح بناءً على موضعه (R,G,B)
            // Color(x, y, z) = Color(R, G, B) مباشرة

            GL.Begin(PrimitiveType.Quads);

            // ======================================================
            // الوجه الأمامي — Z=0  (B=0)
            // ======================================================
            GL.Color3(0f, 0f, 0f); GL.Vertex3(0f, 0f, 0f); // أسود
            GL.Color3(1f, 0f, 0f); GL.Vertex3(1f, 0f, 0f); // أحمر
            GL.Color3(1f, 1f, 0f); GL.Vertex3(1f, 1f, 0f); // أصفر
            GL.Color3(0f, 1f, 0f); GL.Vertex3(0f, 1f, 0f); // أخضر

            // ======================================================
            // الوجه الخلفي — Z=1  (B=1)
            // ======================================================
            GL.Color3(0f, 0f, 1f); GL.Vertex3(0f, 0f, 1f); // أزرق
            GL.Color3(1f, 0f, 1f); GL.Vertex3(1f, 0f, 1f); // ماجنتا
            GL.Color3(1f, 1f, 1f); GL.Vertex3(1f, 1f, 1f); // أبيض
            GL.Color3(0f, 1f, 1f); GL.Vertex3(0f, 1f, 1f); // سيان

            // ======================================================
            // الوجه الأيسر — X=0  (R=0)
            // ======================================================
            GL.Color3(0f, 0f, 0f); GL.Vertex3(0f, 0f, 0f); // أسود
            GL.Color3(0f, 0f, 1f); GL.Vertex3(0f, 0f, 1f); // أزرق
            GL.Color3(0f, 1f, 1f); GL.Vertex3(0f, 1f, 1f); // سيان
            GL.Color3(0f, 1f, 0f); GL.Vertex3(0f, 1f, 0f); // أخضر

            // ======================================================
            // الوجه الأيمن — X=1  (R=1)
            // ======================================================
            GL.Color3(1f, 0f, 0f); GL.Vertex3(1f, 0f, 0f); // أحمر
            GL.Color3(1f, 0f, 1f); GL.Vertex3(1f, 0f, 1f); // ماجنتا
            GL.Color3(1f, 1f, 1f); GL.Vertex3(1f, 1f, 1f); // أبيض
            GL.Color3(1f, 1f, 0f); GL.Vertex3(1f, 1f, 0f); // أصفر

            // ======================================================
            // الوجه السفلي — Y=0  (G=0)
            // ======================================================
            GL.Color3(0f, 0f, 0f); GL.Vertex3(0f, 0f, 0f); // أسود
            GL.Color3(1f, 0f, 0f); GL.Vertex3(1f, 0f, 0f); // أحمر
            GL.Color3(1f, 0f, 1f); GL.Vertex3(1f, 0f, 1f); // ماجنتا
            GL.Color3(0f, 0f, 1f); GL.Vertex3(0f, 0f, 1f); // أزرق

            // ======================================================
            // الوجه العلوي — Y=1  (G=1)
            // ======================================================
            GL.Color3(0f, 1f, 0f); GL.Vertex3(0f, 1f, 0f); // أخضر
            GL.Color3(1f, 1f, 0f); GL.Vertex3(1f, 1f, 0f); // أصفر
            GL.Color3(1f, 1f, 1f); GL.Vertex3(1f, 1f, 1f); // أبيض
            GL.Color3(0f, 1f, 1f); GL.Vertex3(0f, 1f, 1f); // سيان

            GL.End();

            // ======================================================
            // حواف المكعب — تظهر الشكل أوضح
            // ======================================================
            GL.LineWidth(1.5f);
            GL.Begin(PrimitiveType.Lines);

            int[,] edges = {
                 {0,1},{1,3},{3,2},{2,0}, // الوجه الأمامي
                 {4,5},{5,7},{7,6},{6,4}, // الوجه الخلفي
                 {0,4},{1,5},{2,6},{3,7}  // الحواف الجانبية
            };
             
             float[,] verts = {
                 {0,0,0},{1,0,0},{0,1,0},{1,1,0},
                 {0,0,1},{1,0,1},{0,1,1},{1,1,1}
             };

            for (int i = 0; i < edges.GetLength(0); i++)
            {
                int a = edges[i, 0], b = edges[i, 1];

                // لون الحافة = متوسط لوني بين الطرفين + تفتيح للإبراز
                float ra = Math.Min(1f, verts[a, 0] * 0.6f + 0.4f);
                float ga = Math.Min(1f, verts[a, 1] * 0.6f + 0.4f);
                float ba = Math.Min(1f, verts[a, 2] * 0.6f + 0.4f);
                GL.Color3(ra, ga, ba);
                GL.Vertex3(verts[a, 0], verts[a, 1], verts[a, 2]);

                float rb = Math.Min(1f, verts[b, 0] * 0.6f + 0.4f);
                float gb = Math.Min(1f, verts[b, 1] * 0.6f + 0.4f);
                float bb = Math.Min(1f, verts[b, 2] * 0.6f + 0.4f);
                GL.Color3(rb, gb, bb);
                GL.Vertex3(verts[b, 0], verts[b, 1], verts[b, 2]);
            }

            GL.End();
        }

        private void DrawCMYK()
        {
            // ======================================================
            // مبدأ التمثيل:
            // X-axis = C (Cyan    0→1)
            // Y-axis = M (Magenta 0→1)
            // Z-axis = Y (Yellow  0→1)
            // K ثابت = 0 (لإظهار كامل الألوان)
            //
            // تحويل CMYK→RGB:
            // R = (1-C) * (1-K)
            // G = (1-M) * (1-K)
            // B = (1-Y) * (1-K)
            // ======================================================

            float K = 0f; // K=0 لإظهار أوضح الألوان

            // دالة مساعدة محلية: تحويل موضع vertex إلى لون
            // C=x, M=y, Y=z
            void VertexCMYK(float c, float m, float y)
            {
                float r = (1f - c) * (1f - K);
                float g = (1f - m) * (1f - K);
                float b = (1f - y) * (1f - K);
                GL.Color3(r, g, b);
                GL.Vertex3(c, m, y);
            }

            GL.Begin(PrimitiveType.Quads);

            // ======================================================
            // الوجه الأمامي — Y=0 (Yellow=0)
            // C: 0→1  M: 0→1
            // ======================================================
            VertexCMYK(0f, 0f, 0f); // أبيض     (C=0,M=0,Y=0)
            VertexCMYK(1f, 0f, 0f); // سيان     (C=1,M=0,Y=0)
            VertexCMYK(1f, 1f, 0f); // أزرق     (C=1,M=1,Y=0)
            VertexCMYK(0f, 1f, 0f); // ماجنتا  (C=0,M=1,Y=0)

            // ======================================================
            // الوجه الخلفي — Y=1 (Yellow=1)
            // ======================================================
            VertexCMYK(0f, 0f, 1f); // أصفر    (C=0,M=0,Y=1)
            VertexCMYK(1f, 0f, 1f); // أخضر    (C=1,M=0,Y=1)
            VertexCMYK(1f, 1f, 1f); // أسود    (C=1,M=1,Y=1)
            VertexCMYK(0f, 1f, 1f); // أحمر    (C=0,M=1,Y=1)

            // ======================================================
            // الوجه الأيسر — C=0 (Cyan=0)
            // ======================================================
            VertexCMYK(0f, 0f, 0f); // أبيض
            VertexCMYK(0f, 0f, 1f); // أصفر
            VertexCMYK(0f, 1f, 1f); // أحمر
            VertexCMYK(0f, 1f, 0f); // ماجنتا

            // ======================================================
            // الوجه الأيمن — C=1 (Cyan=1)
            // ======================================================
            VertexCMYK(1f, 0f, 0f); // سيان
            VertexCMYK(1f, 0f, 1f); // أخضر
            VertexCMYK(1f, 1f, 1f); // أسود
            VertexCMYK(1f, 1f, 0f); // أزرق

            // ======================================================
            // الوجه السفلي — M=0 (Magenta=0)
            // ======================================================
            VertexCMYK(0f, 0f, 0f); // أبيض
            VertexCMYK(1f, 0f, 0f); // سيان
            VertexCMYK(1f, 0f, 1f); // أخضر
            VertexCMYK(0f, 0f, 1f); // أصفر

            // ======================================================
            // الوجه العلوي — M=1 (Magenta=1)
            // ======================================================
            VertexCMYK(0f, 1f, 0f); // ماجنتا
            VertexCMYK(1f, 1f, 0f); // أزرق
            VertexCMYK(1f, 1f, 1f); // أسود
            VertexCMYK(0f, 1f, 1f); // أحمر

            GL.End();

            // ======================================================
            // حواف المكعب
            // ======================================================
            GL.LineWidth(1.5f);
            GL.Begin(PrimitiveType.Lines);

            int[,] edges = {
        {0,1},{1,3},{3,2},{2,0},
        {4,5},{5,7},{7,6},{6,4},
        {0,4},{1,5},{2,6},{3,7}
    };

            // زوايا المكعب: C,M,Y
            float[,] corners = {
        {0,0,0},{1,0,0},{0,1,0},{1,1,0},
        {0,0,1},{1,0,1},{0,1,1},{1,1,1}
    };

            for (int i = 0; i < edges.GetLength(0); i++)
            {
                int a = edges[i, 0], b = edges[i, 1];

                // لون الحافة من CMYK→RGB مع تفتيح طفيف
                float LightenAndConvert(float c, float m, float y, out float rr, out float gg, out float bb)
                {
                    rr = Math.Min(1f, (1f - c) * (1f - K) + 0.15f);
                    gg = Math.Min(1f, (1f - m) * (1f - K) + 0.15f);
                    bb = Math.Min(1f, (1f - y) * (1f - K) + 0.15f);
                    return 0;
                }

                LightenAndConvert(corners[a, 0], corners[a, 1], corners[a, 2],
                    out float ra, out float ga, out float ba);
                GL.Color3(ra, ga, ba);
                GL.Vertex3(corners[a, 0], corners[a, 1], corners[a, 2]);

                LightenAndConvert(corners[b, 0], corners[b, 1], corners[b, 2],
                    out float rb, out float gb, out float bb2);
                GL.Color3(rb, gb, bb2);
                GL.Vertex3(corners[b, 0], corners[b, 1], corners[b, 2]);
            }

            GL.End();
        }

        private void DrawHSV()
        {
            int stepsH = 60; // عدد شرائح Hue
            int stepsV = 30; // عدد طبقات V

            float scale = 1.2f; // حجم المخروط

            // ======================================================
            // الجسم الرئيسي للمخروط — quads على السطح الخارجي
            // ======================================================
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

                    // ✅ الإصلاح الجوهري:
                    // radius = V * scale  →  عند V=0 النقطة صفر (قمة المخروط)
                    //                        عند V=1 النقطة أكبر (قاعدة المخروط)
                    float r1 = v1 * scale;
                    float r2 = v2 * scale;

                    // S = 1 دائماً على السطح الخارجي للمخروط
                    float s = 1f;

                    Vector3 p1 = new Vector3(r1 * (float)Math.Cos(a1), v1 * 2f - 1f, r1 * (float)Math.Sin(a1));
                    Vector3 p2 = new Vector3(r1 * (float)Math.Cos(a2), v1 * 2f - 1f, r1 * (float)Math.Sin(a2));
                    Vector3 p3 = new Vector3(r2 * (float)Math.Cos(a2), v2 * 2f - 1f, r2 * (float)Math.Sin(a2));
                    Vector3 p4 = new Vector3(r2 * (float)Math.Cos(a1), v2 * 2f - 1f, r2 * (float)Math.Sin(a1));

                    GL.Color3(HSVtoColor(h1, s, v1)); GL.Vertex3(p1);
                    GL.Color3(HSVtoColor(h2, s, v1)); GL.Vertex3(p2);
                    GL.Color3(HSVtoColor(h2, s, v2)); GL.Vertex3(p3);
                    GL.Color3(HSVtoColor(h1, s, v2)); GL.Vertex3(p4);
                }
            }

            GL.End();

            // ======================================================
            // قاعدة المخروط العلوية (V=1) — دائرة ملونة كاملة
            // ======================================================
            GL.Begin(PrimitiveType.TriangleFan);

            // المركز = أبيض (H=0, S=0, V=1)
            GL.Color3(Color.White);
            GL.Vertex3(0f, 1f, 0f);  // مركز القاعدة

            for (int i = 0; i <= stepsH; i++)
            {
                float h = (i / (float)stepsH) * 360f;
                float a = MathHelper.DegreesToRadians(h);
                float r = 1f * scale; // V=1 → أكبر radius

                GL.Color3(HSVtoColor(h, 1f, 1f));
                GL.Vertex3(r * (float)Math.Cos(a), 1f, r * (float)Math.Sin(a));
            }

            GL.End();

            // ======================================================
            // قمة المخروط السفلية (V=0) — نقطة سوداء واحدة
            // ======================================================
            GL.Begin(PrimitiveType.TriangleFan);

            // القمة = أسود (V=0, radius=0)
            GL.Color3(Color.Black);
            GL.Vertex3(0f, -1f, 0f);  // قمة المخروط

            for (int i = 0; i <= stepsH; i++)
            {
                float h = (i / (float)stepsH) * 360f;
                float a = MathHelper.DegreesToRadians(h);
                // أصغر layer فوق القمة مباشرة
                float vSmall = 1f / stepsV;
                float r = vSmall * scale;

                GL.Color3(HSVtoColor(h, 1f, vSmall));
                GL.Vertex3(r * (float)Math.Cos(a), vSmall * 2f - 1f, r * (float)Math.Sin(a));
            }

            GL.End();
        }

        // ===================== HSV TO RGB =====================
        private Color HSVtoColor(float h, float s, float v)
        {
            int hi = (int)(h / 60) % 6;
            float f = (h / 60) - (int)(h / 60);

            v = v * 255;
            byte V = (byte)v;
            byte p = (byte)(v * (1 - s));
            byte q = (byte)(v * (1 - f * s));
            byte t = (byte)(v * (1 - (1 - f) * s));

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

        private void glControl1_Resize(object sender, EventArgs e)
        {
            glControl1.MakeCurrent();

            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);

            glControl1.Invalidate();
        }

        private void glControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSystem = comboBox1.SelectedIndex switch
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

        private void glControl1_MouseClick(object sender, MouseEventArgs e)
        {
            // فقط الزر الأيسر
            if (e.Button != MouseButtons.Left)
                return;

            glControl1.MakeCurrent();

            // تحويل إحداثيات Y لأن OpenGL يبدأ من الأسفل
            int glY = glControl1.Height - e.Y;

            // تخزين RGB للبكسل
            byte[] pixel = new byte[3];

            // قراءة لون البكسل من الـ framebuffer
            GL.ReadPixels(
                e.X,
                glY,
                1,
                1,
                PixelFormat.Rgb,
                PixelType.UnsignedByte,
                pixel
            );

            // إنشاء اللون المقروء
            Color selectedColor = Color.FromArgb(
                pixel[0],
                pixel[1],
                pixel[2]
            );

            // تجاهل الخلفية الداكنة
            bool isBackground =
                pixel[0] < 8 &&
                pixel[1] < 8 &&
                pixel[2] < 8;

            if (isBackground)
            {
                // تصفير القيم
                num1.Value = 0;
                num2.Value = 0;
                num3.Value = 0;
                num4.Value = 0;

                return;
            }

            // عرض مركبات اللون حسب النظام الحالي
            ShowColorComponents(selectedColor);
        }

        private void ShowColorComponents(Color c)
        {
            switch (currentSystem)
            {
                // =====================================
                // RGB
                // =====================================
                case ColorSystem.RGB:

                    num1.Value = c.R;
                    num2.Value = c.G;
                    num3.Value = c.B;
                    num4.Value = 0;

                    break;

                // =====================================
                // HSV
                // =====================================
                case ColorSystem.HSV:

                    RGBtoHSV(c,
                        out double h,
                        out double s,
                        out double v);

                    num1.Value = (decimal)h;
                    num2.Value = (decimal)(s * 100);
                    num3.Value = (decimal)(v * 100);
                    num4.Value = 0;

                    break;

                case ColorSystem.CMYK:
                    {
                        RGBtoCMYK(c, out double cy, out double m, out double y, out double k);

                        num1.Value = (decimal)(cy * 100);
                        num2.Value = (decimal)(m * 100);
                        num3.Value = (decimal)(y * 100);
                        num4.Value = (decimal)(k * 100);
                    }
                    break;
            }
        }

        public static void RGBtoHSV(Color c,
    out double h, out double s, out double v)
        {
            double r = c.R / 255.0, g = c.G / 255.0, b = c.B / 255.0;
            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));
            double delta = max - min;
            v = max;
            s = max == 0 ? 0 : delta / max;
            if (delta == 0) { h = 0; return; }
            if (max == r) h = 60 * (((g - b) / delta) % 6);
            else if (max == g) h = 60 * (((b - r) / delta) + 2);
            else h = 60 * (((r - g) / delta) + 4);
            if (h < 0) h += 360;
        }

        public static void RGBtoCMYK(Color c,
            out double C, out double M, out double Y, out double K)
        {
            double r = c.R / 255.0, g = c.G / 255.0, b = c.B / 255.0;
            K = 1 - Math.Max(r, Math.Max(g, b));
            if (K >= 1) { C = M = Y = 0; return; }
            C = (1 - r - K) / (1 - K);
            M = (1 - g - K) / (1 - K);
            Y = (1 - b - K) / (1 - K);
        }

        public static void RGBtoYUV(Color c,
            out double Y, out double U, out double V)
        {
            double r = c.R / 255.0, g = c.G / 255.0, b = c.B / 255.0;
            Y = 0.299 * r + 0.587 * g + 0.114 * b;
            U = -0.14713 * r - 0.28886 * g + 0.436 * b;
            V = 0.615 * r - 0.51499 * g - 0.10001 * b;
        }

        public static void RGBtoLAB(Color c,
            out double L, out double a, out double b)
        {
            double Lin(double v) =>
                v > 0.04045 ? Math.Pow((v + 0.055) / 1.055, 2.4) : v / 12.92;
            double r = Lin(c.R / 255.0);
            double g = Lin(c.G / 255.0);
            double bv = Lin(c.B / 255.0);
            double X = r * 0.4124 + g * 0.3576 + bv * 0.1805;
            double Y2 = r * 0.2126 + g * 0.7152 + bv * 0.0722;
            double Z = r * 0.0193 + g * 0.1192 + bv * 0.9505;
            double f(double t) =>
                t > 0.008856 ? Math.Pow(t, 1.0 / 3) : 7.787 * t + 16.0 / 116;
            L = 116 * f(Y2 / 1.0) - 16;
            a = 500 * (f(X / 0.95047) - f(Y2 / 1.0));
            b = 200 * (f(Y2 / 1.0) - f(Z / 1.08883));
        }

        public static void RGBtoYCbCr(Color c,
            out int Y, out int Cb, out int Cr)
        {
            double r = c.R, g = c.G, b = c.B;
            Y = (int)(16 + 65.481 * r / 255 + 128.553 * g / 255 + 24.966 * b / 255);
            Cb = (int)(128 - 37.797 * r / 255 - 74.203 * g / 255 + 112.000 * b / 255);
            Cr = (int)(128 + 112.000 * r / 255 - 93.786 * g / 255 - 18.214 * b / 255);
            Y = Math.Max(16, Math.Min(235, Y));
            Cb = Math.Max(16, Math.Min(240, Cb));
            Cr = Math.Max(16, Math.Min(240, Cr));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentSystem++;

            if (currentSystem > ColorSystem.YCbCr)
                currentSystem = ColorSystem.RGB;

            glControl1.Invalidate();
        }
    }
}