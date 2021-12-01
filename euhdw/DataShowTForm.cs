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
    public partial class DataShowTForm : Form
    {
        public DataShowTForm()
        {
            InitializeComponent();
        }


        //private MySqlConnection Connection = new MySqlConnection("server = localhost; port=3306; Username=root; Password=; database=hoapital_management");

        private void DataShowTForm_Load(object sender, EventArgs e)
        {
            db1 DB2 = new db1();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM cabin_check", DB2.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridViewCabin.DataSource = table;

            //string selectQuery = "SELECT * FROM add_cabin";
            //DataTable table = new DataTable();
            //MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, Connection);

            //adapter.Fill(table);
            //dataGridViewCabin.DataSource = table;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm2 x = new MainForm2();
            x.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm2 x = new HomeForm2();
            x.Show();
        }

        private void DataGridViewCabin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
