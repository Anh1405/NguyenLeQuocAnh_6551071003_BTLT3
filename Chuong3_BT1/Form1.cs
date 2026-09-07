using System;
using System.Windows.Forms;

namespace Chuong3_BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtNhapPassword.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHienThi.Clear();
            txtNhapPassword.Clear();
            txtNhapPassword.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show(
                "Có chắc bạn muốn đóng ứng dụng?",
                "Thông báo!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}