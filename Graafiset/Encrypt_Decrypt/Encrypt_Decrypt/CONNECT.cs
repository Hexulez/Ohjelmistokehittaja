using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Encrypt_Decrypt
{
    public class CONNECT
    {
        private MySqlConnection _connection = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=salasanat;SSL Mode = None");

        public MySqlConnection Connection()
        {
            return _connection;
        }

        public void openConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }

        public void closeConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
