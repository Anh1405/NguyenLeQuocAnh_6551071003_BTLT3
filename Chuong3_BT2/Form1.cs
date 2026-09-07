namespace Chuong3_BT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked.");
        }
        private void frmSimpleEvent_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi , Welcome to C# 2010 programming!");
        }
        private void frmSimpleEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }
        
    }
}
