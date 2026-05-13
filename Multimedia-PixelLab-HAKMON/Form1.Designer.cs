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
            this.glControl1 = new OpenTK.GLControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.num3 = new System.Windows.Forms.NumericUpDown();
            this.num4 = new System.Windows.Forms.NumericUpDown();
            space = new System.Windows.Forms.Panel();
            space.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).BeginInit();
            this.SuspendLayout();
            // 
            // space
            // 
            space.AllowDrop = true;
            space.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            space.BackColor = System.Drawing.Color.Gainsboro;
            space.Controls.Add(this.glControl1);
            space.Controls.Add(this.pictureBox1);
            space.Location = new System.Drawing.Point(-2, 54);
            space.Name = "space";
            space.Size = new System.Drawing.Size(1619, 454);
            space.TabIndex = 0;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(1111, 3);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(504, 451);
            this.glControl1.TabIndex = 1;
            this.glControl1.VSync = true;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load_1);
            this.glControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseClick);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1109, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "ChangeColorSystem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RGB",
            "HSV",
            "CMYK",
            "YUV ",
            "LAB",
            "YCbCr"});
            this.comboBox1.Location = new System.Drawing.Point(649, 536);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // num1
            // 
            this.num1.DecimalPlaces = 2;
            this.num1.Location = new System.Drawing.Point(889, 536);
            this.num1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(150, 27);
            this.num1.TabIndex = 5;
            this.num1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // num2
            // 
            this.num2.DecimalPlaces = 2;
            this.num2.Location = new System.Drawing.Point(1086, 536);
            this.num2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(150, 27);
            this.num2.TabIndex = 6;
            // 
            // num3
            // 
            this.num3.DecimalPlaces = 2;
            this.num3.Location = new System.Drawing.Point(1273, 536);
            this.num3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(150, 27);
            this.num3.TabIndex = 7;
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(1457, 536);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(150, 27);
            this.num4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 591);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openImage);
            this.Controls.Add(space);
            this.Name = "Form1";
            this.Text = "Form1";
            space.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel space;
        private Button openImage;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private OpenTK.GLControl glControl1;
        private Button button1;
        private ComboBox comboBox1;
        private NumericUpDown num1;
        private NumericUpDown num2;
        private NumericUpDown num3;
        private NumericUpDown num4;
    }
}