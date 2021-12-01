using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace euhdw
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        

        private void TextBoxFastname_Enter(object sender, EventArgs e)
        {
            string fname = textBoxFastname.Text;
            if(fname.ToLower().Trim().Equals(""))
            {
                textBoxFastname.Text = "";
                textBoxFastname.ForeColor = Color.Black;

            }
        }

        private void TextBoxFastname_Leave(object sender, EventArgs e)
        {
            string fname = textBoxFastname.Text;
            if (fname.ToLower().Trim().Equals("") || fname.Trim().Equals(""))
            {
                textBoxFastname.Text = "first name";


            }

        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

       

        private void LabelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void LabelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Gray;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            db1 DB1 = new db1();
            MySqlCommand command = new MySqlCommand("INSERT INTO `admin_login`(`First_name`, `Last_name`, `Email`, `Username`, `Password`)VALUES (@fn, @ln, @email, @usn, @pass)", DB1.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFastname.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastname.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUserame.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            DB1.openConnection();

            if(!checkTextBoxesvalues())
            {
                if(textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))

                {

                    if (checkUsername())
                    {
                        MessageBox.Show("This username already uses");

                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Account Created");
                            this.Hide();
                            MainForm2 x = new MainForm2();
                            x.Show(); 
                        }
                        else
                        {
                            MessageBox.Show("Error");

                        }

                    }
                }

                else
                {
                    MessageBox.Show(" wrong confirm password");
                }

            }

                
            else
            {

                MessageBox.Show("Enter your information first");
            }

            
            DB1.closeConnection();

        }

            public Boolean checkUsername()
            {
                db1 DB = new db1();

                string username = textBoxUserame.Text;
                

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM `admin_login` WHERE `Username`=@usn ", DB.getConnection());

                command1.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
               
                adapter.SelectCommand = command1;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return true;

                }
                else
                {
                    return false;

                }

            }

        public Boolean checkTextBoxesvalues()
        {

            string fname = textBoxFastname.Text;
            string lname = textBoxLastname.Text;
            string email = textBoxEmail.Text;
            string uname = textBoxUserame.Text;
            string pass  = textBoxPassword.Text;

            if(fname.Equals("first name")|| lname.Equals("last name")
                || email.Equals("email addres") || uname.Equals("username") || pass.Equals("password"))

            {
                return true;

            }
            else
            {

                return false;
            }

        }

        private void ButtonFontPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm2 x = new MainForm2();
            x.Show();
        }
    }
}
