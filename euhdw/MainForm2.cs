using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace euhdw
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 x = new Form1();
            x.Show();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm x = new RegisterForm();
            x.Show();
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
