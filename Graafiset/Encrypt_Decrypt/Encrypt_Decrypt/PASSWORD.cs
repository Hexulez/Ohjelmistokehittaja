using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt_Decrypt
{
    internal class PASSWORD
    {
        CONNECT connection = new CONNECT();
        CRYPTING cryptring = new CRYPTING();
        ERAMAKE eramake = new ERAMAKE();
        public void Encrypt(String password, int nbr)
        {
            string salasana = "", cryptType = "";
            
            if (nbr == 1)
            {
                salasana = cryptring.Encrypt(password);
                cryptType = "complex";
            }
            else if (nbr == 2)
            {
                salasana = eramake.EraEncrypt(password);
                cryptType = "eramake";
            }

            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO salasanat" +
                "(salasana, encrypting) " +
                "VALUES (@ssa, @enc); ";
            komento.CommandText = lisayskysely;
            komento.Connection = connection.Connection();
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salasana;
            komento.Parameters.Add("@enc", MySqlDbType.VarChar).Value = cryptType;

            connection.openConnection();
            if (komento.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();

            }
            else
            {
                connection.closeConnection();

            }
        }


        public DataTable HaeSalasanat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT salasana, encrypting FROM salasanat", connection.Connection());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

    }
}
