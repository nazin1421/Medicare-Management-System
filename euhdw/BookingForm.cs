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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }



        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            /*db1 DB1 = new db1();
            string firstname = textBoxFirstname.Text;
            string lastname = textBoxLastname.Text;
            string dr = textBoxDR.Text;
            string username = textBoxUserame.Text;
            string phone = textBoxPhone.Text;
            string cabinnumber = textBoxCabinN.Text;
            //string avail =textAvail.Text;


            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `patient_details`(`first_name`, `last_name`, `dr.name`, `username`, `p_number`, `cabin_nUmber`) VALUES (@fname,@lname,@dr,@usn,@pn,@cn)", DB1.getConnection());
            //MySqlCommand command1 = new MySqlCommand("UPDATE `add_cabin` SET `Avail`= 1 WHERE 'Cabin_No' =(@cn)", DB1.getConnection());

            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@dr", MySqlDbType.VarChar).Value = dr;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cabinnumber;
            //command1.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cabinnumber;
            //command1.Parameters.Add("@av", MySqlDbType.VarChar).Value = avail;

            adapter.SelectCommand = command;
            //adapter.SelectCommand = command1;
            adapter.Fill(table);
            //adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("no");

               

            }
            else
            {
                MessageBox.Show("yes");
                this.Hide();
                HomeForm2 x = new HomeForm2();
                x.Show();

            }
         
             */

            string constring = "server = localhost; port = 3306; Username = root; Password =; database = hoapital_management";

            string firstname = textBoxFirstname.Text;
            string lastname = textBoxLastname.Text;
            string dr = textBoxDR.Text;
            string ctype = comboBox1.Text;
            string username = textBoxUserame.Text;
            string phone = textBoxPhone.Text;
            string cabinnumber = textBoxCabinN.Text;
            string avail =textAvail.Text;
            string totaltaka = textBox1.Text;
            string paid = textBox2.Text;
            string due = textBox3.Text;
            string dob = textBox4.Text;

            string que = "INSERT INTO `patient_details`(`first_name`, `last_name`, `dr.name`, `cabin_type`,`cabin_Price`, `p_number`, `cabin_number`,`day`, `total_taka`, `paid`, `due`, `date`) VALUES (@fname,@lname,@dr,@ctype,@usn,@pn,@cn,@day,@tk,@pd,@due,@dob)";


            MySqlConnection onDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatBase = new MySqlCommand(que, onDataBase);

            cmdDatBase.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstname;
            cmdDatBase.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastname;
            cmdDatBase.Parameters.Add("@dr", MySqlDbType.VarChar).Value = dr;
            cmdDatBase.Parameters.Add("@ctype", MySqlDbType.VarChar).Value = ctype;
            cmdDatBase.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            cmdDatBase.Parameters.Add("@pn", MySqlDbType.VarChar).Value = phone;
            cmdDatBase.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cabinnumber;
            cmdDatBase.Parameters.Add("@day", MySqlDbType.VarChar).Value = avail;
            cmdDatBase.Parameters.Add("@tk", MySqlDbType.VarChar).Value = totaltaka;
            cmdDatBase.Parameters.Add("@pd", MySqlDbType.VarChar).Value = paid;
            cmdDatBase.Parameters.Add("@due", MySqlDbType.VarChar).Value = due;
            cmdDatBase.Parameters.Add("@dob", MySqlDbType.VarChar).Value = dob;
            MySqlDataReader Reader;
            //string SUM;

            try
            {
                onDataBase.Open();
                Reader = cmdDatBase.ExecuteReader();
                //  MessageBox.Show("ok");
                if (Reader.HasRows)

                {
                    if (Reader.Read())
                    {
                        //string mystring;

                        //SUM = Reader.GetString(0);

                        //p = double.Parse(SUM);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        MessageBox.Show("ok");



                        onDataBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            string cabinnumbert = comboBox1.Text;
            string quez = "UPDATE cabin_check SET cabin_avail=cabin_avail-1 WHERE cabin_type=@cn;";


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


            string cabinnumbertx = comboBox1.Text;
            string queza = "UPDATE cabin_check SET cabin_booking=cabin_booking+1 WHERE cabin_type=@cn;";


            MySqlConnection naDataBase = new MySqlConnection(constring);
            MySqlCommand mdaDatBase = new MySqlCommand(queza, naDataBase);
            mdaDatBase.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cabinnumbertx;

            MySqlDataReader Readerza;
            //string SUM;

            try
            {
                naDataBase.Open();
                Readerza = mdaDatBase.ExecuteReader();
                MessageBox.Show("ok");
                if (Readerza.HasRows)

                {
                    if (Readerza.Read())
                    {
                        MessageBox.Show("ok");

                        //string mystring;

                        //SUM = Reader.GetString(0);

                        //p = double.Parse(SUM);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        MessageBox.Show("ok");



                        naDataBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }





            string cabinnumberty = textBoxCabinN.Text;


            string quezx = "UPDATE add_cabin SET Avail=0 WHERE Cabin_No=@cn;";


            MySqlConnection nmDataBase = new MySqlConnection(constring);
            MySqlCommand mdmDatBase = new MySqlCommand(quezx, nmDataBase);
            mdmDatBase.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cabinnumberty;

            MySqlDataReader Readerzx;
            //string SUM;

            try
            {
                nmDataBase.Open();
                Readerzx = mdmDatBase.ExecuteReader();
                 MessageBox.Show("ok");
                if (Readerzx.HasRows)

                {
                    if (Readerzx.Read())
                    {
                          MessageBox.Show("ok");

                        //string mystring;

                        //SUM = Reader.GetString(0);

                        //p = double.Parse(SUM);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        MessageBox.Show("ok");



                        nmDataBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


            private void ButtonHome_Click(object sender, EventArgs e)
            {
                this.Hide();
                HomeForm2 x = new HomeForm2();
                x.Show();
            }

            private void TextBoxCabinN_TextChanged(object sender, EventArgs e)
            {

            }

       

        private void DataGridViewPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            searchData("");
        }
        public void searchData(string valueToSearch)
        {
            db1 DB3 = new db1();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM add_cabin  WHERE CONCAT(`Cabin_type`)like '%" + valueToSearch + "%'", DB3.getConnection());

            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewCabin.DataSource = table;


        }

        private void BTN_SEARCH_Click_Click(object sender, EventArgs e)
        {
            string valueToSearch = comboBox2.Text.ToString();
            searchData(valueToSearch); 
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextAvail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (float.Parse(textBoxUserame.Text) * float.Parse(textAvail.Text)).ToString();
            }
            catch
            {

            }

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = (float.Parse(textBox1.Text) - float.Parse(textBox2.Text)).ToString();
            }
            catch
            {

            }
        }

       
    }
    }

