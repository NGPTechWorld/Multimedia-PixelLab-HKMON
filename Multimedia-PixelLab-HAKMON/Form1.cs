namespace Multimedia_PixelLab_HAKMON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}