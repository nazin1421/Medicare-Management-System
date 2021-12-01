using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 35);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            db1 DB1 = new db1();
            string username = textBoxUserame.Text;
            string password = textBoxPassword.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admin_login` WHERE `Username`=@usn AND `Password`=@pass", DB1.getConnection());

            command.Parameters.Add ("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add ("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count >0)
            {
                MessageBox.Show("yes");

                this.Hide();
                HomeForm2 x = new HomeForm2();
                x.Show();

            }
            else
            {
                if(username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your Username to login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your Password to login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }


        }

        private void Label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void Label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

       

        private void Label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void ButtonCreateAC_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm x = new RegisterForm();
            x.Show();
        }
    }
}
