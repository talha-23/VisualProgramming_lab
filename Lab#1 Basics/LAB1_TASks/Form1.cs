namespace LAB1_TASks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string NAME = tb1.Text;
            MessageBox.Show("WELCOME TO VISUAL PROGRAMMING " + NAME + " :)");
        }
    }
}
