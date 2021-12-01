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
    public partial class AddcabinForm : Form

    {
        public AddcabinForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string constring = "server = localhost; port = 3306; Username = root; Password =; database =hospital_management";

            string cabinnumbert = comboBox1.Text;


            string quez = "UPDATE cabin_check SET cabin_avail=cabin_avail+1 WHERE cabin_type=@cn;";


            MySqlConnection nDataBase = new MySqlConnection(constring);
            MySqlCommand mdDatBase = new MySqlCommand(quez, nDataBase);
            mdDatBase.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cabinnumbert;

            MySqlDataReader Readerz;
            //string SUM;

            try
            {
                nDataBase.Open();
                Readerz = mdDatBase.ExecuteReader();
                MessageBox.Show("ok");
                if (Readerz.HasRows)

                {
                    if (Readerz.Read())
                    {
                        MessageBox.Show("ok");

                        //string mystring;

                        //SUM = Reader.GetString(0);

                        //p = double.Parse(SUM);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        MessageBox.Show("ok");



                        nDataBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        


            db1 DB1 = new db1();
            string cabinnumber = textBoxCabinNo.Text;
            string cabintype = comboBox1.Text;
            string cabinprice = textBoxCabinPrice.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `add_cabin`(`Cabin_No`, `Cabin_type`,`Cabin_price`, `Avail`) VALUES (@cn,@ct,@cp,0)", DB1.getConnection());

            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cabinnumber;
            command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = cabintype;
            command.Parameters.Add("@cp", MySqlDbType.VarChar).Value = cabinprice;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("No");

            }
            else
            {
                MessageBox.Show("Yes");
                this.Hide();
                HomeForm2 x = new HomeForm2();
                x.Show();
            }
        }
        

            private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm2 x = new HomeForm2();
            x.Show();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
           
            
                db1 DB2 = new db1();
                string cabinnumber = textBoxCabinNo.Text;
                //string cabintype = textBoxCabinType.Text;
                string cabinprice = textBoxCabinPrice.Text;

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("DELETE FROM `add_cabin` WHERE Cabin_No =(@cn) ", DB2.getConnection());
                

                command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cabinnumber;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("No");

                }
                else
                {
                    MessageBox.Show("Yes");
                    this.Hide();
                    AddcabinForm x = new AddcabinForm();
                    x.Show();
                }


        }
          

        
    }
}
