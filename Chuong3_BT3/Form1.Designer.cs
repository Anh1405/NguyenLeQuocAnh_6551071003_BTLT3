namespace Chuong3_BT3
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
            lblHo = new Label();
            lblTen = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            button4 = new Button();
            label1 = new Label();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Location = new Point(187, 97);
            lblHo.Name = "lblHo";
            lblHo.Size = new Size(66, 25);
            lblHo.TabIndex = 0;
            lblHo.Text = "Họ Lót";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(187, 168);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(38, 25);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(315, 97);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(243, 31);
            txtHo.TabIndex = 2;
            txtHo.TextChanged += txtHo_TextChanged;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(315, 168);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(243, 31);
            txtTen.TabIndex = 3;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(134, 262);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(112, 34);
            btnHo.TabIndex = 4;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(361, 262);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(112, 34);
            btnTen.TabIndex = 5;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(601, 262);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(112, 34);
            btnHoTen.TabIndex = 6;
            btnHoTen.Text = "Họ Và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // button4
            // 
            button4.Location = new Point(274, 369);
            button4.Name = "button4";
            button4.Size = new Size(284, 34);
            button4.TabIndex = 7;
            button4.Text = "Thoát Chương Trình";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(601, 336);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 8;
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.ActiveCaption;
            lblHoTen.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoTen.ForeColor = SystemColors.Control;
            lblHoTen.Location = new Point(0, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(798, 74);
            lblHoTen.TabIndex = 9;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHoTen);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(lblTen);
            Controls.Add(lblHo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHo;
        private Label lblTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button button4;
        private Label label1;
        private Label lblHoTen;
    }
}
