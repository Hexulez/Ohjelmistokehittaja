using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava20_oppilasHallinta
{
    internal class OPISKELIJA
    {
        CONNECT connection = new CONNECT();

        public bool lisaaOpiskelija(String enimi, String snimi, String puh, String email, int onro)
        {
            string ktunnus = "";
            try
            {
                ktunnus = enimi.ToLower() + snimi.Substring(0, 3).ToLower();

            }
            catch (Exception ex)
            {
                MessageBox.Show("sukunimi on liian lyhyt", ex.Message);
                return false;
            }
            String salis = salasana();
            //String salattu = Encrypt(salis);
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO yhteystiedot " +
                "(etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero, ktunnus) " +
                "VALUES (@enm, @snm, @puh, @eml, @ono, @usr ); ";
            komento.CommandText = lisayskysely;
            komento.Connection = connection.Connection();
            //@enm, @snm, @puh, @eml, @ono
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;
            komento.Parameters.Add("@usr", MySqlDbType.VarChar).Value = ktunnus;
            //komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salattu;
            MessageBox.Show("Käyttäjätunnuksesi on " + ktunnus + "\nSalasanasi on " + salis + /*"\nSalattuna se on" + salattu + */"\nkirjoita nämä visusti talteen");

            connection.openConnection();
            if (komento.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }

        // Luodaan funktio kaikkien asiakastietojan hakemiseksi
        public DataTable haeOpiskelijat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT oid, etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero,ktunnus FROM yhteystiedot", connection.Connection());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            
            return taulu;
        }

        // Luodaan funktio asiakkaan tietojen muokkaamiseksi
        public bool muokkaaOpiskelijaa(int oid, String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `yhteystiedot` SET `etunimi`= @enm," +
                "`sukunimi`= @snm,`puhelin`= @puh,`sahkoposti`= @eml,`opiskelijanumero`= @ono" +
                " WHERE oid = @oid";
            komento.CommandText = paivityskysely;
            komento.Connection = connection.Connection();
            //@enm, @snm, @puh, @eml, @ono
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;
            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;
            




            connection.openConnection();
            if (komento.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }

        // Luodaan funktio asiakkaan tietojen poistamiseen
        // tähän tarvitaan vain käyttäjätunnus
        public bool poistaOpiskelija(int ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM yhteystiedot WHERE oid = @oid";
            komento.CommandText = poistokysely;
            komento.Connection = connection.Connection();
            //@oid
            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = ktunnus;
            //String salattu = "rIcQwyLOwjxbi7JdVNulwTvPETORgfcGwtuPsvQAuVc=";
            //String salasana = Decrypt(salattu);
            MessageBox.Show(salasana() + "");
            connection.openConnection();
            if (komento.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }
        public String salasana()
        {
            char[] jono = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            String ssana = "";
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                ssana += jono[rnd.Next(0, 61)];
            }
            return ssana;
        }
    }
}
