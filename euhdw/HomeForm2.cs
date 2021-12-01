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
    public partial class HomeForm2 : Form
    {
        public HomeForm2()
        {
            InitializeComponent();
        }

        private void ButtonAddCabin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddcabinForm x = new AddcabinForm();
            x.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingForm x = new BookingForm();
            x.Show();
        }

       

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataShowTForm x = new DataShowTForm();
            x.Show();
        }

        private void Sign_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm2 x = new MainForm2();
            x.Show();
        }

        private void Buttonpatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Details x = new Patient_Details();
            x.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Details2 x = new Patient_Details2();
            x.Show();
        }
    }
}
