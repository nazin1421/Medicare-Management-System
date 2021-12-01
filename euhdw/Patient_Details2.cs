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
    public partial class Patient_Details2 : Form
    {
        public Patient_Details2()
        {
            InitializeComponent();
        }

        private void Patient_Details2_Load(object sender, EventArgs e)
        {
            searchData("");
        }
        public void searchData(string valueToSearch)
        {
            db1 DB3 = new db1();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM patient_details  WHERE CONCAT(`cabin_nUmber`,`date`)like '%" + valueToSearch + "%'", DB3.getConnection());

            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewPatientD.DataSource = table;


        }

        private void BTN_SEARCH_Click_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBoxValueToSearch.Text.ToString();
            searchData(valueToSearch);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

            string constring = "server = localhost; port = 3306; Username = root; Password =; database = hoapital_management";

            string cabinnumbert = textBox1.Text;


            string quez = "UPDATE add_cabin SET Avail=1 WHERE Cabin_No=@cn;";


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

            string cabinnumbertf = comboBox2.Text;


            string quezn = "UPDATE cabin_check SET cabin_avail=cabin_avail+1 WHERE cabin_type=@cn;";


            MySqlConnection nfDataBase = new MySqlConnection(constring);
            MySqlCommand mdxDatBase = new MySqlCommand(quezn, nfDataBase);
            mdxDatBase.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cabinnumbertf;

            MySqlDataReader Readerzn;
            //string SUM;

            try
            {
                nfDataBase.Open();
                Readerzn = mdxDatBase.ExecuteReader();
                MessageBox.Show("ok");
                if (Readerzn.HasRows)

                {
                    if (Readerzn.Read())
                    {
                        MessageBox.Show("ok");

                        //string mystring;

                        //SUM = Reader.GetString(0);

                        //p = double.Parse(SUM);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        MessageBox.Show("ok");



                        nfDataBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            string cabinnumbertx = comboBox2.Text;
            string queza = "UPDATE cabin_check SET cabin_booking=cabin_booking-1 WHERE cabin_type=@cn;";


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



            db1 DB2 = new db1();
            string cabinnumber = textBox1.Text;
            //string cabintype = textBoxCabinType.Text;
            //string cabinprice = textBoxCabinPrice.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("DELETE FROM `patient_details` WHERE cabin_nUmber =(@cn) ", DB2.getConnection());


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
                Patient_Details2 x = new Patient_Details2();
                x.Show();
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm2 x = new HomeForm2();
            x.Show();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
