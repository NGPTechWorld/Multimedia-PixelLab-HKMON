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
            this.RGB = new System.Windows.Forms.PictureBox();
            this.YUV_Panel = new System.Windows.Forms.Panel();
            this.YUV_V_Label = new System.Windows.Forms.Label();
            this.YUV_U_Label = new System.Windows.Forms.Label();
            this.YUV_Y_Label = new System.Windows.Forms.Label();
            this.YUV_V = new System.Windows.Forms.NumericUpDown();
            this.YUV_U = new System.Windows.Forms.NumericUpDown();
            this.YUV_Y = new System.Windows.Forms.NumericUpDown();
            this.openImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxColorSystems = new System.Windows.Forms.ComboBox();
            this.RGB_Panel = new System.Windows.Forms.Panel();
            this.RGB_B_label = new System.Windows.Forms.Label();
            this.RGB_G_label = new System.Windows.Forms.Label();
            this.RGB_R_label = new System.Windows.Forms.Label();
            this.RGB_B = new System.Windows.Forms.NumericUpDown();
            this.RGB_G = new System.Windows.Forms.NumericUpDown();
            this.RGB_R = new System.Windows.Forms.NumericUpDown();
            this.HSV_Panel = new System.Windows.Forms.Panel();
            this.Percent2 = new System.Windows.Forms.Label();
            this.Percent = new System.Windows.Forms.Label();
            this.HSV_V_Label = new System.Windows.Forms.Label();
            this.HSV_S_Label = new System.Windows.Forms.Label();
            this.HSV_H_Label = new System.Windows.Forms.Label();
            this.HSV_V = new System.Windows.Forms.NumericUpDown();
            this.HSV_S = new System.Windows.Forms.NumericUpDown();
            this.HSV_H = new System.Windows.Forms.NumericUpDown();
            this.LAB_Panel = new System.Windows.Forms.Panel();
            this.LAB_B_Label = new System.Windows.Forms.Label();
            this.LAB_A_Label = new System.Windows.Forms.Label();
            this.LAB_L_Label = new System.Windows.Forms.Label();
            this.LAB_B = new System.Windows.Forms.NumericUpDown();
            this.LAB_A = new System.Windows.Forms.NumericUpDown();
            this.LAB_L = new System.Windows.Forms.NumericUpDown();
            this.YCbCr_Panel = new System.Windows.Forms.Panel();
            this.YCbCr_Cr_Label = new System.Windows.Forms.Label();
            this.YCbCr_Cb_Label = new System.Windows.Forms.Label();
            this.YCbCr_Y_Label = new System.Windows.Forms.Label();
            this.YCbCr_Cr = new System.Windows.Forms.NumericUpDown();
            this.YCbCr_Cb = new System.Windows.Forms.NumericUpDown();
            this.YCbCr_Y = new System.Windows.Forms.NumericUpDown();
            this.CMYK_Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMYK_K_Label = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.CMYK_Y_Label = new System.Windows.Forms.Label();
            this.CMYK_M_Label = new System.Windows.Forms.Label();
            this.CMYK_C_Label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            space = new System.Windows.Forms.Panel();
            space.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGB)).BeginInit();
            this.YUV_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YUV_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUV_U)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUV_Y)).BeginInit();
            this.RGB_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGB_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB_R)).BeginInit();
            this.HSV_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HSV_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSV_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSV_H)).BeginInit();
            this.LAB_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LAB_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAB_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAB_L)).BeginInit();
            this.YCbCr_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YCbCr_Cr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCbCr_Cb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCbCr_Y)).BeginInit();
            this.CMYK_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // space
            // 
            space.AllowDrop = true;
            space.BackColor = System.Drawing.Color.Gainsboro;
            space.Controls.Add(this.RGB);
            space.Location = new System.Drawing.Point(-2, 54);
            space.Name = "space";
            space.Size = new System.Drawing.Size(1107, 454);
            space.TabIndex = 0;
            // 
            // RGB
            // 
            this.RGB.Location = new System.Drawing.Point(0, 3);
            this.RGB.Name = "RGB";
            this.RGB.Size = new System.Drawing.Size(1104, 448);
            this.RGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RGB.TabIndex = 0;
            this.RGB.TabStop = false;
            // 
            // YUV_Panel
            // 
            this.YUV_Panel.Controls.Add(this.YUV_V_Label);
            this.YUV_Panel.Controls.Add(this.YUV_U_Label);
            this.YUV_Panel.Controls.Add(this.YUV_Y_Label);
            this.YUV_Panel.Controls.Add(this.YUV_V);
            this.YUV_Panel.Controls.Add(this.YUV_U);
            this.YUV_Panel.Controls.Add(this.YUV_Y);
            this.YUV_Panel.Location = new System.Drawing.Point(192, 515);
            this.YUV_Panel.Name = "YUV_Panel";
            this.YUV_Panel.Size = new System.Drawing.Size(801, 72);
            this.YUV_Panel.TabIndex = 4;
            this.YUV_Panel.Visible = false;
            // 
            // YUV_V_Label
            // 
            this.YUV_V_Label.AutoSize = true;
            this.YUV_V_Label.Location = new System.Drawing.Point(542, 27);
            this.YUV_V_Label.Name = "YUV_V_Label";
            this.YUV_V_Label.Size = new System.Drawing.Size(21, 20);
            this.YUV_V_Label.TabIndex = 6;
            this.YUV_V_Label.Text = "V:";
            // 
            // YUV_U_Label
            // 
            this.YUV_U_Label.AutoSize = true;
            this.YUV_U_Label.Location = new System.Drawing.Point(302, 27);
            this.YUV_U_Label.Name = "YUV_U_Label";
            this.YUV_U_Label.Size = new System.Drawing.Size(22, 20);
            this.YUV_U_Label.TabIndex = 5;
            this.YUV_U_Label.Text = "U:";
            // 
            // YUV_Y_Label
            // 
            this.YUV_Y_Label.AutoSize = true;
            this.YUV_Y_Label.Location = new System.Drawing.Point(74, 25);
            this.YUV_Y_Label.Name = "YUV_Y_Label";
            this.YUV_Y_Label.Size = new System.Drawing.Size(20, 20);
            this.YUV_Y_Label.TabIndex = 4;
            this.YUV_Y_Label.Text = "Y:";
            // 
            // YUV_V
            // 
            this.YUV_V.Location = new System.Drawing.Point(566, 23);
            this.YUV_V.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.YUV_V.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.YUV_V.Name = "YUV_V";
            this.YUV_V.Size = new System.Drawing.Size(68, 27);
            this.YUV_V.TabIndex = 3;
            // 
            // YUV_U
            // 
            this.YUV_U.Location = new System.Drawing.Point(325, 23);
            this.YUV_U.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.YUV_U.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.YUV_U.Name = "YUV_U";
            this.YUV_U.Size = new System.Drawing.Size(68, 27);
            this.YUV_U.TabIndex = 2;
            // 
            // YUV_Y
            // 
            this.YUV_Y.Location = new System.Drawing.Point(96, 22);
            this.YUV_Y.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.YUV_Y.Name = "YUV_Y";
            this.YUV_Y.Size = new System.Drawing.Size(68, 27);
            this.YUV_Y.TabIndex = 1;
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
            // comboBoxColorSystems
            // 
            this.comboBoxColorSystems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColorSystems.FormattingEnabled = true;
            this.comboBoxColorSystems.Items.AddRange(new object[] {
            "RGB",
            "CMYK",
            "HSV",
            "YUV",
            "LAB",
            "YCbCr"});
            this.comboBoxColorSystems.Location = new System.Drawing.Point(28, 536);
            this.comboBoxColorSystems.Name = "comboBoxColorSystems";
            this.comboBoxColorSystems.Size = new System.Drawing.Size(151, 28);
            this.comboBoxColorSystems.TabIndex = 2;
            this.comboBoxColorSystems.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorSystems_SelectedIndexChanged);
            // 
            // RGB_Panel
            // 
            this.RGB_Panel.Controls.Add(this.RGB_B_label);
            this.RGB_Panel.Controls.Add(this.RGB_G_label);
            this.RGB_Panel.Controls.Add(this.RGB_R_label);
            this.RGB_Panel.Controls.Add(this.RGB_B);
            this.RGB_Panel.Controls.Add(this.RGB_G);
            this.RGB_Panel.Controls.Add(this.RGB_R);
            this.RGB_Panel.Location = new System.Drawing.Point(194, 514);
            this.RGB_Panel.Name = "RGB_Panel";
            this.RGB_Panel.Size = new System.Drawing.Size(801, 72);
            this.RGB_Panel.TabIndex = 1;
            this.RGB_Panel.Visible = false;
            // 
            // RGB_B_label
            // 
            this.RGB_B_label.AutoSize = true;
            this.RGB_B_label.Location = new System.Drawing.Point(542, 27);
            this.RGB_B_label.Name = "RGB_B_label";
            this.RGB_B_label.Size = new System.Drawing.Size(21, 20);
            this.RGB_B_label.TabIndex = 6;
            this.RGB_B_label.Text = "B:";
            // 
            // RGB_G_label
            // 
            this.RGB_G_label.AutoSize = true;
            this.RGB_G_label.Location = new System.Drawing.Point(302, 27);
            this.RGB_G_label.Name = "RGB_G_label";
            this.RGB_G_label.Size = new System.Drawing.Size(22, 20);
            this.RGB_G_label.TabIndex = 5;
            this.RGB_G_label.Text = "G:";
            // 
            // RGB_R_label
            // 
            this.RGB_R_label.AutoSize = true;
            this.RGB_R_label.Location = new System.Drawing.Point(74, 25);
            this.RGB_R_label.Name = "RGB_R_label";
            this.RGB_R_label.Size = new System.Drawing.Size(21, 20);
            this.RGB_R_label.TabIndex = 4;
            this.RGB_R_label.Text = "R:";
            // 
            // RGB_B
            // 
            this.RGB_B.Location = new System.Drawing.Point(566, 23);
            this.RGB_B.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RGB_B.Name = "RGB_B";
            this.RGB_B.Size = new System.Drawing.Size(68, 27);
            this.RGB_B.TabIndex = 3;
            // 
            // RGB_G
            // 
            this.RGB_G.Location = new System.Drawing.Point(325, 23);
            this.RGB_G.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RGB_G.Name = "RGB_G";
            this.RGB_G.Size = new System.Drawing.Size(68, 27);
            this.RGB_G.TabIndex = 2;
            // 
            // RGB_R
            // 
            this.RGB_R.Location = new System.Drawing.Point(96, 22);
            this.RGB_R.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RGB_R.Name = "RGB_R";
            this.RGB_R.Size = new System.Drawing.Size(68, 27);
            this.RGB_R.TabIndex = 1;
            // 
            // HSV_Panel
            // 
            this.HSV_Panel.Controls.Add(this.Percent2);
            this.HSV_Panel.Controls.Add(this.Percent);
            this.HSV_Panel.Controls.Add(this.HSV_V_Label);
            this.HSV_Panel.Controls.Add(this.HSV_S_Label);
            this.HSV_Panel.Controls.Add(this.HSV_H_Label);
            this.HSV_Panel.Controls.Add(this.HSV_V);
            this.HSV_Panel.Controls.Add(this.HSV_S);
            this.HSV_Panel.Controls.Add(this.HSV_H);
            this.HSV_Panel.Location = new System.Drawing.Point(194, 514);
            this.HSV_Panel.Name = "HSV_Panel";
            this.HSV_Panel.Size = new System.Drawing.Size(801, 72);
            this.HSV_Panel.TabIndex = 3;
            // 
            // Percent2
            // 
            this.Percent2.AutoSize = true;
            this.Percent2.Location = new System.Drawing.Point(636, 27);
            this.Percent2.Name = "Percent2";
            this.Percent2.Size = new System.Drawing.Size(21, 20);
            this.Percent2.TabIndex = 8;
            this.Percent2.Text = "%";
            this.Percent2.Visible = false;
            // 
            // Percent
            // 
            this.Percent.AutoSize = true;
            this.Percent.Location = new System.Drawing.Point(393, 27);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(21, 20);
            this.Percent.TabIndex = 7;
            this.Percent.Text = "%";
            // 
            // HSV_V_Label
            // 
            this.HSV_V_Label.AutoSize = true;
            this.HSV_V_Label.Location = new System.Drawing.Point(542, 27);
            this.HSV_V_Label.Name = "HSV_V_Label";
            this.HSV_V_Label.Size = new System.Drawing.Size(21, 20);
            this.HSV_V_Label.TabIndex = 6;
            this.HSV_V_Label.Text = "V:";
            // 
            // HSV_S_Label
            // 
            this.HSV_S_Label.AutoSize = true;
            this.HSV_S_Label.Location = new System.Drawing.Point(302, 27);
            this.HSV_S_Label.Name = "HSV_S_Label";
            this.HSV_S_Label.Size = new System.Drawing.Size(20, 20);
            this.HSV_S_Label.TabIndex = 5;
            this.HSV_S_Label.Text = "S:";
            // 
            // HSV_H_Label
            // 
            this.HSV_H_Label.AutoSize = true;
            this.HSV_H_Label.Location = new System.Drawing.Point(74, 25);
            this.HSV_H_Label.Name = "HSV_H_Label";
            this.HSV_H_Label.Size = new System.Drawing.Size(23, 20);
            this.HSV_H_Label.TabIndex = 4;
            this.HSV_H_Label.Text = "H:";
            // 
            // HSV_V
            // 
            this.HSV_V.Location = new System.Drawing.Point(566, 23);
            this.HSV_V.Name = "HSV_V";
            this.HSV_V.Size = new System.Drawing.Size(68, 27);
            this.HSV_V.TabIndex = 3;
            // 
            // HSV_S
            // 
            this.HSV_S.Location = new System.Drawing.Point(325, 23);
            this.HSV_S.Name = "HSV_S";
            this.HSV_S.Size = new System.Drawing.Size(68, 27);
            this.HSV_S.TabIndex = 2;
            // 
            // HSV_H
            // 
            this.HSV_H.Location = new System.Drawing.Point(96, 22);
            this.HSV_H.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.HSV_H.Name = "HSV_H";
            this.HSV_H.Size = new System.Drawing.Size(68, 27);
            this.HSV_H.TabIndex = 1;
            // 
            // LAB_Panel
            // 
            this.LAB_Panel.Controls.Add(this.LAB_B_Label);
            this.LAB_Panel.Controls.Add(this.LAB_A_Label);
            this.LAB_Panel.Controls.Add(this.LAB_L_Label);
            this.LAB_Panel.Controls.Add(this.LAB_B);
            this.LAB_Panel.Controls.Add(this.LAB_A);
            this.LAB_Panel.Controls.Add(this.LAB_L);
            this.LAB_Panel.Location = new System.Drawing.Point(192, 514);
            this.LAB_Panel.Name = "LAB_Panel";
            this.LAB_Panel.Size = new System.Drawing.Size(801, 72);
            this.LAB_Panel.TabIndex = 5;
            // 
            // LAB_B_Label
            // 
            this.LAB_B_Label.AutoSize = true;
            this.LAB_B_Label.Location = new System.Drawing.Point(542, 27);
            this.LAB_B_Label.Name = "LAB_B_Label";
            this.LAB_B_Label.Size = new System.Drawing.Size(21, 20);
            this.LAB_B_Label.TabIndex = 6;
            this.LAB_B_Label.Text = "B:";
            // 
            // LAB_A_Label
            // 
            this.LAB_A_Label.AutoSize = true;
            this.LAB_A_Label.Location = new System.Drawing.Point(302, 27);
            this.LAB_A_Label.Name = "LAB_A_Label";
            this.LAB_A_Label.Size = new System.Drawing.Size(22, 20);
            this.LAB_A_Label.TabIndex = 5;
            this.LAB_A_Label.Text = "A:";
            // 
            // LAB_L_Label
            // 
            this.LAB_L_Label.AutoSize = true;
            this.LAB_L_Label.Location = new System.Drawing.Point(74, 25);
            this.LAB_L_Label.Name = "LAB_L_Label";
            this.LAB_L_Label.Size = new System.Drawing.Size(19, 20);
            this.LAB_L_Label.TabIndex = 4;
            this.LAB_L_Label.Text = "L:";
            // 
            // LAB_B
            // 
            this.LAB_B.Location = new System.Drawing.Point(566, 23);
            this.LAB_B.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.LAB_B.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.LAB_B.Name = "LAB_B";
            this.LAB_B.Size = new System.Drawing.Size(68, 27);
            this.LAB_B.TabIndex = 3;
            // 
            // LAB_A
            // 
            this.LAB_A.Location = new System.Drawing.Point(325, 23);
            this.LAB_A.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.LAB_A.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.LAB_A.Name = "LAB_A";
            this.LAB_A.Size = new System.Drawing.Size(68, 27);
            this.LAB_A.TabIndex = 2;
            // 
            // LAB_L
            // 
            this.LAB_L.Location = new System.Drawing.Point(96, 22);
            this.LAB_L.Name = "LAB_L";
            this.LAB_L.Size = new System.Drawing.Size(68, 27);
            this.LAB_L.TabIndex = 1;
            // 
            // YCbCr_Panel
            // 
            this.YCbCr_Panel.Controls.Add(this.YCbCr_Cr_Label);
            this.YCbCr_Panel.Controls.Add(this.YCbCr_Cb_Label);
            this.YCbCr_Panel.Controls.Add(this.YCbCr_Y_Label);
            this.YCbCr_Panel.Controls.Add(this.YCbCr_Cr);
            this.YCbCr_Panel.Controls.Add(this.YCbCr_Cb);
            this.YCbCr_Panel.Controls.Add(this.YCbCr_Y);
            this.YCbCr_Panel.Location = new System.Drawing.Point(189, 514);
            this.YCbCr_Panel.Name = "YCbCr_Panel";
            this.YCbCr_Panel.Size = new System.Drawing.Size(801, 72);
            this.YCbCr_Panel.TabIndex = 6;
            // 
            // YCbCr_Cr_Label
            // 
            this.YCbCr_Cr_Label.AutoSize = true;
            this.YCbCr_Cr_Label.Location = new System.Drawing.Point(538, 27);
            this.YCbCr_Cr_Label.Name = "YCbCr_Cr_Label";
            this.YCbCr_Cr_Label.Size = new System.Drawing.Size(26, 20);
            this.YCbCr_Cr_Label.TabIndex = 6;
            this.YCbCr_Cr_Label.Text = "Cr:";
            // 
            // YCbCr_Cb_Label
            // 
            this.YCbCr_Cb_Label.AutoSize = true;
            this.YCbCr_Cb_Label.Location = new System.Drawing.Point(295, 27);
            this.YCbCr_Cb_Label.Name = "YCbCr_Cb_Label";
            this.YCbCr_Cb_Label.Size = new System.Drawing.Size(30, 20);
            this.YCbCr_Cb_Label.TabIndex = 5;
            this.YCbCr_Cb_Label.Text = "Cb:";
            // 
            // YCbCr_Y_Label
            // 
            this.YCbCr_Y_Label.AutoSize = true;
            this.YCbCr_Y_Label.Location = new System.Drawing.Point(74, 25);
            this.YCbCr_Y_Label.Name = "YCbCr_Y_Label";
            this.YCbCr_Y_Label.Size = new System.Drawing.Size(20, 20);
            this.YCbCr_Y_Label.TabIndex = 4;
            this.YCbCr_Y_Label.Text = "Y:";
            // 
            // YCbCr_Cr
            // 
            this.YCbCr_Cr.Location = new System.Drawing.Point(566, 23);
            this.YCbCr_Cr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.YCbCr_Cr.Name = "YCbCr_Cr";
            this.YCbCr_Cr.Size = new System.Drawing.Size(68, 27);
            this.YCbCr_Cr.TabIndex = 3;
            // 
            // YCbCr_Cb
            // 
            this.YCbCr_Cb.Location = new System.Drawing.Point(325, 23);
            this.YCbCr_Cb.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.YCbCr_Cb.Name = "YCbCr_Cb";
            this.YCbCr_Cb.Size = new System.Drawing.Size(68, 27);
            this.YCbCr_Cb.TabIndex = 2;
            // 
            // YCbCr_Y
            // 
            this.YCbCr_Y.Location = new System.Drawing.Point(96, 22);
            this.YCbCr_Y.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.YCbCr_Y.Name = "YCbCr_Y";
            this.YCbCr_Y.Size = new System.Drawing.Size(68, 27);
            this.YCbCr_Y.TabIndex = 1;
            // 
            // CMYK_Panel
            // 
            this.CMYK_Panel.Controls.Add(this.label4);
            this.CMYK_Panel.Controls.Add(this.label3);
            this.CMYK_Panel.Controls.Add(this.label2);
            this.CMYK_Panel.Controls.Add(this.label1);
            this.CMYK_Panel.Controls.Add(this.CMYK_K_Label);
            this.CMYK_Panel.Controls.Add(this.numericUpDown4);
            this.CMYK_Panel.Controls.Add(this.CMYK_Y_Label);
            this.CMYK_Panel.Controls.Add(this.CMYK_M_Label);
            this.CMYK_Panel.Controls.Add(this.CMYK_C_Label);
            this.CMYK_Panel.Controls.Add(this.numericUpDown1);
            this.CMYK_Panel.Controls.Add(this.numericUpDown2);
            this.CMYK_Panel.Controls.Add(this.numericUpDown3);
            this.CMYK_Panel.Location = new System.Drawing.Point(185, 515);
            this.CMYK_Panel.Name = "CMYK_Panel";
            this.CMYK_Panel.Size = new System.Drawing.Size(801, 72);
            this.CMYK_Panel.TabIndex = 7;
            this.CMYK_Panel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "%";
            // 
            // CMYK_K_Label
            // 
            this.CMYK_K_Label.AutoSize = true;
            this.CMYK_K_Label.Location = new System.Drawing.Point(621, 27);
            this.CMYK_K_Label.Name = "CMYK_K_Label";
            this.CMYK_K_Label.Size = new System.Drawing.Size(21, 20);
            this.CMYK_K_Label.TabIndex = 8;
            this.CMYK_K_Label.Text = "K:";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(645, 23);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(68, 27);
            this.numericUpDown4.TabIndex = 7;
            // 
            // CMYK_Y_Label
            // 
            this.CMYK_Y_Label.AutoSize = true;
            this.CMYK_Y_Label.Location = new System.Drawing.Point(436, 27);
            this.CMYK_Y_Label.Name = "CMYK_Y_Label";
            this.CMYK_Y_Label.Size = new System.Drawing.Size(20, 20);
            this.CMYK_Y_Label.TabIndex = 6;
            this.CMYK_Y_Label.Text = "Y:";
            // 
            // CMYK_M_Label
            // 
            this.CMYK_M_Label.AutoSize = true;
            this.CMYK_M_Label.Location = new System.Drawing.Point(241, 27);
            this.CMYK_M_Label.Name = "CMYK_M_Label";
            this.CMYK_M_Label.Size = new System.Drawing.Size(25, 20);
            this.CMYK_M_Label.TabIndex = 5;
            this.CMYK_M_Label.Text = "M:";
            // 
            // CMYK_C_Label
            // 
            this.CMYK_C_Label.AutoSize = true;
            this.CMYK_C_Label.Location = new System.Drawing.Point(74, 25);
            this.CMYK_C_Label.Name = "CMYK_C_Label";
            this.CMYK_C_Label.Size = new System.Drawing.Size(21, 20);
            this.CMYK_C_Label.TabIndex = 4;
            this.CMYK_C_Label.Text = "C:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(459, 23);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 27);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(269, 23);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(68, 27);
            this.numericUpDown2.TabIndex = 2;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(96, 22);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(68, 27);
            this.numericUpDown3.TabIndex = 1;
            this.numericUpDown3.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 591);
            this.Controls.Add(this.CMYK_Panel);
            this.Controls.Add(this.LAB_Panel);
            this.Controls.Add(this.YUV_Panel);
            this.Controls.Add(this.RGB_Panel);
            this.Controls.Add(this.comboBoxColorSystems);
            this.Controls.Add(this.openImage);
            this.Controls.Add(space);
            this.Controls.Add(this.YCbCr_Panel);
            this.Controls.Add(this.HSV_Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            space.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGB)).EndInit();
            this.YUV_Panel.ResumeLayout(false);
            this.YUV_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YUV_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUV_U)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUV_Y)).EndInit();
            this.RGB_Panel.ResumeLayout(false);
            this.RGB_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGB_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB_R)).EndInit();
            this.HSV_Panel.ResumeLayout(false);
            this.HSV_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HSV_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSV_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSV_H)).EndInit();
            this.LAB_Panel.ResumeLayout(false);
            this.LAB_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LAB_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAB_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAB_L)).EndInit();
            this.YCbCr_Panel.ResumeLayout(false);
            this.YCbCr_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YCbCr_Cr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCbCr_Cb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCbCr_Y)).EndInit();
            this.CMYK_Panel.ResumeLayout(false);
            this.CMYK_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

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
        private Panel LAB_Panel;
        private Label LAB_B_Label;
        private Label LAB_A_Label;
        private Label LAB_L_Label;
        private NumericUpDown LAB_B;
        private NumericUpDown LAB_A;
        private NumericUpDown LAB_L;
        private Panel YCbCr_Panel;
        private Label YCbCr_Cr_Label;
        private Label YCbCr_Cb_Label;
        private Label YCbCr_Y_Label;
        private NumericUpDown YCbCr_Cr;
        private NumericUpDown YCbCr_Cb;
        private NumericUpDown YCbCr_Y;
        private Panel CMYK_Panel;
        private Label CMYK_K_Label;
        private NumericUpDown numericUpDown4;
        private Label CMYK_Y_Label;
        private Label CMYK_M_Label;
        private Label CMYK_C_Label;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}