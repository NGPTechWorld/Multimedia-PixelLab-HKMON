namespace Multimedia_PixelLab_HAKMON
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel space;
            this.Image_information_8 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.number_of_colors_7 = new System.Windows.Forms.Panel();
            this.color_count = new System.Windows.Forms.NumericUpDown();
            this.color_change = new System.Windows.Forms.Button();
            space = new System.Windows.Forms.Panel();
            space.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.number_of_colors_7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_count)).BeginInit();
            this.SuspendLayout();
            // 
            // space
            // 
            space.AllowDrop = true;
            space.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            space.BackColor = System.Drawing.Color.Gainsboro;
            space.Controls.Add(this.Image_information_8);
            space.Controls.Add(this.pictureBox1);
            space.Location = new System.Drawing.Point(-2, 54);
            space.Name = "space";
            space.Size = new System.Drawing.Size(1107, 454);
            space.TabIndex = 0;
            // 
            // Image_information_8
            // 
            this.Image_information_8.Location = new System.Drawing.Point(783, 3);
            this.Image_information_8.Name = "Image_information_8";
            this.Image_information_8.Size = new System.Drawing.Size(321, 451);
            this.Image_information_8.TabIndex = 1;
            this.Image_information_8.Paint += new System.Windows.Forms.PaintEventHandler(this.Image_information_8_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1104, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop_1);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // openImage
            // 
            this.openImage.Location = new System.Drawing.Point(12, 12);
            this.openImage.Name = "openImage";
            this.openImage.Size = new System.Drawing.Size(136, 29);
            this.openImage.TabIndex = 1;
            this.openImage.Text = "Open Image";
            this.openImage.UseVisualStyleBackColor = true;
            this.openImage.Click += new System.EventHandler(this.openImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // number_of_colors_7
            // 
            this.number_of_colors_7.Controls.Add(this.color_count);
            this.number_of_colors_7.Controls.Add(this.color_change);
            this.number_of_colors_7.Location = new System.Drawing.Point(781, -3);
            this.number_of_colors_7.Name = "number_of_colors_7";
            this.number_of_colors_7.Size = new System.Drawing.Size(308, 54);
            this.number_of_colors_7.TabIndex = 2;
            this.number_of_colors_7.Paint += new System.Windows.Forms.PaintEventHandler(this.number_of_colors_7_Paint);
            // 
            // color_count
            // 
            this.color_count.Location = new System.Drawing.Point(132, 15);
            this.color_count.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.color_count.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.color_count.Name = "color_count";
            this.color_count.Size = new System.Drawing.Size(64, 27);
            this.color_count.TabIndex = 4;
            this.color_count.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.color_count.ValueChanged += new System.EventHandler(this.color_count_ValueChanged);
            // 
            // color_change
            // 
            this.color_change.Location = new System.Drawing.Point(13, 15);
            this.color_change.Name = "color_change";
            this.color_change.Size = new System.Drawing.Size(97, 29);
            this.color_change.TabIndex = 3;
            this.color_change.Text = "Change";
            this.color_change.UseVisualStyleBackColor = true;
            this.color_change.Click += new System.EventHandler(this.color_change_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 591);
            this.Controls.Add(this.number_of_colors_7);
            this.Controls.Add(this.openImage);
            this.Controls.Add(space);
            this.Name = "Form1";
            this.Text = "Form1";
            space.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.number_of_colors_7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel space;
        private Button openImage;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Panel Image_information_8;
        private Panel number_of_colors_7;
        private NumericUpDown color_count;
        private Button color_change;
    }
}