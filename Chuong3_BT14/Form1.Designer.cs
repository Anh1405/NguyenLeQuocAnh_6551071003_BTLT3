namespace Chuong3_BT5
{
    partial class Form1
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
            lblTieuDe = new Label();
            txtTen = new TextBox();
            btnCapNhat = new Button();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btnSangPhai = new Button();
            btnSangPhaiTatCa = new Button();
            btnSangTrai = new Button();
            btnSangTraiTatCa = new Button();
            btnXoaLopA = new Button();
            btnKetThuc = new Button();
            btnXoaLopB = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTieuDe.Location = new Point(45, 38);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(80, 28);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Tên SV:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(135, 37);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(310, 31);
            txtTen.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(460, 33);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(130, 38);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(45, 95);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(200, 229);
            lstLopA.TabIndex = 3;
            lstLopA.SelectedIndexChanged += lstLopA_SelectedIndexChanged;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(365, 95);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(225, 229);
            lstLopB.TabIndex = 8;
            // 
            // btnSangPhai
            // 
            btnSangPhai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSangPhai.Location = new Point(270, 105);
            btnSangPhai.Name = "btnSangPhai";
            btnSangPhai.Size = new Size(70, 35);
            btnSangPhai.TabIndex = 4;
            btnSangPhai.Text = ">";
            btnSangPhai.UseVisualStyleBackColor = true;
            btnSangPhai.Click += btnSangPhai_Click;
            // 
            // btnSangPhaiTatCa
            // 
            btnSangPhaiTatCa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSangPhaiTatCa.Location = new Point(270, 155);
            btnSangPhaiTatCa.Name = "btnSangPhaiTatCa";
            btnSangPhaiTatCa.Size = new Size(70, 35);
            btnSangPhaiTatCa.TabIndex = 5;
            btnSangPhaiTatCa.Text = ">>";
            btnSangPhaiTatCa.UseVisualStyleBackColor = true;
            btnSangPhaiTatCa.Click += btnSangPhaiTatCa_Click;
            // 
            // btnSangTrai
            // 
            btnSangTrai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSangTrai.Location = new Point(270, 205);
            btnSangTrai.Name = "btnSangTrai";
            btnSangTrai.Size = new Size(70, 35);
            btnSangTrai.TabIndex = 6;
            btnSangTrai.Text = "<";
            btnSangTrai.UseVisualStyleBackColor = true;
            btnSangTrai.Click += btnSangTrai_Click;
            // 
            // btnSangTraiTatCa
            // 
            btnSangTraiTatCa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSangTraiTatCa.Location = new Point(270, 255);
            btnSangTraiTatCa.Name = "btnSangTraiTatCa";
            btnSangTraiTatCa.Size = new Size(70, 35);
            btnSangTraiTatCa.TabIndex = 7;
            btnSangTraiTatCa.Text = "<<";
            btnSangTraiTatCa.UseVisualStyleBackColor = true;
            btnSangTraiTatCa.Click += btnSangTraiTatCa_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Location = new Point(45, 345);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(150, 40);
            btnXoaLopA.TabIndex = 9;
            btnXoaLopA.Text = "Xóa Lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(230, 345);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(150, 40);
            btnKetThuc.TabIndex = 10;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Location = new Point(415, 345);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(175, 40);
            btnXoaLopB.TabIndex = 11;
            btnXoaLopB.Text = "Xóa Lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 414);
            Controls.Add(btnXoaLopB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaLopA);
            Controls.Add(lstLopB);
            Controls.Add(btnSangTraiTatCa);
            Controls.Add(btnSangTrai);
            Controls.Add(btnSangPhaiTatCa);
            Controls.Add(btnSangPhai);
            Controls.Add(lstLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTen);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Cập Nhật 2 ListBox";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private TextBox txtTen;
        private Button btnCapNhat;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button btnSangPhai;
        private Button btnSangPhaiTatCa;
        private Button btnSangTrai;
        private Button btnSangTraiTatCa;
        private Button btnXoaLopA;
        private Button btnKetThuc;
        private Button btnXoaLopB;
    }
}