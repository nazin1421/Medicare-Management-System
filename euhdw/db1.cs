using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace euhdw
{

    class db1
    {

    
        private MySqlConnection Connection = new MySqlConnection("server = localhost; port=3306; Username=root; Password=; database=hospital_management"); 

            public void openConnection()
        {
            if(Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public void closeConnection()
        {
            if(Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();

            }

        }

        public MySqlConnection getConnection()
        {
            return Connection;
        }

        
    }
}
