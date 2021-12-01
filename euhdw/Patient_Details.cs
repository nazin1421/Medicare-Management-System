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
    public partial class Patient_Details : Form
    {
      
        public Patient_Details()
        {
            InitializeComponent();
        }

        private void Patient_Details_Load(object sender, EventArgs e)
        {

            searchData("");
        }

        public void searchData(string valueToSearch)
        {
            db1 DB3 = new db1();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM patient_details  WHERE CONCAT(`cabin_nUmber`)like '%" + valueToSearch + "%'", DB3.getConnection());

            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewPatient.DataSource = table;



        }

        private void BTN_SEARCH_Click_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBoxValueToSearch.Text.ToString();
            searchData(valueToSearch);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm2 x = new HomeForm2();
            x.Show();
        }
    }
}
