namespace Chuong3_BT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " +txtTen.Text;
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
