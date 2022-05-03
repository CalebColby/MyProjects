namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            lbnGreet.Text = "Hello, World";
        }
    }
}