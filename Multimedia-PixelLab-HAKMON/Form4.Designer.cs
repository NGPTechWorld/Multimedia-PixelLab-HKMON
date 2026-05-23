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
            this.lblImageInfo = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();

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
            // glControl1
            //
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(12, 12);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(720, 600);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = true;
            //
            // lblColorSystem
            //
            this.lblColorSystem.AutoSize = true;
            this.lblColorSystem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblColorSystem.Location = new System.Drawing.Point(12, 622);
            this.lblColorSystem.Name = "lblColorSystem";
            this.lblColorSystem.Text = "3D Shape:";
            //
            // comboBox1
            //
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            // btnResetView
            //
            this.btnResetView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetView.Location = new System.Drawing.Point(245, 619);
            this.btnResetView.Name = "btnResetView";
            this.btnResetView.Size = new System.Drawing.Size(100, 30);
            this.btnResetView.TabIndex = 2;
            this.btnResetView.Text = "Reset View";
            this.btnResetView.UseVisualStyleBackColor = true;
            //
            // chkShowShape
            //
            this.chkShowShape.AutoSize = true;
            this.chkShowShape.Checked = true;
            this.chkShowShape.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowShape.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowShape.Location = new System.Drawing.Point(360, 624);
            this.chkShowShape.Name = "chkShowShape";
            this.chkShowShape.Text = "Show Shape";
            //
            // chkShowImageInSpace
            //
            this.chkShowImageInSpace.AutoSize = true;
            this.chkShowImageInSpace.Checked = true;
            this.chkShowImageInSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowImageInSpace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowImageInSpace.Location = new System.Drawing.Point(485, 624);
            this.chkShowImageInSpace.Name = "chkShowImageInSpace";
            this.chkShowImageInSpace.Text = "Plot Image Pixels";
            //
            // lblImageInfo
            //
            this.lblImageInfo.AutoSize = true;
            this.lblImageInfo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblImageInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblImageInfo.Location = new System.Drawing.Point(625, 624);
            this.lblImageInfo.Name = "lblImageInfo";
            this.lblImageInfo.Text = "No image";
            //
            // lblInstructions
            //
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.ForeColor = System.Drawing.Color.DimGray;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblInstructions.Location = new System.Drawing.Point(12, 662);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Text = "Drag = Rotate   |   Wheel = Zoom   |   Click colored area = pick + sync all 6 systems";
            //
            // lblSelectedTitle
            //
            this.lblSelectedTitle.AutoSize = true;
            this.lblSelectedTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSelectedTitle.Location = new System.Drawing.Point(750, 12);
            this.lblSelectedTitle.Name = "lblSelectedTitle";
            this.lblSelectedTitle.Text = "Selected Color — Synchronized Values";
            //
            // panelColorPreview
            //
            this.panelColorPreview.BackColor = System.Drawing.Color.White;
            this.panelColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorPreview.Location = new System.Drawing.Point(754, 42);
            this.panelColorPreview.Name = "panelColorPreview";
            this.panelColorPreview.Size = new System.Drawing.Size(180, 50);
            //
            // lblHex
            //
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblHex.Location = new System.Drawing.Point(950, 55);
            this.lblHex.Name = "lblHex";
            this.lblHex.Text = "#FFFFFF";

            // ─────────────────────────────────────────
            // RGB GroupBox
            // ─────────────────────────────────────────
            this.lblRGB_R.AutoSize = true;
            this.lblRGB_R.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRGB_R.Location = new System.Drawing.Point(15, 33);
            this.lblRGB_R.Name = "lblRGB_R";
            this.lblRGB_R.Text = "R:";

            this.txtRGB_R.BackColor = System.Drawing.Color.White;
            this.txtRGB_R.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtRGB_R.Location = new System.Drawing.Point(80, 30);
            this.txtRGB_R.Name = "txtRGB_R";
            this.txtRGB_R.ReadOnly = true;
            this.txtRGB_R.Size = new System.Drawing.Size(150, 27);
            this.txtRGB_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblRGB_G.AutoSize = true;
            this.lblRGB_G.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRGB_G.Location = new System.Drawing.Point(15, 78);
            this.lblRGB_G.Name = "lblRGB_G";
            this.lblRGB_G.Text = "G:";

            this.txtRGB_G.BackColor = System.Drawing.Color.White;
            this.txtRGB_G.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtRGB_G.Location = new System.Drawing.Point(80, 75);
            this.txtRGB_G.Name = "txtRGB_G";
            this.txtRGB_G.ReadOnly = true;
            this.txtRGB_G.Size = new System.Drawing.Size(150, 27);
            this.txtRGB_G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblRGB_B.AutoSize = true;
            this.lblRGB_B.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRGB_B.Location = new System.Drawing.Point(15, 123);
            this.lblRGB_B.Name = "lblRGB_B";
            this.lblRGB_B.Text = "B:";

            this.txtRGB_B.BackColor = System.Drawing.Color.White;
            this.txtRGB_B.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtRGB_B.Location = new System.Drawing.Point(80, 120);
            this.txtRGB_B.Name = "txtRGB_B";
            this.txtRGB_B.ReadOnly = true;
            this.txtRGB_B.Size = new System.Drawing.Size(150, 27);
            this.txtRGB_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.grpRGB.Controls.Add(this.lblRGB_R);
            this.grpRGB.Controls.Add(this.txtRGB_R);
            this.grpRGB.Controls.Add(this.lblRGB_G);
            this.grpRGB.Controls.Add(this.txtRGB_G);
            this.grpRGB.Controls.Add(this.lblRGB_B);
            this.grpRGB.Controls.Add(this.txtRGB_B);
            this.grpRGB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpRGB.Location = new System.Drawing.Point(750, 105);
            this.grpRGB.Name = "grpRGB";
            this.grpRGB.Size = new System.Drawing.Size(250, 165);
            this.grpRGB.TabStop = false;
            this.grpRGB.Text = "RGB (0 – 255)";

            // ─────────────────────────────────────────
            // CMYK GroupBox
            // ─────────────────────────────────────────
            this.lblCMYK_C.AutoSize = true;
            this.lblCMYK_C.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCMYK_C.Location = new System.Drawing.Point(15, 33);
            this.lblCMYK_C.Name = "lblCMYK_C";
            this.lblCMYK_C.Text = "C:";

            this.txtCMYK_C.BackColor = System.Drawing.Color.White;
            this.txtCMYK_C.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtCMYK_C.Location = new System.Drawing.Point(80, 30);
            this.txtCMYK_C.Name = "txtCMYK_C";
            this.txtCMYK_C.ReadOnly = true;
            this.txtCMYK_C.Size = new System.Drawing.Size(150, 27);
            this.txtCMYK_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblCMYK_M.AutoSize = true;
            this.lblCMYK_M.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCMYK_M.Location = new System.Drawing.Point(15, 78);
            this.lblCMYK_M.Name = "lblCMYK_M";
            this.lblCMYK_M.Text = "M:";

            this.txtCMYK_M.BackColor = System.Drawing.Color.White;
            this.txtCMYK_M.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtCMYK_M.Location = new System.Drawing.Point(80, 75);
            this.txtCMYK_M.Name = "txtCMYK_M";
            this.txtCMYK_M.ReadOnly = true;
            this.txtCMYK_M.Size = new System.Drawing.Size(150, 27);
            this.txtCMYK_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblCMYK_Y.AutoSize = true;
            this.lblCMYK_Y.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCMYK_Y.Location = new System.Drawing.Point(15, 123);
            this.lblCMYK_Y.Name = "lblCMYK_Y";
            this.lblCMYK_Y.Text = "Y:";

            this.txtCMYK_Y.BackColor = System.Drawing.Color.White;
            this.txtCMYK_Y.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtCMYK_Y.Location = new System.Drawing.Point(80, 120);
            this.txtCMYK_Y.Name = "txtCMYK_Y";
            this.txtCMYK_Y.ReadOnly = true;
            this.txtCMYK_Y.Size = new System.Drawing.Size(150, 27);
            this.txtCMYK_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblCMYK_K.AutoSize = true;
            this.lblCMYK_K.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCMYK_K.Location = new System.Drawing.Point(15, 168);
            this.lblCMYK_K.Name = "lblCMYK_K";
            this.lblCMYK_K.Text = "K:";

            this.txtCMYK_K.BackColor = System.Drawing.Color.White;
            this.txtCMYK_K.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtCMYK_K.Location = new System.Drawing.Point(80, 165);
            this.txtCMYK_K.Name = "txtCMYK_K";
            this.txtCMYK_K.ReadOnly = true;
            this.txtCMYK_K.Size = new System.Drawing.Size(150, 27);
            this.txtCMYK_K.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.grpCMYK.Controls.Add(this.lblCMYK_C);
            this.grpCMYK.Controls.Add(this.txtCMYK_C);
            this.grpCMYK.Controls.Add(this.lblCMYK_M);
            this.grpCMYK.Controls.Add(this.txtCMYK_M);
            this.grpCMYK.Controls.Add(this.lblCMYK_Y);
            this.grpCMYK.Controls.Add(this.txtCMYK_Y);
            this.grpCMYK.Controls.Add(this.lblCMYK_K);
            this.grpCMYK.Controls.Add(this.txtCMYK_K);
            this.grpCMYK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCMYK.Location = new System.Drawing.Point(1010, 105);
            this.grpCMYK.Name = "grpCMYK";
            this.grpCMYK.Size = new System.Drawing.Size(250, 210);
            this.grpCMYK.TabStop = false;
            this.grpCMYK.Text = "CMYK (%)";

            // ─────────────────────────────────────────
            // HSV GroupBox
            // ─────────────────────────────────────────
            this.lblHSV_H.AutoSize = true;
            this.lblHSV_H.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHSV_H.Location = new System.Drawing.Point(15, 33);
            this.lblHSV_H.Name = "lblHSV_H";
            this.lblHSV_H.Text = "H:";

            this.txtHSV_H.BackColor = System.Drawing.Color.White;
            this.txtHSV_H.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtHSV_H.Location = new System.Drawing.Point(80, 30);
            this.txtHSV_H.Name = "txtHSV_H";
            this.txtHSV_H.ReadOnly = true;
            this.txtHSV_H.Size = new System.Drawing.Size(150, 27);
            this.txtHSV_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblHSV_S.AutoSize = true;
            this.lblHSV_S.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHSV_S.Location = new System.Drawing.Point(15, 78);
            this.lblHSV_S.Name = "lblHSV_S";
            this.lblHSV_S.Text = "S:";

            this.txtHSV_S.BackColor = System.Drawing.Color.White;
            this.txtHSV_S.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtHSV_S.Location = new System.Drawing.Point(80, 75);
            this.txtHSV_S.Name = "txtHSV_S";
            this.txtHSV_S.ReadOnly = true;
            this.txtHSV_S.Size = new System.Drawing.Size(150, 27);
            this.txtHSV_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblHSV_V.AutoSize = true;
            this.lblHSV_V.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHSV_V.Location = new System.Drawing.Point(15, 123);
            this.lblHSV_V.Name = "lblHSV_V";
            this.lblHSV_V.Text = "V:";

            this.txtHSV_V.BackColor = System.Drawing.Color.White;
            this.txtHSV_V.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtHSV_V.Location = new System.Drawing.Point(80, 120);
            this.txtHSV_V.Name = "txtHSV_V";
            this.txtHSV_V.ReadOnly = true;
            this.txtHSV_V.Size = new System.Drawing.Size(150, 27);
            this.txtHSV_V.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.grpHSV.Controls.Add(this.lblHSV_H);
            this.grpHSV.Controls.Add(this.txtHSV_H);
            this.grpHSV.Controls.Add(this.lblHSV_S);
            this.grpHSV.Controls.Add(this.txtHSV_S);
            this.grpHSV.Controls.Add(this.lblHSV_V);
            this.grpHSV.Controls.Add(this.txtHSV_V);
            this.grpHSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpHSV.Location = new System.Drawing.Point(750, 285);
            this.grpHSV.Name = "grpHSV";
            this.grpHSV.Size = new System.Drawing.Size(250, 165);
            this.grpHSV.TabStop = false;
            this.grpHSV.Text = "HSV (H 0-360 / S,V %)";

            // ─────────────────────────────────────────
            // YUV GroupBox
            // ─────────────────────────────────────────
            this.lblYUV_Y.AutoSize = true;
            this.lblYUV_Y.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblYUV_Y.Location = new System.Drawing.Point(15, 33);
            this.lblYUV_Y.Name = "lblYUV_Y";
            this.lblYUV_Y.Text = "Y:";

            this.txtYUV_Y.BackColor = System.Drawing.Color.White;
            this.txtYUV_Y.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtYUV_Y.Location = new System.Drawing.Point(80, 30);
            this.txtYUV_Y.Name = "txtYUV_Y";
            this.txtYUV_Y.ReadOnly = true;
            this.txtYUV_Y.Size = new System.Drawing.Size(150, 27);
            this.txtYUV_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblYUV_U.AutoSize = true;
            this.lblYUV_U.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblYUV_U.Location = new System.Drawing.Point(15, 78);
            this.lblYUV_U.Name = "lblYUV_U";
            this.lblYUV_U.Text = "U:";

            this.txtYUV_U.BackColor = System.Drawing.Color.White;
            this.txtYUV_U.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtYUV_U.Location = new System.Drawing.Point(80, 75);
            this.txtYUV_U.Name = "txtYUV_U";
            this.txtYUV_U.ReadOnly = true;
            this.txtYUV_U.Size = new System.Drawing.Size(150, 27);
            this.txtYUV_U.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblYUV_V.AutoSize = true;
            this.lblYUV_V.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblYUV_V.Location = new System.Drawing.Point(15, 123);
            this.lblYUV_V.Name = "lblYUV_V";
            this.lblYUV_V.Text = "V:";

            this.txtYUV_V.BackColor = System.Drawing.Color.White;
            this.txtYUV_V.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtYUV_V.Location = new System.Drawing.Point(80, 120);
            this.txtYUV_V.Name = "txtYUV_V";
            this.txtYUV_V.ReadOnly = true;
            this.txtYUV_V.Size = new System.Drawing.Size(150, 27);
            this.txtYUV_V.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.grpYUV.Controls.Add(this.lblYUV_Y);
            this.grpYUV.Controls.Add(this.txtYUV_Y);
            this.grpYUV.Controls.Add(this.lblYUV_U);
            this.grpYUV.Controls.Add(this.txtYUV_U);
            this.grpYUV.Controls.Add(this.lblYUV_V);
            this.grpYUV.Controls.Add(this.txtYUV_V);
            this.grpYUV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpYUV.Location = new System.Drawing.Point(1010, 330);
            this.grpYUV.Name = "grpYUV";
            this.grpYUV.Size = new System.Drawing.Size(250, 165);
            this.grpYUV.TabStop = false;
            this.grpYUV.Text = "YUV";

            // ─────────────────────────────────────────
            // LAB GroupBox
            // ─────────────────────────────────────────
            this.lblLAB_L.AutoSize = true;
            this.lblLAB_L.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLAB_L.Location = new System.Drawing.Point(15, 33);
            this.lblLAB_L.Name = "lblLAB_L";
            this.lblLAB_L.Text = "L:";

            this.txtLAB_L.BackColor = System.Drawing.Color.White;
            this.txtLAB_L.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtLAB_L.Location = new System.Drawing.Point(80, 30);
            this.txtLAB_L.Name = "txtLAB_L";
            this.txtLAB_L.ReadOnly = true;
            this.txtLAB_L.Size = new System.Drawing.Size(150, 27);
            this.txtLAB_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblLAB_A.AutoSize = true;
            this.lblLAB_A.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLAB_A.Location = new System.Drawing.Point(15, 78);
            this.lblLAB_A.Name = "lblLAB_A";
            this.lblLAB_A.Text = "a:";

            this.txtLAB_A.BackColor = System.Drawing.Color.White;
            this.txtLAB_A.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtLAB_A.Location = new System.Drawing.Point(80, 75);
            this.txtLAB_A.Name = "txtLAB_A";
            this.txtLAB_A.ReadOnly = true;
            this.txtLAB_A.Size = new System.Drawing.Size(150, 27);
            this.txtLAB_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblLAB_B.AutoSize = true;
            this.lblLAB_B.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLAB_B.Location = new System.Drawing.Point(15, 123);
            this.lblLAB_B.Name = "lblLAB_B";
            this.lblLAB_B.Text = "b:";

            this.txtLAB_B.BackColor = System.Drawing.Color.White;
            this.txtLAB_B.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtLAB_B.Location = new System.Drawing.Point(80, 120);
            this.txtLAB_B.Name = "txtLAB_B";
            this.txtLAB_B.ReadOnly = true;
            this.txtLAB_B.Size = new System.Drawing.Size(150, 27);
            this.txtLAB_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.grpLAB.Controls.Add(this.lblLAB_L);
            this.grpLAB.Controls.Add(this.txtLAB_L);
            this.grpLAB.Controls.Add(this.lblLAB_A);
            this.grpLAB.Controls.Add(this.txtLAB_A);
            this.grpLAB.Controls.Add(this.lblLAB_B);
            this.grpLAB.Controls.Add(this.txtLAB_B);
            this.grpLAB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpLAB.Location = new System.Drawing.Point(750, 465);
            this.grpLAB.Name = "grpLAB";
            this.grpLAB.Size = new System.Drawing.Size(250, 165);
            this.grpLAB.TabStop = false;
            this.grpLAB.Text = "L*a*b*";

            // ─────────────────────────────────────────
            // YCbCr GroupBox
            // ─────────────────────────────────────────
            this.lblYCbCr_Y.AutoSize = true;
            this.lblYCbCr_Y.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblYCbCr_Y.Location = new System.Drawing.Point(15, 33);
            this.lblYCbCr_Y.Name = "lblYCbCr_Y";
            this.lblYCbCr_Y.Text = "Y:";

            this.txtYCbCr_Y.BackColor = System.Drawing.Color.White;
            this.txtYCbCr_Y.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtYCbCr_Y.Location = new System.Drawing.Point(80, 30);
            this.txtYCbCr_Y.Name = "txtYCbCr_Y";
            this.txtYCbCr_Y.ReadOnly = true;
            this.txtYCbCr_Y.Size = new System.Drawing.Size(150, 27);
            this.txtYCbCr_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblYCbCr_Cb.AutoSize = true;
            this.lblYCbCr_Cb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblYCbCr_Cb.Location = new System.Drawing.Point(15, 78);
            this.lblYCbCr_Cb.Name = "lblYCbCr_Cb";
            this.lblYCbCr_Cb.Text = "Cb:";

            this.txtYCbCr_Cb.BackColor = System.Drawing.Color.White;
            this.txtYCbCr_Cb.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtYCbCr_Cb.Location = new System.Drawing.Point(80, 75);
            this.txtYCbCr_Cb.Name = "txtYCbCr_Cb";
            this.txtYCbCr_Cb.ReadOnly = true;
            this.txtYCbCr_Cb.Size = new System.Drawing.Size(150, 27);
            this.txtYCbCr_Cb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.lblYCbCr_Cr.AutoSize = true;
            this.lblYCbCr_Cr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblYCbCr_Cr.Location = new System.Drawing.Point(15, 123);
            this.lblYCbCr_Cr.Name = "lblYCbCr_Cr";
            this.lblYCbCr_Cr.Text = "Cr:";

            this.txtYCbCr_Cr.BackColor = System.Drawing.Color.White;
            this.txtYCbCr_Cr.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtYCbCr_Cr.Location = new System.Drawing.Point(80, 120);
            this.txtYCbCr_Cr.Name = "txtYCbCr_Cr";
            this.txtYCbCr_Cr.ReadOnly = true;
            this.txtYCbCr_Cr.Size = new System.Drawing.Size(150, 27);
            this.txtYCbCr_Cr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.grpYCbCr.Controls.Add(this.lblYCbCr_Y);
            this.grpYCbCr.Controls.Add(this.txtYCbCr_Y);
            this.grpYCbCr.Controls.Add(this.lblYCbCr_Cb);
            this.grpYCbCr.Controls.Add(this.txtYCbCr_Cb);
            this.grpYCbCr.Controls.Add(this.lblYCbCr_Cr);
            this.grpYCbCr.Controls.Add(this.txtYCbCr_Cr);
            this.grpYCbCr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpYCbCr.Location = new System.Drawing.Point(1010, 510);
            this.grpYCbCr.Name = "grpYCbCr";
            this.grpYCbCr.Size = new System.Drawing.Size(250, 165);
            this.grpYCbCr.TabStop = false;
            this.grpYCbCr.Text = "YCbCr";

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
            this.Controls.Add(this.lblImageInfo);
            this.Controls.Add(this.lblInstructions);
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
        private System.Windows.Forms.Label lblImageInfo;
        private System.Windows.Forms.Label lblInstructions;

        private System.Windows.Forms.GroupBox grpRGB;
        private System.Windows.Forms.Label lblRGB_R;
        private System.Windows.Forms.Label lblRGB_G;
        private System.Windows.Forms.Label lblRGB_B;
        private System.Windows.Forms.TextBox txtRGB_R;
        private System.Windows.Forms.TextBox txtRGB_G;
        private System.Windows.Forms.TextBox txtRGB_B;

        private System.Windows.Forms.GroupBox grpCMYK;
        private System.Windows.Forms.Label lblCMYK_C;
        private System.Windows.Forms.Label lblCMYK_M;
        private System.Windows.Forms.Label lblCMYK_Y;
        private System.Windows.Forms.Label lblCMYK_K;
        private System.Windows.Forms.TextBox txtCMYK_C;
        private System.Windows.Forms.TextBox txtCMYK_M;
        private System.Windows.Forms.TextBox txtCMYK_Y;
        private System.Windows.Forms.TextBox txtCMYK_K;

        private System.Windows.Forms.GroupBox grpHSV;
        private System.Windows.Forms.Label lblHSV_H;
        private System.Windows.Forms.Label lblHSV_S;
        private System.Windows.Forms.Label lblHSV_V;
        private System.Windows.Forms.TextBox txtHSV_H;
        private System.Windows.Forms.TextBox txtHSV_S;
        private System.Windows.Forms.TextBox txtHSV_V;

        private System.Windows.Forms.GroupBox grpYUV;
        private System.Windows.Forms.Label lblYUV_Y;
        private System.Windows.Forms.Label lblYUV_U;
        private System.Windows.Forms.Label lblYUV_V;
        private System.Windows.Forms.TextBox txtYUV_Y;
        private System.Windows.Forms.TextBox txtYUV_U;
        private System.Windows.Forms.TextBox txtYUV_V;

        private System.Windows.Forms.GroupBox grpLAB;
        private System.Windows.Forms.Label lblLAB_L;
        private System.Windows.Forms.Label lblLAB_A;
        private System.Windows.Forms.Label lblLAB_B;
        private System.Windows.Forms.TextBox txtLAB_L;
        private System.Windows.Forms.TextBox txtLAB_A;
        private System.Windows.Forms.TextBox txtLAB_B;

        private System.Windows.Forms.GroupBox grpYCbCr;
        private System.Windows.Forms.Label lblYCbCr_Y;
        private System.Windows.Forms.Label lblYCbCr_Cb;
        private System.Windows.Forms.Label lblYCbCr_Cr;
        private System.Windows.Forms.TextBox txtYCbCr_Y;
        private System.Windows.Forms.TextBox txtYCbCr_Cb;
        private System.Windows.Forms.TextBox txtYCbCr_Cr;
    }
}
