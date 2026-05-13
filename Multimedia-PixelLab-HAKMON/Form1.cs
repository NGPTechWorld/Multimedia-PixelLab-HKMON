using KGySoft.Drawing.Imaging;
using KGySoft.Drawing;

namespace Multimedia_PixelLab_HAKMON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
        }
        Bitmap image, originalImage;
        int colorCount = 0;
        private void openImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                originalImage = new Bitmap(openFileDialog1.FileName);
                image = originalImage.CloneCurrentFrame();
                Image_information_8.Invalidate();
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

            FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);

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

        private void number_of_colors_7_Paint(object sender, PaintEventArgs e) { }

        private void color_count_ValueChanged(object sender, EventArgs e)
        {
            colorCount = (int)color_count.Value;
        }

        private void save_image_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
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
                        pictureBox1.Image.Save(filePath,
                            System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case ".jpg":
                    case ".jpeg":
                        pictureBox1.Image.Save(filePath,
                            System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case ".png":
                        pictureBox1.Image.Save(filePath,
                            System.Drawing.Imaging.ImageFormat.Png);
                        break;

                    case ".gif":
                        pictureBox1.Image.Save(filePath,
                            System.Drawing.Imaging.ImageFormat.Gif);
                        break;

                    case ".tif":
                    case ".tiff":
                        pictureBox1.Image.Save(filePath,
                            System.Drawing.Imaging.ImageFormat.Tiff);
                        break;

                    case ".ico":
                        pictureBox1.Image.Save(filePath,
                            System.Drawing.Imaging.ImageFormat.Icon);
                        break;

                    default:
                        MessageBox.Show("This format is not supported for saving.");
                        break;
                }

                MessageBox.Show("Image saved successfully.");
            }
        }

        private void color_change_Click(object sender, EventArgs e)
        {
            if (image == null)
                return;

            image = originalImage.CloneCurrentFrame();
            IQuantizer quantizer = OptimizedPaletteQuantizer.Wu(colorCount);
            image.Quantize(quantizer);
            pictureBox1.Image = image;

            number_of_colors_7.Invalidate();
        }
    }
}