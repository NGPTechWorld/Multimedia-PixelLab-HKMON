namespace Multimedia_PixelLab_HAKMON
{
    partial class Form3
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.num3 = new System.Windows.Forms.NumericUpDown();
            this.num4 = new System.Windows.Forms.NumericUpDown();
            this.glControl1 = new OpenTK.GLControl();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.comboBox1.Location = new System.Drawing.Point(12, 536);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // num1
            // 
            this.num1.DecimalPlaces = 2;
            this.num1.Location = new System.Drawing.Point(206, 537);
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
            this.num2.Location = new System.Drawing.Point(440, 537);
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
            this.num3.Location = new System.Drawing.Point(641, 537);
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
            this.num4.Location = new System.Drawing.Point(825, 537);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(150, 27);
            this.num4.TabIndex = 8;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(3, 2);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(988, 514);
            this.glControl1.TabIndex = 1;
            this.glControl1.VSync = true;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load_1);
            this.glControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 591);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private ComboBox comboBox1;
        private NumericUpDown num1;
        private NumericUpDown num2;
        private NumericUpDown num3;
        private NumericUpDown num4;
        private OpenTK.GLControl glControl1;
    }
}