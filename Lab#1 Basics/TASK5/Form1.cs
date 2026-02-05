using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String name=uname.Text;
            String pass=upassword.Text;

            if(name=="admin"&& pass == "12345")
            {
                MessageBox.Show("LOG IN SUCCESSFULL");
            }
            else
            {
                MessageBox.Show("WRONG USER NAME OR PASSWORD");
            }
        }
    }
}
