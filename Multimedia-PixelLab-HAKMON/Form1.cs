using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Multimedia_PixelLab_HAKMON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            comboBoxColorSystems.SelectedIndex = 0;
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
            // √Œ– «·„·›« 
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // ⁄—÷ √Ê· ’Ê—…
            if (files.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(files[0]);
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            // «· √ﬂœ √‰ «·„·› ’Ê—…
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void comboBoxColorSystems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (image == null)
                return;

            string selectedSystem = comboBoxColorSystems.SelectedItem.ToString();

            Mat inputImage = image.ToMat();
            Mat outputImage = new Mat();

            switch (selectedSystem)
            {
                case "RGB":
                    pictureBox1.Image = image;
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

                case "CMYK":
                    ConvertToCMYK();
                    return;
            }

            pictureBox1.Image = outputImage.ToBitmap();
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

            pictureBox1.Image = cmykImage;
        }
    }
}