using Emgu.CV;
using Emgu.CV.CvEnum;
using KGySoft.Drawing.Imaging;
using KGySoft.Drawing;

namespace Multimedia_PixelLab_HAKMON
{
    public partial class Form1 : Form
    {
        String pathImage="";
        Bitmap image;
        Bitmap originalImage;

        bool isResetting = false;
        List<Panel> colorSystemsPanel = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
            Scene.AllowDrop = true;

            comboBoxColorSystems.Enabled = false;
            comboBox1.Enabled = false;
            resetImage.Enabled = false;
            number_of_colors_7.Enabled = false;
            colorSystemsPanel.Add(RGB_Panel);
            colorSystemsPanel.Add(CMYK_Panel);
            colorSystemsPanel.Add(HSV_Panel);
            colorSystemsPanel.Add(YUV_Panel);
            colorSystemsPanel.Add(LAB_Panel);
            colorSystemsPanel.Add(YCbCr_Panel);
            comboBoxColorSystems.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            RGB_Panel.Enabled = false;
            ShowPanel(0);
            reset_value_sysColor(true);
            initEvents();
        }

        //============================
        // 1) Import & Drag 
        //============================
        private void openImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Scene.Image = Image.FromFile(openFileDialog1.FileName);
                originalImage = new Bitmap(openFileDialog1.FileName);
                image = new Bitmap(openFileDialog1.FileName);
                pathImage = openFileDialog1.FileName;
                comboBoxColorSystems.Enabled = true;
                comboBox1.Enabled = true;
                RGB_Panel.Enabled = true;
                resetImage.Enabled = true;
                number_of_colors_7.Enabled = true;
                Image_information_8.Invalidate();
            }
        }

        private void pictureBox1_DragDrop_1(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                Scene.Image = Image.FromFile(files[0]);
                originalImage = new Bitmap(files[0]);
                image = new Bitmap(files[0]);
                pathImage = files[0];
                comboBoxColorSystems.Enabled = true;
                comboBox1.Enabled = true;
                RGB_Panel.Enabled = true;
                resetImage.Enabled = true;
                number_of_colors_7.Enabled = true;
                Image_information_8.Invalidate();
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        //============================
        // 2) Convert Color Systems
        //============================
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (image == null)
                return;

            string selectedSystem = comboBox1.SelectedItem.ToString();

            Mat inputImage = image.ToMat();
            Mat outputImage = new Mat();

            switch (selectedSystem)
            {
                case "RGB":
                    Scene.Image = image;
                    return;

                case "CMYK":
                    ConvertToCMYK();
                    return;

                case "HSV":
                    CvInvoke.CvtColor(inputImage, outputImage, ColorConversion.Bgr2Hsv);
                    break;

                case "YUV":
                    CvInvoke.CvtColor(inputImage, outputImage, ColorConversion.Bgr2Yuv);
                    break;

                case "LAB":
                    CvInvoke.CvtColor(inputImage, outputImage, ColorConversion.Bgr2Lab);
                    break;

                case "YCbCr":
                    CvInvoke.CvtColor(inputImage, outputImage, ColorConversion.Bgr2YCrCb);
                    break;
            }
            Scene.Image = outputImage.ToBitmap();
        }
        private void ConvertToCMYK()
        {
            Bitmap cmykImage = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    int c = 255 - pixel.R;
                    int m = 255 - pixel.G;
                    int yC = 255 - pixel.B;

                    Color cmykColor = Color.FromArgb(c, m, yC);

                    cmykImage.SetPixel(x, y, cmykColor);
                }
            }

            Scene.Image = cmykImage;
        }
        //============================
        // 3) Change CS Components
        //============================
        private void initEvents()
        {
            // RGB
            RGB_R.ValueChanged += ColorSystem_ValueChanged;
            RGB_G.ValueChanged += ColorSystem_ValueChanged;
            RGB_B.ValueChanged += ColorSystem_ValueChanged;

            // CMYK
            CMYK_C.ValueChanged += ColorSystem_ValueChanged;
            CMYK_M.ValueChanged += ColorSystem_ValueChanged;
            CMYK_Y.ValueChanged += ColorSystem_ValueChanged;
            CMYK_K.ValueChanged += ColorSystem_ValueChanged;

            // HSV
            HSV_H.ValueChanged += ColorSystem_ValueChanged;
            HSV_S.ValueChanged += ColorSystem_ValueChanged;
            HSV_V.ValueChanged += ColorSystem_ValueChanged;

            // YUV
            YUV_Y.ValueChanged += ColorSystem_ValueChanged;
            YUV_U.ValueChanged += ColorSystem_ValueChanged;
            YUV_V.ValueChanged += ColorSystem_ValueChanged;

            // LAB
            LAB_L.ValueChanged += ColorSystem_ValueChanged;
            LAB_A.ValueChanged += ColorSystem_ValueChanged;
            LAB_B.ValueChanged += ColorSystem_ValueChanged;

            // YCbCr
            YCbCr_Y.ValueChanged += ColorSystem_ValueChanged;
            YCbCr_Cb.ValueChanged += ColorSystem_ValueChanged;
            YCbCr_Cr.ValueChanged += ColorSystem_ValueChanged;
        }
        private void ColorSystem_ValueChanged(object sender, EventArgs e)
        {
            if (isResetting) return;
            if (image == null) return;


            string selectedSystem = comboBoxColorSystems.SelectedItem.ToString();
            Bitmap source = originalImage;                          // ⬅️ الأساس الثابت
            Bitmap tempImage = new Bitmap(source.Width, source.Height);

            if (selectedSystem == "LAB")
            {
                ApplyLAB();
                return;
            }

            double f1 = 1, f2 = 1, f3 = 1, f4 = 1;

            switch (selectedSystem)
            {
                case "RGB":
                    f1 = (double)RGB_R.Value / 50.0;
                    f2 = (double)RGB_G.Value / 50.0;
                    f3 = (double)RGB_B.Value / 50.0;
                    break;
                case "CMYK":
                    f1 = (double)CMYK_C.Value / 50.0;
                    f2 = (double)CMYK_M.Value / 50.0;
                    f3 = (double)CMYK_Y.Value / 50.0;
                    f4 = (double)CMYK_K.Value / 50.0;
                    break;
                case "HSV":
                    f1 = (double)HSV_H.Value / 50.0;
                    f2 = (double)HSV_S.Value / 50.0;
                    f3 = (double)HSV_V.Value / 50.0;
                    break;
                case "YUV":
                    f1 = (double)YUV_Y.Value / 50.0;
                    f2 = (double)YUV_U.Value / 50.0;
                    f3 = (double)YUV_V.Value / 50.0;
                    break;
                case "YCbCr":
                    f1 = (double)YCbCr_Y.Value / 50.0;
                    f2 = (double)YCbCr_Cb.Value / 50.0;
                    f3 = (double)YCbCr_Cr.Value / 50.0;
                    break;
            }

            for (int y = 0; y < tempImage.Height; y++)
            {
                for (int x = 0; x < tempImage.Width; x++)
                {
                    Color pixel = source.GetPixel(x, y);
                    Color newPixel = pixel;

                    switch (selectedSystem)
                    {
                        case "RGB":
                            {
                                int newR = Math.Max(0, Math.Min(255, (int)(pixel.R * f1)));
                                int newG = Math.Max(0, Math.Min(255, (int)(pixel.G * f2)));
                                int newB = Math.Max(0, Math.Min(255, (int)(pixel.B * f3)));
                                newPixel = Color.FromArgb(newR, newG, newB);
                                break;
                            }

                        case "CMYK":
                            {
                                // RGB -> CMYK
                                double r = pixel.R / 255.0;
                                double g = pixel.G / 255.0;
                                double b = pixel.B / 255.0;

                                double k = 1.0 - Math.Max(r, Math.Max(g, b));
                                double c = (k < 1.0) ? (1.0 - r - k) / (1.0 - k) : 0;
                                double m = (k < 1.0) ? (1.0 - g - k) / (1.0 - k) : 0;
                                double yC = (k < 1.0) ? (1.0 - b - k) / (1.0 - k) : 0;

                                c = Math.Max(0, Math.Min(1, c * f1));
                                m = Math.Max(0, Math.Min(1, m * f2));
                                yC = Math.Max(0, Math.Min(1, yC * f3));
                                k = Math.Max(0, Math.Min(1, k * f4));

                                // CMYK -> RGB
                                int newR = Math.Max(0, Math.Min(255, (int)(255 * (1 - c) * (1 - k))));
                                int newG = Math.Max(0, Math.Min(255, (int)(255 * (1 - m) * (1 - k))));
                                int newB = Math.Max(0, Math.Min(255, (int)(255 * (1 - yC) * (1 - k))));

                                newPixel = Color.FromArgb(newR, newG, newB);
                                break;
                            }

                        case "HSV":
                            {
                                double h, s, v;

                                RgbToHsv(pixel, out h, out s, out v);

                                h += (double)(HSV_H.Value - 50) * 3.6;

                                if (h < 0) h += 360;
                                if (h >= 360) h -= 360;
                                s += ((double)HSV_S.Value - 50.0) / 50.0;
                                v += ((double)HSV_V.Value - 50.0) / 50.0;

                                s = Math.Max(0, Math.Min(1, s));
                                v = Math.Max(0, Math.Min(1, v));

                                newPixel = HsvToRgb(h, s, v);

                                break;
                            }

                        case "YUV":
                            {
                                // RGB -> YUV
                                double Y = 0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B;
                                double U = -0.14713 * pixel.R - 0.28886 * pixel.G + 0.436 * pixel.B;
                                double V = 0.615 * pixel.R - 0.51499 * pixel.G - 0.10001 * pixel.B;

                                Y *= f1;
                                U *= f2;
                                V *= f3;

                                // YUV -> RGB
                                int r = Math.Max(0, Math.Min(255, (int)(Y + 1.13983 * V)));
                                int g = Math.Max(0, Math.Min(255, (int)(Y - 0.39465 * U - 0.58060 * V)));
                                int b = Math.Max(0, Math.Min(255, (int)(Y + 2.03211 * U)));

                                newPixel = Color.FromArgb(r, g, b);
                                break;
                            }

                        case "YCbCr":
                            {
                                // RGB -> YCbCr
                                double Y = 0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B;
                                double Cb = 128 - 0.168736 * pixel.R - 0.331264 * pixel.G + 0.5 * pixel.B;
                                double Cr = 128 + 0.5 * pixel.R - 0.418688 * pixel.G - 0.081312 * pixel.B;

                                // Y ضرب مباشر، Cb/Cr حول المنتصف 128
                                Y = Y * f1;
                                Cb = 128 + (Cb - 128) * f2;
                                Cr = 128 + (Cr - 128) * f3;

                                // YCbCr -> RGB
                                int r = Math.Max(0, Math.Min(255, (int)(Y + 1.402 * (Cr - 128))));
                                int g = Math.Max(0, Math.Min(255, (int)(Y - 0.344136 * (Cb - 128) - 0.714136 * (Cr - 128))));
                                int b = Math.Max(0, Math.Min(255, (int)(Y + 1.772 * (Cb - 128))));

                                newPixel = Color.FromArgb(r, g, b);
                                break;
                            }
                    }

                    tempImage.SetPixel(x, y, newPixel);
                }
            }
            image = tempImage;
            Scene.Image = tempImage;
        }
        private void RgbToHsv(Color color, out double h, out double s, out double v)
        {
            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            double delta = max - min;

            h = 0;

            if (delta != 0)
            {
                if (max == r)
                    h = 60 * (((g - b) / delta) % 6);

                else if (max == g)
                    h = 60 * (((b - r) / delta) + 2);

                else
                    h = 60 * (((r - g) / delta) + 4);
            }

            if (h < 0)
                h += 360;

            s = (max == 0) ? 0 : delta / max;

            v = max;
        }
        private void ApplyLAB()
        {
            double lFactor = (double)LAB_L.Value / 50.0;
            double aFactor = (double)LAB_A.Value / 50.0;
            double bFactor = (double)LAB_B.Value / 50.0;

            Mat inputMat = image.ToMat();
            Mat labMat = new Mat();
            CvInvoke.CvtColor(inputMat, labMat, ColorConversion.Bgr2Lab);

            Bitmap labBitmap = labMat.ToBitmap();
            Bitmap modifiedLab = new Bitmap(labBitmap.Width, labBitmap.Height);

            for (int y = 0; y < labBitmap.Height; y++)
            {
                for (int x = 0; x < labBitmap.Width; x++)
                {
                    Color pixel = labBitmap.GetPixel(x, y);

                    int L = Math.Max(0, Math.Min(255, (int)(pixel.R * lFactor)));
                    int A = Math.Max(0, Math.Min(255, (int)(pixel.G * aFactor)));
                    int B = Math.Max(0, Math.Min(255, (int)(pixel.B * bFactor)));

                    modifiedLab.SetPixel(x, y, Color.FromArgb(L, A, B));
                }
            }

            Mat modifiedMat = modifiedLab.ToMat();
            Mat resultMat = new Mat();
            CvInvoke.CvtColor(modifiedMat, resultMat, ColorConversion.Lab2Bgr);

            Scene.Image = resultMat.ToBitmap();
        }
        private Color HsvToRgb(double h, double s, double v)
        {
            double c = v * s;
            double x = c * (1 - Math.Abs((h / 60.0) % 2 - 1));
            double m = v - c;

            double r1 = 0, g1 = 0, b1 = 0;
            if (h < 60) { r1 = c; g1 = x; b1 = 0; }
            else if (h < 120) { r1 = x; g1 = c; b1 = 0; }
            else if (h < 180) { r1 = 0; g1 = c; b1 = x; }
            else if (h < 240) { r1 = 0; g1 = x; b1 = c; }
            else if (h < 300) { r1 = x; g1 = 0; b1 = c; }
            else { r1 = c; g1 = 0; b1 = x; }

            int r = Math.Max(0, Math.Min(255, (int)((r1 + m) * 255)));
            int g = Math.Max(0, Math.Min(255, (int)((g1 + m) * 255)));
            int b = Math.Max(0, Math.Min(255, (int)((b1 + m) * 255)));

            return Color.FromArgb(r, g, b);
        }


        private void comboBoxColorSystems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (image == null)
                return;

            string selectedSystem = comboBoxColorSystems.SelectedItem.ToString();

            switch (selectedSystem)
            {
                case "RGB":
                    ShowPanel(0);
                    break;

                case "CMYK":
                    ShowPanel(1);
                    break;

                case "HSV":
                    ShowPanel(2);
                    break;

                case "YUV":
                    ShowPanel(3);
                    break;

                case "LAB":
                    ShowPanel(4);
                    break;

                case "YCbCr":
                    ShowPanel(5);
                    break;
            }
            reset_value_sysColor();
        }

        //============================
        // 4 - 5 ) Color Systems 3D space 
        //============================
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap? src = originalImage != null ? (Bitmap)originalImage.Clone() : null;
            Form4 form = new Form4(src);
            form.Show();
        }
        //============================
        // 7)  Color Change Quantize
        //============================
        int colorCount = 0;
        private void color_count_ValueChanged(object sender, EventArgs e)
        {
            colorCount = (int)color_count.Value;
        }
       
        private void color_change_Click(object sender, EventArgs e)
        {
            if (image == null)
                return;

            image = originalImage.CloneCurrentFrame();
            colorCount= Math.Max(2, Math.Min(65536, colorCount));
            IQuantizer quantizer = OptimizedPaletteQuantizer.Wu(colorCount);
            image.Quantize(quantizer);
            Scene.Image = image;

            number_of_colors_7.Invalidate();
        }
        //============================
        // 8) Image Information
        //============================
        private void Image_information_8_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.White);

            if (image == null)
            {
                g.DrawString("No Image Loaded",
                             new Font("Arial", 12),
                             Brushes.Black,
                             new PointF(10, 10));
                return;
            }
            
            FileInfo fileInfo = new FileInfo(pathImage);

            string info =
                "Image Information\n\n" +
                "File Name: " + fileInfo.Name + "\n" +
                "File Path: " + fileInfo.FullName + "\n" +
                "File Size: " + (fileInfo.Length / 1024.0).ToString("0.00") + " KB\n" +
                "Width: " + image.Width + " px\n" +
                "Height: " + image.Height + " px\n" +
                "Resolution: " + image.HorizontalResolution + " x " +
                                  image.VerticalResolution + " DPI\n" +
                "Pixel Format: " + image.PixelFormat.ToString() + "\n" +
                "Raw Format: " + image.RawFormat.ToString();

            g.DrawString(info,
                         new Font("Consolas", 11),
                         Brushes.Black,
                         new RectangleF(10, 10,
                         Image_information_8.Width - 20,
                         Image_information_8.Height - 20));
        }

        //============================
        // 9) Clear Image 
        //============================
        private void resetImage_Click(object sender, EventArgs e)
        {
            reset_value_sysColor();
            /*image = originalImage;
            RGB.Image = Image.FromFile(openFileDialog1.FileName);*/
        }
        private void reset_value_sysColor(bool first=false)
        {
            if (!first)
            {
                image = (Bitmap)originalImage.Clone();
            }
            isResetting = true;  
            RGB_R.Value = 50; RGB_G.Value = 50; RGB_B.Value = 50;
            CMYK_C.Value = 50; CMYK_M.Value = 50; CMYK_Y.Value = 50; CMYK_K.Value = 50;
            HSV_H.Value = 50; HSV_S.Value = 50; HSV_V.Value = 50;
            YUV_Y.Value = 50; YUV_U.Value = 50; YUV_V.Value = 50;
            LAB_L.Value = 50; LAB_A.Value = 50; LAB_B.Value = 50;
            YCbCr_Y.Value = 50; YCbCr_Cb.Value = 50; YCbCr_Cr.Value = 50;

            Scene.Image = image;
            isResetting = false;
        }
        private void ShowPanel(int index)
        {
            for (int i = 0; i < colorSystemsPanel.Count; i++)
            {
                colorSystemsPanel[i].Visible = (i == index);
            }
        }
        //============================
        // 10) Save Image 
        //============================
        private void save_image_Click(object sender, EventArgs e)
        {
            if (Scene.Image == null)
            {
                MessageBox.Show("No image to save.");
                return;
            }

            saveFileDialog1.Filter =
                "Bitmap Image (*.bmp)|*.bmp|" +
                "JPEG Image (*.jpg)|*.jpg;*.jpeg|" +
                "PNG Image (*.png)|*.png|" +
                "GIF Image (*.gif)|*.gif|" +
                "Icon File (*.ico)|*.ico|" +
                "TIFF Image (*.tif)|*.tif;*.tiff|" +
                "All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                string extension = Path.GetExtension(filePath).ToLower();

                switch (extension)
                {
                    case ".bmp":
                        Scene.Image.Save(filePath,
                            System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case ".jpg":
                    case ".jpeg":
                        Scene.Image.Save(filePath,
                            System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case ".png":
                        Scene.Image.Save(filePath,
                            System.Drawing.Imaging.ImageFormat.Png);
                        break;

                    case ".gif":
                        Scene.Image.Save(filePath,
                            System.Drawing.Imaging.ImageFormat.Gif);
                        break;

                    case ".tif":
                    case ".tiff":
                        Scene.Image.Save(filePath,
                            System.Drawing.Imaging.ImageFormat.Tiff);
                        break;

                    case ".ico":
                        Scene.Image.Save(filePath,
                            System.Drawing.Imaging.ImageFormat.Icon);
                        break;

                    default:
                        MessageBox.Show("This format is not supported for saving.");
                        break;
                }

                MessageBox.Show("Image saved successfully.");
            }
        }

    }
}