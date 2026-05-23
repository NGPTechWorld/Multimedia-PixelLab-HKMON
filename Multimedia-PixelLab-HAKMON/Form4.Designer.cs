namespace Multimedia_PixelLab_HAKMON
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.glControl1 = new OpenTK.GLControl();
            this.btnResetView = new System.Windows.Forms.Button();
            this.chkShowImageInSpace = new System.Windows.Forms.CheckBox();
            this.chkShowShape = new System.Windows.Forms.CheckBox();
            this.lblColorSystem = new System.Windows.Forms.Label();
            this.lblSelectedTitle = new System.Windows.Forms.Label();
            this.panelColorPreview = new System.Windows.Forms.Panel();
            this.lblHex = new System.Windows.Forms.Label();
            this.grpRGB = new System.Windows.Forms.GroupBox();
            this.lblRGB_R = new System.Windows.Forms.Label();
            this.txtRGB_R = new System.Windows.Forms.TextBox();
            this.lblRGB_G = new System.Windows.Forms.Label();
            this.txtRGB_G = new System.Windows.Forms.TextBox();
            this.lblRGB_B = new System.Windows.Forms.Label();
            this.txtRGB_B = new System.Windows.Forms.TextBox();
            this.grpCMYK = new System.Windows.Forms.GroupBox();
            this.lblCMYK_C = new System.Windows.Forms.Label();
            this.txtCMYK_C = new System.Windows.Forms.TextBox();
            this.lblCMYK_M = new System.Windows.Forms.Label();
            this.txtCMYK_M = new System.Windows.Forms.TextBox();
            this.lblCMYK_Y = new System.Windows.Forms.Label();
            this.txtCMYK_Y = new System.Windows.Forms.TextBox();
            this.lblCMYK_K = new System.Windows.Forms.Label();
            this.txtCMYK_K = new System.Windows.Forms.TextBox();
            this.grpHSV = new System.Windows.Forms.GroupBox();
            this.lblHSV_H = new System.Windows.Forms.Label();
            this.txtHSV_H = new System.Windows.Forms.TextBox();
            this.lblHSV_S = new System.Windows.Forms.Label();
            this.txtHSV_S = new System.Windows.Forms.TextBox();
            this.lblHSV_V = new System.Windows.Forms.Label();
            this.txtHSV_V = new System.Windows.Forms.TextBox();
            this.grpYUV = new System.Windows.Forms.GroupBox();
            this.lblYUV_Y = new System.Windows.Forms.Label();
            this.txtYUV_Y = new System.Windows.Forms.TextBox();
            this.lblYUV_U = new System.Windows.Forms.Label();
            this.txtYUV_U = new System.Windows.Forms.TextBox();
            this.lblYUV_V = new System.Windows.Forms.Label();
            this.txtYUV_V = new System.Windows.Forms.TextBox();
            this.grpLAB = new System.Windows.Forms.GroupBox();
            this.lblLAB_L = new System.Windows.Forms.Label();
            this.txtLAB_L = new System.Windows.Forms.TextBox();
            this.lblLAB_A = new System.Windows.Forms.Label();
            this.txtLAB_A = new System.Windows.Forms.TextBox();
            this.lblLAB_B = new System.Windows.Forms.Label();
            this.txtLAB_B = new System.Windows.Forms.TextBox();
            this.grpYCbCr = new System.Windows.Forms.GroupBox();
            this.lblYCbCr_Y = new System.Windows.Forms.Label();
            this.txtYCbCr_Y = new System.Windows.Forms.TextBox();
            this.lblYCbCr_Cb = new System.Windows.Forms.Label();
            this.txtYCbCr_Cb = new System.Windows.Forms.TextBox();
            this.lblYCbCr_Cr = new System.Windows.Forms.Label();
            this.txtYCbCr_Cr = new System.Windows.Forms.TextBox();
            this.grpRGB.SuspendLayout();
            this.grpCMYK.SuspendLayout();
            this.grpHSV.SuspendLayout();
            this.grpYUV.SuspendLayout();
            this.grpLAB.SuspendLayout();
            this.grpYCbCr.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RGB",
            "HSV",
            "CMYK",
            "YUV",
            "LAB",
            "YCbCr"});
            this.comboBox1.Location = new System.Drawing.Point(105, 619);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 31);
            this.comboBox1.TabIndex = 1;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(12, 12);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(720, 600);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = true;
            // 
            // btnResetView
            // 
            this.btnResetView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResetView.Location = new System.Drawing.Point(245, 619);
            this.btnResetView.Name = "btnResetView";
            this.btnResetView.Size = new System.Drawing.Size(100, 30);
            this.btnResetView.TabIndex = 2;
            this.btnResetView.Text = "Reset View";
            this.btnResetView.UseVisualStyleBackColor = true;
            // 
            // chkShowImageInSpace
            // 
            this.chkShowImageInSpace.AutoSize = true;
            this.chkShowImageInSpace.Checked = true;
            this.chkShowImageInSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowImageInSpace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkShowImageInSpace.Location = new System.Drawing.Point(485, 624);
            this.chkShowImageInSpace.Name = "chkShowImageInSpace";
            this.chkShowImageInSpace.Size = new System.Drawing.Size(144, 24);
            this.chkShowImageInSpace.TabIndex = 4;
            this.chkShowImageInSpace.Text = "Plot Image Pixels";
            // 
            // chkShowShape
            // 
            this.chkShowShape.AutoSize = true;
            this.chkShowShape.Checked = true;
            this.chkShowShape.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowShape.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkShowShape.Location = new System.Drawing.Point(360, 624);
            this.chkShowShape.Name = "chkShowShape";
            this.chkShowShape.Size = new System.Drawing.Size(112, 24);
            this.chkShowShape.TabIndex = 3;
            this.chkShowShape.Text = "Show Shape";
            // 
            // lblColorSystem
            // 
            this.lblColorSystem.AutoSize = true;
            this.lblColorSystem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColorSystem.Location = new System.Drawing.Point(12, 622);
            this.lblColorSystem.Name = "lblColorSystem";
            this.lblColorSystem.Size = new System.Drawing.Size(92, 23);
            this.lblColorSystem.TabIndex = 6;
            this.lblColorSystem.Text = "3D Shape:";
            // 
            // lblSelectedTitle
            // 
            this.lblSelectedTitle.AutoSize = true;
            this.lblSelectedTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedTitle.Location = new System.Drawing.Point(750, 12);
            this.lblSelectedTitle.Name = "lblSelectedTitle";
            this.lblSelectedTitle.Size = new System.Drawing.Size(352, 25);
            this.lblSelectedTitle.TabIndex = 8;
            this.lblSelectedTitle.Text = "Selected Color — Synchronized Values";
            // 
            // panelColorPreview
            // 
            this.panelColorPreview.BackColor = System.Drawing.Color.White;
            this.panelColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorPreview.Location = new System.Drawing.Point(754, 42);
            this.panelColorPreview.Name = "panelColorPreview";
            this.panelColorPreview.Size = new System.Drawing.Size(180, 50);
            this.panelColorPreview.TabIndex = 9;
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHex.Location = new System.Drawing.Point(950, 55);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(87, 23);
            this.lblHex.TabIndex = 10;
            this.lblHex.Text = "#FFFFFF";
            // 
            // grpRGB
            // 
            this.grpRGB.Controls.Add(this.lblRGB_R);
            this.grpRGB.Controls.Add(this.txtRGB_R);
            this.grpRGB.Controls.Add(this.lblRGB_G);
            this.grpRGB.Controls.Add(this.txtRGB_G);
            this.grpRGB.Controls.Add(this.lblRGB_B);
            this.grpRGB.Controls.Add(this.txtRGB_B);
            this.grpRGB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpRGB.Location = new System.Drawing.Point(750, 105);
            this.grpRGB.Name = "grpRGB";
            this.grpRGB.Size = new System.Drawing.Size(250, 165);
            this.grpRGB.TabIndex = 11;
            this.grpRGB.TabStop = false;
            this.grpRGB.Text = "RGB (0 – 255)";
            // 
            // lblRGB_R
            // 
            this.lblRGB_R.Location = new System.Drawing.Point(0, 0);
            this.lblRGB_R.Name = "lblRGB_R";
            this.lblRGB_R.Size = new System.Drawing.Size(100, 23);
            this.lblRGB_R.TabIndex = 0;
            // 
            // txtRGB_R
            // 
            this.txtRGB_R.Location = new System.Drawing.Point(0, 0);
            this.txtRGB_R.Name = "txtRGB_R";
            this.txtRGB_R.Size = new System.Drawing.Size(100, 30);
            this.txtRGB_R.TabIndex = 1;
            // 
            // lblRGB_G
            // 
            this.lblRGB_G.Location = new System.Drawing.Point(0, 0);
            this.lblRGB_G.Name = "lblRGB_G";
            this.lblRGB_G.Size = new System.Drawing.Size(100, 23);
            this.lblRGB_G.TabIndex = 2;
            // 
            // txtRGB_G
            // 
            this.txtRGB_G.Location = new System.Drawing.Point(0, 0);
            this.txtRGB_G.Name = "txtRGB_G";
            this.txtRGB_G.Size = new System.Drawing.Size(100, 30);
            this.txtRGB_G.TabIndex = 3;
            // 
            // lblRGB_B
            // 
            this.lblRGB_B.Location = new System.Drawing.Point(0, 0);
            this.lblRGB_B.Name = "lblRGB_B";
            this.lblRGB_B.Size = new System.Drawing.Size(100, 23);
            this.lblRGB_B.TabIndex = 4;
            // 
            // txtRGB_B
            // 
            this.txtRGB_B.Location = new System.Drawing.Point(0, 0);
            this.txtRGB_B.Name = "txtRGB_B";
            this.txtRGB_B.Size = new System.Drawing.Size(100, 30);
            this.txtRGB_B.TabIndex = 5;
            // 
            // grpCMYK
            // 
            this.grpCMYK.Controls.Add(this.lblCMYK_C);
            this.grpCMYK.Controls.Add(this.txtCMYK_C);
            this.grpCMYK.Controls.Add(this.lblCMYK_M);
            this.grpCMYK.Controls.Add(this.txtCMYK_M);
            this.grpCMYK.Controls.Add(this.lblCMYK_Y);
            this.grpCMYK.Controls.Add(this.txtCMYK_Y);
            this.grpCMYK.Controls.Add(this.lblCMYK_K);
            this.grpCMYK.Controls.Add(this.txtCMYK_K);
            this.grpCMYK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCMYK.Location = new System.Drawing.Point(1010, 105);
            this.grpCMYK.Name = "grpCMYK";
            this.grpCMYK.Size = new System.Drawing.Size(250, 210);
            this.grpCMYK.TabIndex = 12;
            this.grpCMYK.TabStop = false;
            this.grpCMYK.Text = "CMYK (%)";
            // 
            // lblCMYK_C
            // 
            this.lblCMYK_C.Location = new System.Drawing.Point(0, 0);
            this.lblCMYK_C.Name = "lblCMYK_C";
            this.lblCMYK_C.Size = new System.Drawing.Size(100, 23);
            this.lblCMYK_C.TabIndex = 0;
            // 
            // txtCMYK_C
            // 
            this.txtCMYK_C.Location = new System.Drawing.Point(0, 0);
            this.txtCMYK_C.Name = "txtCMYK_C";
            this.txtCMYK_C.Size = new System.Drawing.Size(100, 30);
            this.txtCMYK_C.TabIndex = 1;
            // 
            // lblCMYK_M
            // 
            this.lblCMYK_M.Location = new System.Drawing.Point(0, 0);
            this.lblCMYK_M.Name = "lblCMYK_M";
            this.lblCMYK_M.Size = new System.Drawing.Size(100, 23);
            this.lblCMYK_M.TabIndex = 2;
            // 
            // txtCMYK_M
            // 
            this.txtCMYK_M.Location = new System.Drawing.Point(0, 0);
            this.txtCMYK_M.Name = "txtCMYK_M";
            this.txtCMYK_M.Size = new System.Drawing.Size(100, 30);
            this.txtCMYK_M.TabIndex = 3;
            // 
            // lblCMYK_Y
            // 
            this.lblCMYK_Y.Location = new System.Drawing.Point(0, 0);
            this.lblCMYK_Y.Name = "lblCMYK_Y";
            this.lblCMYK_Y.Size = new System.Drawing.Size(100, 23);
            this.lblCMYK_Y.TabIndex = 4;
            // 
            // txtCMYK_Y
            // 
            this.txtCMYK_Y.Location = new System.Drawing.Point(0, 0);
            this.txtCMYK_Y.Name = "txtCMYK_Y";
            this.txtCMYK_Y.Size = new System.Drawing.Size(100, 30);
            this.txtCMYK_Y.TabIndex = 5;
            // 
            // lblCMYK_K
            // 
            this.lblCMYK_K.Location = new System.Drawing.Point(0, 0);
            this.lblCMYK_K.Name = "lblCMYK_K";
            this.lblCMYK_K.Size = new System.Drawing.Size(100, 23);
            this.lblCMYK_K.TabIndex = 6;
            // 
            // txtCMYK_K
            // 
            this.txtCMYK_K.Location = new System.Drawing.Point(0, 0);
            this.txtCMYK_K.Name = "txtCMYK_K";
            this.txtCMYK_K.Size = new System.Drawing.Size(100, 30);
            this.txtCMYK_K.TabIndex = 7;
            // 
            // grpHSV
            // 
            this.grpHSV.Controls.Add(this.lblHSV_H);
            this.grpHSV.Controls.Add(this.txtHSV_H);
            this.grpHSV.Controls.Add(this.lblHSV_S);
            this.grpHSV.Controls.Add(this.txtHSV_S);
            this.grpHSV.Controls.Add(this.lblHSV_V);
            this.grpHSV.Controls.Add(this.txtHSV_V);
            this.grpHSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpHSV.Location = new System.Drawing.Point(750, 285);
            this.grpHSV.Name = "grpHSV";
            this.grpHSV.Size = new System.Drawing.Size(250, 165);
            this.grpHSV.TabIndex = 13;
            this.grpHSV.TabStop = false;
            this.grpHSV.Text = "HSV (H 0-360 / S,V %)";
            // 
            // lblHSV_H
            // 
            this.lblHSV_H.Location = new System.Drawing.Point(0, 0);
            this.lblHSV_H.Name = "lblHSV_H";
            this.lblHSV_H.Size = new System.Drawing.Size(100, 23);
            this.lblHSV_H.TabIndex = 0;
            // 
            // txtHSV_H
            // 
            this.txtHSV_H.Location = new System.Drawing.Point(0, 0);
            this.txtHSV_H.Name = "txtHSV_H";
            this.txtHSV_H.Size = new System.Drawing.Size(100, 30);
            this.txtHSV_H.TabIndex = 1;
            // 
            // lblHSV_S
            // 
            this.lblHSV_S.Location = new System.Drawing.Point(0, 0);
            this.lblHSV_S.Name = "lblHSV_S";
            this.lblHSV_S.Size = new System.Drawing.Size(100, 23);
            this.lblHSV_S.TabIndex = 2;
            // 
            // txtHSV_S
            // 
            this.txtHSV_S.Location = new System.Drawing.Point(0, 0);
            this.txtHSV_S.Name = "txtHSV_S";
            this.txtHSV_S.Size = new System.Drawing.Size(100, 30);
            this.txtHSV_S.TabIndex = 3;
            // 
            // lblHSV_V
            // 
            this.lblHSV_V.Location = new System.Drawing.Point(0, 0);
            this.lblHSV_V.Name = "lblHSV_V";
            this.lblHSV_V.Size = new System.Drawing.Size(100, 23);
            this.lblHSV_V.TabIndex = 4;
            // 
            // txtHSV_V
            // 
            this.txtHSV_V.Location = new System.Drawing.Point(0, 0);
            this.txtHSV_V.Name = "txtHSV_V";
            this.txtHSV_V.Size = new System.Drawing.Size(100, 30);
            this.txtHSV_V.TabIndex = 5;
            // 
            // grpYUV
            // 
            this.grpYUV.Controls.Add(this.lblYUV_Y);
            this.grpYUV.Controls.Add(this.txtYUV_Y);
            this.grpYUV.Controls.Add(this.lblYUV_U);
            this.grpYUV.Controls.Add(this.txtYUV_U);
            this.grpYUV.Controls.Add(this.lblYUV_V);
            this.grpYUV.Controls.Add(this.txtYUV_V);
            this.grpYUV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpYUV.Location = new System.Drawing.Point(1010, 330);
            this.grpYUV.Name = "grpYUV";
            this.grpYUV.Size = new System.Drawing.Size(250, 165);
            this.grpYUV.TabIndex = 14;
            this.grpYUV.TabStop = false;
            this.grpYUV.Text = "YUV";
            // 
            // lblYUV_Y
            // 
            this.lblYUV_Y.Location = new System.Drawing.Point(0, 0);
            this.lblYUV_Y.Name = "lblYUV_Y";
            this.lblYUV_Y.Size = new System.Drawing.Size(100, 23);
            this.lblYUV_Y.TabIndex = 0;
            // 
            // txtYUV_Y
            // 
            this.txtYUV_Y.Location = new System.Drawing.Point(0, 0);
            this.txtYUV_Y.Name = "txtYUV_Y";
            this.txtYUV_Y.Size = new System.Drawing.Size(100, 30);
            this.txtYUV_Y.TabIndex = 1;
            // 
            // lblYUV_U
            // 
            this.lblYUV_U.Location = new System.Drawing.Point(0, 0);
            this.lblYUV_U.Name = "lblYUV_U";
            this.lblYUV_U.Size = new System.Drawing.Size(100, 23);
            this.lblYUV_U.TabIndex = 2;
            // 
            // txtYUV_U
            // 
            this.txtYUV_U.Location = new System.Drawing.Point(0, 0);
            this.txtYUV_U.Name = "txtYUV_U";
            this.txtYUV_U.Size = new System.Drawing.Size(100, 30);
            this.txtYUV_U.TabIndex = 3;
            // 
            // lblYUV_V
            // 
            this.lblYUV_V.Location = new System.Drawing.Point(0, 0);
            this.lblYUV_V.Name = "lblYUV_V";
            this.lblYUV_V.Size = new System.Drawing.Size(100, 23);
            this.lblYUV_V.TabIndex = 4;
            // 
            // txtYUV_V
            // 
            this.txtYUV_V.Location = new System.Drawing.Point(0, 0);
            this.txtYUV_V.Name = "txtYUV_V";
            this.txtYUV_V.Size = new System.Drawing.Size(100, 30);
            this.txtYUV_V.TabIndex = 5;
            // 
            // grpLAB
            // 
            this.grpLAB.Controls.Add(this.lblLAB_L);
            this.grpLAB.Controls.Add(this.txtLAB_L);
            this.grpLAB.Controls.Add(this.lblLAB_A);
            this.grpLAB.Controls.Add(this.txtLAB_A);
            this.grpLAB.Controls.Add(this.lblLAB_B);
            this.grpLAB.Controls.Add(this.txtLAB_B);
            this.grpLAB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpLAB.Location = new System.Drawing.Point(750, 465);
            this.grpLAB.Name = "grpLAB";
            this.grpLAB.Size = new System.Drawing.Size(250, 165);
            this.grpLAB.TabIndex = 15;
            this.grpLAB.TabStop = false;
            this.grpLAB.Text = "L*a*b*";
            // 
            // lblLAB_L
            // 
            this.lblLAB_L.Location = new System.Drawing.Point(0, 0);
            this.lblLAB_L.Name = "lblLAB_L";
            this.lblLAB_L.Size = new System.Drawing.Size(100, 23);
            this.lblLAB_L.TabIndex = 0;
            // 
            // txtLAB_L
            // 
            this.txtLAB_L.Location = new System.Drawing.Point(0, 0);
            this.txtLAB_L.Name = "txtLAB_L";
            this.txtLAB_L.Size = new System.Drawing.Size(100, 30);
            this.txtLAB_L.TabIndex = 1;
            // 
            // lblLAB_A
            // 
            this.lblLAB_A.Location = new System.Drawing.Point(0, 0);
            this.lblLAB_A.Name = "lblLAB_A";
            this.lblLAB_A.Size = new System.Drawing.Size(100, 23);
            this.lblLAB_A.TabIndex = 2;
            // 
            // txtLAB_A
            // 
            this.txtLAB_A.Location = new System.Drawing.Point(0, 0);
            this.txtLAB_A.Name = "txtLAB_A";
            this.txtLAB_A.Size = new System.Drawing.Size(100, 30);
            this.txtLAB_A.TabIndex = 3;
            // 
            // lblLAB_B
            // 
            this.lblLAB_B.Location = new System.Drawing.Point(0, 0);
            this.lblLAB_B.Name = "lblLAB_B";
            this.lblLAB_B.Size = new System.Drawing.Size(100, 23);
            this.lblLAB_B.TabIndex = 4;
            // 
            // txtLAB_B
            // 
            this.txtLAB_B.Location = new System.Drawing.Point(0, 0);
            this.txtLAB_B.Name = "txtLAB_B";
            this.txtLAB_B.Size = new System.Drawing.Size(100, 30);
            this.txtLAB_B.TabIndex = 5;
            // 
            // grpYCbCr
            // 
            this.grpYCbCr.Controls.Add(this.lblYCbCr_Y);
            this.grpYCbCr.Controls.Add(this.txtYCbCr_Y);
            this.grpYCbCr.Controls.Add(this.lblYCbCr_Cb);
            this.grpYCbCr.Controls.Add(this.txtYCbCr_Cb);
            this.grpYCbCr.Controls.Add(this.lblYCbCr_Cr);
            this.grpYCbCr.Controls.Add(this.txtYCbCr_Cr);
            this.grpYCbCr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpYCbCr.Location = new System.Drawing.Point(1010, 510);
            this.grpYCbCr.Name = "grpYCbCr";
            this.grpYCbCr.Size = new System.Drawing.Size(250, 165);
            this.grpYCbCr.TabIndex = 16;
            this.grpYCbCr.TabStop = false;
            this.grpYCbCr.Text = "YCbCr";
            // 
            // lblYCbCr_Y
            // 
            this.lblYCbCr_Y.Location = new System.Drawing.Point(0, 0);
            this.lblYCbCr_Y.Name = "lblYCbCr_Y";
            this.lblYCbCr_Y.Size = new System.Drawing.Size(100, 23);
            this.lblYCbCr_Y.TabIndex = 0;
            // 
            // txtYCbCr_Y
            // 
            this.txtYCbCr_Y.Location = new System.Drawing.Point(0, 0);
            this.txtYCbCr_Y.Name = "txtYCbCr_Y";
            this.txtYCbCr_Y.Size = new System.Drawing.Size(100, 30);
            this.txtYCbCr_Y.TabIndex = 1;
            // 
            // lblYCbCr_Cb
            // 
            this.lblYCbCr_Cb.Location = new System.Drawing.Point(0, 0);
            this.lblYCbCr_Cb.Name = "lblYCbCr_Cb";
            this.lblYCbCr_Cb.Size = new System.Drawing.Size(100, 23);
            this.lblYCbCr_Cb.TabIndex = 2;
            // 
            // txtYCbCr_Cb
            // 
            this.txtYCbCr_Cb.Location = new System.Drawing.Point(0, 0);
            this.txtYCbCr_Cb.Name = "txtYCbCr_Cb";
            this.txtYCbCr_Cb.Size = new System.Drawing.Size(100, 30);
            this.txtYCbCr_Cb.TabIndex = 3;
            // 
            // lblYCbCr_Cr
            // 
            this.lblYCbCr_Cr.Location = new System.Drawing.Point(0, 0);
            this.lblYCbCr_Cr.Name = "lblYCbCr_Cr";
            this.lblYCbCr_Cr.Size = new System.Drawing.Size(100, 23);
            this.lblYCbCr_Cr.TabIndex = 4;
            // 
            // txtYCbCr_Cr
            // 
            this.txtYCbCr_Cr.Location = new System.Drawing.Point(0, 0);
            this.txtYCbCr_Cr.Name = "txtYCbCr_Cr";
            this.txtYCbCr_Cr.Size = new System.Drawing.Size(100, 30);
            this.txtYCbCr_Cr.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnResetView);
            this.Controls.Add(this.chkShowShape);
            this.Controls.Add(this.chkShowImageInSpace);
            this.Controls.Add(this.lblColorSystem);
            this.Controls.Add(this.lblSelectedTitle);
            this.Controls.Add(this.panelColorPreview);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.grpRGB);
            this.Controls.Add(this.grpCMYK);
            this.Controls.Add(this.grpHSV);
            this.Controls.Add(this.grpYUV);
            this.Controls.Add(this.grpLAB);
            this.Controls.Add(this.grpYCbCr);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PixelLab — 3D Color Space Visualizer (Req. 4 & 5)";
            this.grpRGB.ResumeLayout(false);
            this.grpRGB.PerformLayout();
            this.grpCMYK.ResumeLayout(false);
            this.grpCMYK.PerformLayout();
            this.grpHSV.ResumeLayout(false);
            this.grpHSV.PerformLayout();
            this.grpYUV.ResumeLayout(false);
            this.grpYUV.PerformLayout();
            this.grpLAB.ResumeLayout(false);
            this.grpLAB.PerformLayout();
            this.grpYCbCr.ResumeLayout(false);
            this.grpYCbCr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private static void ConfigureRow(System.Windows.Forms.Label lbl, System.Windows.Forms.TextBox txt, string text, int y)
        {
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lbl.Location = new System.Drawing.Point(15, y + 3);
            lbl.Text = text;

            txt.Font = new System.Drawing.Font("Consolas", 11F);
            txt.Location = new System.Drawing.Point(80, y);
            txt.ReadOnly = true;
            txt.Size = new System.Drawing.Size(150, 27);
            txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txt.BackColor = System.Drawing.Color.White;
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Button btnResetView;
        private System.Windows.Forms.CheckBox chkShowImageInSpace;
        private System.Windows.Forms.CheckBox chkShowShape;
        private System.Windows.Forms.Label lblColorSystem;
        private System.Windows.Forms.Label lblSelectedTitle;
        private System.Windows.Forms.Panel panelColorPreview;
        private System.Windows.Forms.Label lblHex;

        private System.Windows.Forms.GroupBox grpRGB;
        private System.Windows.Forms.Label lblRGB_R, lblRGB_G, lblRGB_B;
        private System.Windows.Forms.TextBox txtRGB_R, txtRGB_G, txtRGB_B;

        private System.Windows.Forms.GroupBox grpCMYK;
        private System.Windows.Forms.Label lblCMYK_C, lblCMYK_M, lblCMYK_Y, lblCMYK_K;
        private System.Windows.Forms.TextBox txtCMYK_C, txtCMYK_M, txtCMYK_Y, txtCMYK_K;

        private System.Windows.Forms.GroupBox grpHSV;
        private System.Windows.Forms.Label lblHSV_H, lblHSV_S, lblHSV_V;
        private System.Windows.Forms.TextBox txtHSV_H, txtHSV_S, txtHSV_V;

        private System.Windows.Forms.GroupBox grpYUV;
        private System.Windows.Forms.Label lblYUV_Y, lblYUV_U, lblYUV_V;
        private System.Windows.Forms.TextBox txtYUV_Y, txtYUV_U, txtYUV_V;

        private System.Windows.Forms.GroupBox grpLAB;
        private System.Windows.Forms.Label lblLAB_L, lblLAB_A, lblLAB_B;
        private System.Windows.Forms.TextBox txtLAB_L, txtLAB_A, txtLAB_B;

        private System.Windows.Forms.GroupBox grpYCbCr;
        private System.Windows.Forms.Label lblYCbCr_Y, lblYCbCr_Cb, lblYCbCr_Cr;
        private System.Windows.Forms.TextBox txtYCbCr_Y, txtYCbCr_Cb, txtYCbCr_Cr;
    }
}
