namespace Chuong3_BT4
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
            lblNhapTen = new Label();
            label2 = new Label();
            txtNhapTen = new TextBox();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            radBlack = new RadioButton();
            radRed = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            grpColor = new GroupBox();
            grpFont = new GroupBox();
            chkUnderline = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            lblLapTrinh = new Label();
            btnThoat = new Button();
            grpFont.SuspendLayout();
            SuspendLayout();
            // 
            // lblNhapTen
            // 
            lblNhapTen.AutoSize = true;
            lblNhapTen.Location = new Point(166, 63);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(86, 25);
            lblNhapTen.TabIndex = 0;
            lblNhapTen.Text = "Nhập Tên";
            lblNhapTen.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 375);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 1;
            label2.Text = "Lập Trình Bởi";
            label2.Click += label2_Click;
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(273, 60);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(366, 31);
            txtNhapTen.TabIndex = 2;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.BackColor = Color.LightBlue;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(193, 191);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(88, 29);
            radGreen.TabIndex = 4;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = false;
            radGreen.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.BackColor = Color.LightBlue;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(193, 238);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(75, 29);
            radBlue.TabIndex = 5;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = false;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.BackColor = Color.LightBlue;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlack.Location = new Point(193, 289);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(83, 29);
            radBlack.TabIndex = 6;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = false;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.BackColor = Color.LightBlue;
            radRed.Checked = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(193, 142);
            radRed.Name = "radRed";
            radRed.Size = new Size(70, 29);
            radRed.TabIndex = 7;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.TextAlign = ContentAlignment.MiddleCenter;
            radRed.UseVisualStyleBackColor = false;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // grpColor
            // 
            grpColor.BackColor = Color.LightBlue;
            grpColor.Location = new Point(69, 112);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(311, 228);
            grpColor.TabIndex = 8;
            grpColor.TabStop = false;
            grpColor.Text = "Color";
            grpColor.Enter += groupBox1_Enter;
            // 
            // grpFont
            // 
            grpFont.BackColor = SystemColors.Info;
            grpFont.Controls.Add(chkUnderline);
            grpFont.Controls.Add(chkItalic);
            grpFont.Controls.Add(chkBold);
            grpFont.Location = new Point(421, 112);
            grpFont.Name = "grpFont";
            grpFont.Size = new Size(351, 228);
            grpFont.TabIndex = 9;
            grpFont.TabStop = false;
            grpFont.Text = "Font";
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            chkUnderline.Location = new Point(73, 127);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(129, 29);
            chkUnderline.TabIndex = 2;
            chkUnderline.Text = "Gạch Chân";
            chkUnderline.UseVisualStyleBackColor = true;
            chkUnderline.CheckedChanged += chkUnderline_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkItalic.Location = new Point(73, 79);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(82, 29);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBold.Location = new Point(73, 31);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(77, 29);
            chkBold.TabIndex = 0;
            chkBold.Text = "Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BorderStyle = BorderStyle.Fixed3D;
            lblLapTrinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLapTrinh.ForeColor = Color.DarkRed;
            lblLapTrinh.Location = new Point(300, 354);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(323, 77);
            lblLapTrinh.TabIndex = 10;
            lblLapTrinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(660, 375);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(lblLapTrinh);
            Controls.Add(grpFont);
            Controls.Add(radRed);
            Controls.Add(radBlack);
            Controls.Add(radBlue);
            Controls.Add(radGreen);
            Controls.Add(txtNhapTen);
            Controls.Add(label2);
            Controls.Add(lblNhapTen);
            Controls.Add(grpColor);
            Name = "Form1";
            Text = "Form1";
            grpFont.ResumeLayout(false);
            grpFont.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapTen;
        private Label label2;
        private TextBox txtNhapTen;
        private RadioButton radGreen;
        private RadioButton radBlue;
        private RadioButton radBlack;
        private RadioButton radRed;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private GroupBox grpColor;
        private GroupBox grpFont;
        private CheckBox chkUnderline;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private Label lblLapTrinh;
        private Button btnThoat;
    }
}
