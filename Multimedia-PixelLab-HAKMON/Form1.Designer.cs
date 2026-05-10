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
            Panel space;
            YUV_Panel = new Panel();
            YUV_V_Label = new Label();
            YUV_U_Label = new Label();
            YUV_Y_Label = new Label();
            YUV_V = new NumericUpDown();
            YUV_U = new NumericUpDown();
            YUV_Y = new NumericUpDown();
            RGB = new PictureBox();
            openImage = new Button();
            openFileDialog1 = new OpenFileDialog();
            comboBoxColorSystems = new ComboBox();
            RGB_Panel = new Panel();
            RGB_B_label = new Label();
            RGB_G_label = new Label();
            RGB_R_label = new Label();
            RGB_B = new NumericUpDown();
            RGB_G = new NumericUpDown();
            RGB_R = new NumericUpDown();
            HSV_Panel = new Panel();
            Percent2 = new Label();
            Percent = new Label();
            HSV_V_Label = new Label();
            HSV_S_Label = new Label();
            HSV_H_Label = new Label();
            HSV_V = new NumericUpDown();
            HSV_S = new NumericUpDown();
            HSV_H = new NumericUpDown();
            space = new Panel();
            space.SuspendLayout();
            YUV_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YUV_V).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YUV_U).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YUV_Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RGB).BeginInit();
            RGB_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RGB_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RGB_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RGB_R).BeginInit();
            HSV_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HSV_V).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HSV_S).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HSV_H).BeginInit();
            SuspendLayout();
            // 
            // space
            // 
            space.AllowDrop = true;
            space.BackColor = Color.Gainsboro;
            space.Controls.Add(RGB);
            space.Location = new Point(-2, 54);
            space.Name = "space";
            space.Size = new Size(1107, 454);
            space.TabIndex = 0;
            // 
            // YUV_Panel
            // 
            YUV_Panel.Controls.Add(YUV_V_Label);
            YUV_Panel.Controls.Add(YUV_U_Label);
            YUV_Panel.Controls.Add(YUV_Y_Label);
            YUV_Panel.Controls.Add(YUV_V);
            YUV_Panel.Controls.Add(YUV_U);
            YUV_Panel.Controls.Add(YUV_Y);
            YUV_Panel.Location = new Point(192, 515);
            YUV_Panel.Name = "YUV_Panel";
            YUV_Panel.Size = new Size(801, 72);
            YUV_Panel.TabIndex = 4;
            // 
            // YUV_V_Label
            // 
            YUV_V_Label.AutoSize = true;
            YUV_V_Label.Location = new Point(542, 27);
            YUV_V_Label.Name = "YUV_V_Label";
            YUV_V_Label.Size = new Size(21, 20);
            YUV_V_Label.TabIndex = 6;
            YUV_V_Label.Text = "V:";
            // 
            // YUV_U_Label
            // 
            YUV_U_Label.AutoSize = true;
            YUV_U_Label.Location = new Point(302, 27);
            YUV_U_Label.Name = "YUV_U_Label";
            YUV_U_Label.Size = new Size(22, 20);
            YUV_U_Label.TabIndex = 5;
            YUV_U_Label.Text = "U:";
            // 
            // YUV_Y_Label
            // 
            YUV_Y_Label.AutoSize = true;
            YUV_Y_Label.Location = new Point(74, 25);
            YUV_Y_Label.Name = "YUV_Y_Label";
            YUV_Y_Label.Size = new Size(20, 20);
            YUV_Y_Label.TabIndex = 4;
            YUV_Y_Label.Text = "Y:";
            YUV_Y_Label.Click += label3_Click;
            // 
            // YUV_V
            // 
            YUV_V.Location = new Point(566, 23);
            YUV_V.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
            YUV_V.Minimum = new decimal(new int[] { 128, 0, 0, int.MinValue });
            YUV_V.Name = "YUV_V";
            YUV_V.Size = new Size(68, 27);
            YUV_V.TabIndex = 3;
            // 
            // YUV_U
            // 
            YUV_U.Location = new Point(325, 23);
            YUV_U.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
            YUV_U.Minimum = new decimal(new int[] { 128, 0, 0, int.MinValue });
            YUV_U.Name = "YUV_U";
            YUV_U.Size = new Size(68, 27);
            YUV_U.TabIndex = 2;
            // 
            // YUV_Y
            // 
            YUV_Y.Location = new Point(96, 22);
            YUV_Y.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            YUV_Y.Name = "YUV_Y";
            YUV_Y.Size = new Size(68, 27);
            YUV_Y.TabIndex = 1;
            // 
            // RGB
            // 
            RGB.Location = new Point(0, 3);
            RGB.Name = "RGB";
            RGB.Size = new Size(1104, 448);
            RGB.SizeMode = PictureBoxSizeMode.Zoom;
            RGB.TabIndex = 0;
            RGB.TabStop = false;
            RGB.DragDrop += pictureBox1_DragDrop_1;
            RGB.DragEnter += pictureBox1_DragEnter;
            // 
            // openImage
            // 
            openImage.Location = new Point(12, 12);
            openImage.Name = "openImage";
            openImage.Size = new Size(136, 29);
            openImage.TabIndex = 1;
            openImage.Text = "Open Image";
            openImage.UseVisualStyleBackColor = true;
            openImage.Click += openImage_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBoxColorSystems
            // 
            comboBoxColorSystems.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColorSystems.FormattingEnabled = true;
            comboBoxColorSystems.Items.AddRange(new object[] { "RGB", "CMYK", "HSV", "YUV", "LAB", "YCbCr" });
            comboBoxColorSystems.Location = new Point(28, 536);
            comboBoxColorSystems.Name = "comboBoxColorSystems";
            comboBoxColorSystems.Size = new Size(151, 28);
            comboBoxColorSystems.TabIndex = 2;
            comboBoxColorSystems.SelectedIndexChanged += comboBoxColorSystems_SelectedIndexChanged;
            // 
            // RGB_Panel
            // 
            RGB_Panel.Controls.Add(RGB_B_label);
            RGB_Panel.Controls.Add(RGB_G_label);
            RGB_Panel.Controls.Add(RGB_R_label);
            RGB_Panel.Controls.Add(RGB_B);
            RGB_Panel.Controls.Add(RGB_G);
            RGB_Panel.Controls.Add(RGB_R);
            RGB_Panel.Location = new Point(194, 514);
            RGB_Panel.Name = "RGB_Panel";
            RGB_Panel.Size = new Size(801, 72);
            RGB_Panel.TabIndex = 1;
            RGB_Panel.Visible = false;
            RGB_Panel.Paint += panel1_Paint;
            // 
            // RGB_B_label
            // 
            RGB_B_label.AutoSize = true;
            RGB_B_label.Location = new Point(542, 27);
            RGB_B_label.Name = "RGB_B_label";
            RGB_B_label.Size = new Size(21, 20);
            RGB_B_label.TabIndex = 6;
            RGB_B_label.Text = "B:";
            // 
            // RGB_G_label
            // 
            RGB_G_label.AutoSize = true;
            RGB_G_label.Location = new Point(302, 27);
            RGB_G_label.Name = "RGB_G_label";
            RGB_G_label.Size = new Size(22, 20);
            RGB_G_label.TabIndex = 5;
            RGB_G_label.Text = "G:";
            RGB_G_label.Click += RGB_G_label_Click;
            // 
            // RGB_R_label
            // 
            RGB_R_label.AutoSize = true;
            RGB_R_label.Location = new Point(74, 25);
            RGB_R_label.Name = "RGB_R_label";
            RGB_R_label.Size = new Size(21, 20);
            RGB_R_label.TabIndex = 4;
            RGB_R_label.Text = "R:";
            // 
            // RGB_B
            // 
            RGB_B.Location = new Point(566, 23);
            RGB_B.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            RGB_B.Name = "RGB_B";
            RGB_B.Size = new Size(68, 27);
            RGB_B.TabIndex = 3;
            // 
            // RGB_G
            // 
            RGB_G.Location = new Point(325, 23);
            RGB_G.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            RGB_G.Name = "RGB_G";
            RGB_G.Size = new Size(68, 27);
            RGB_G.TabIndex = 2;
            // 
            // RGB_R
            // 
            RGB_R.Location = new Point(96, 22);
            RGB_R.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            RGB_R.Name = "RGB_R";
            RGB_R.Size = new Size(68, 27);
            RGB_R.TabIndex = 1;
            // 
            // HSV_Panel
            // 
            HSV_Panel.Controls.Add(Percent2);
            HSV_Panel.Controls.Add(Percent);
            HSV_Panel.Controls.Add(HSV_V_Label);
            HSV_Panel.Controls.Add(HSV_S_Label);
            HSV_Panel.Controls.Add(HSV_H_Label);
            HSV_Panel.Controls.Add(HSV_V);
            HSV_Panel.Controls.Add(HSV_S);
            HSV_Panel.Controls.Add(HSV_H);
            HSV_Panel.Location = new Point(194, 514);
            HSV_Panel.Name = "HSV_Panel";
            HSV_Panel.Size = new Size(801, 72);
            HSV_Panel.TabIndex = 3;
            HSV_Panel.Paint += HSV_Panel_Paint;
            // 
            // Percent2
            // 
            Percent2.AutoSize = true;
            Percent2.Location = new Point(636, 27);
            Percent2.Name = "Percent2";
            Percent2.Size = new Size(21, 20);
            Percent2.TabIndex = 8;
            Percent2.Text = "%";
            Percent2.Visible = false;
            // 
            // Percent
            // 
            Percent.AutoSize = true;
            Percent.Location = new Point(393, 27);
            Percent.Name = "Percent";
            Percent.Size = new Size(21, 20);
            Percent.TabIndex = 7;
            Percent.Text = "%";
            // 
            // HSV_V_Label
            // 
            HSV_V_Label.AutoSize = true;
            HSV_V_Label.Location = new Point(542, 27);
            HSV_V_Label.Name = "HSV_V_Label";
            HSV_V_Label.Size = new Size(21, 20);
            HSV_V_Label.TabIndex = 6;
            HSV_V_Label.Text = "V:";
            // 
            // HSV_S_Label
            // 
            HSV_S_Label.AutoSize = true;
            HSV_S_Label.Location = new Point(302, 27);
            HSV_S_Label.Name = "HSV_S_Label";
            HSV_S_Label.Size = new Size(20, 20);
            HSV_S_Label.TabIndex = 5;
            HSV_S_Label.Text = "S:";
            // 
            // HSV_H_Label
            // 
            HSV_H_Label.AutoSize = true;
            HSV_H_Label.Location = new Point(74, 25);
            HSV_H_Label.Name = "HSV_H_Label";
            HSV_H_Label.Size = new Size(23, 20);
            HSV_H_Label.TabIndex = 4;
            HSV_H_Label.Text = "H:";
            // 
            // HSV_V
            // 
            HSV_V.Location = new Point(566, 23);
            HSV_V.Name = "HSV_V";
            HSV_V.Size = new Size(68, 27);
            HSV_V.TabIndex = 3;
            // 
            // HSV_S
            // 
            HSV_S.Location = new Point(325, 23);
            HSV_S.Name = "HSV_S";
            HSV_S.Size = new Size(68, 27);
            HSV_S.TabIndex = 2;
            HSV_S.ValueChanged += HSV_S_ValueChanged;
            // 
            // HSV_H
            // 
            HSV_H.Location = new Point(96, 22);
            HSV_H.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            HSV_H.Name = "HSV_H";
            HSV_H.Size = new Size(68, 27);
            HSV_H.TabIndex = 1;
            HSV_H.ValueChanged += HSV_H_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 591);
            Controls.Add(YUV_Panel);
            Controls.Add(RGB_Panel);
            Controls.Add(comboBoxColorSystems);
            Controls.Add(openImage);
            Controls.Add(space);
            Controls.Add(HSV_Panel);
            Name = "Form1";
            Text = "Form1";
            space.ResumeLayout(false);
            YUV_Panel.ResumeLayout(false);
            YUV_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YUV_V).EndInit();
            ((System.ComponentModel.ISupportInitialize)YUV_U).EndInit();
            ((System.ComponentModel.ISupportInitialize)YUV_Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)RGB).EndInit();
            RGB_Panel.ResumeLayout(false);
            RGB_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RGB_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)RGB_G).EndInit();
            ((System.ComponentModel.ISupportInitialize)RGB_R).EndInit();
            HSV_Panel.ResumeLayout(false);
            HSV_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HSV_V).EndInit();
            ((System.ComponentModel.ISupportInitialize)HSV_S).EndInit();
            ((System.ComponentModel.ISupportInitialize)HSV_H).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel space;
        private Button openImage;
        private OpenFileDialog openFileDialog1;
        private PictureBox RGB;
        private ComboBox comboBoxColorSystems;
        private Panel RGB_Panel;
        private NumericUpDown RGB_B;
        private NumericUpDown RGB_G;
        private NumericUpDown RGB_R;
        private Label RGB_G_label;
        private Label RGB_R_label;
        private Label RGB_B_label;
        private Panel HSV_Panel;
        private Label HSV_V_Label;
        private Label HSV_S_Label;
        private Label HSV_H_Label;
        private NumericUpDown HSV_V;
        private NumericUpDown HSV_S;
        private NumericUpDown HSV_H;
        private Label Percent2;
        private Label Percent;
        private Panel YUV_Panel;
        private Label YUV_V_Label;
        private Label YUV_U_Label;
        private Label YUV_Y_Label;
        private NumericUpDown YUV_V;
        private NumericUpDown YUV_U;
        private NumericUpDown YUV_Y;
    }
}