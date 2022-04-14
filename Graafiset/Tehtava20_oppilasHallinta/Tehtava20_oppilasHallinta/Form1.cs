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

namespace Tehtava20_oppilasHallinta
{
    public partial class Form1 : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();
        public Form1()
        {
            InitializeComponent();
        }

        private void eraseBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            firstNameTB.Text ="";
            lastNameTB.Text = "";
            phoneTB.Text = "";
            emailTB.Text ="";
            opiskelijaNroTB.Text ="";

            tietoTauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void tallenneBT_Click(object sender, EventArgs e)
        {
            string enimi = firstNameTB.Text;
            string snimi = lastNameTB.Text;
            string pnumero = tarkistaPuhelin(phoneTB.Text);
            string email = emailTB.Text;
            int oNmr = Numeroksi(opiskelijaNroTB.Text);


            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || pnumero.Trim().Equals("") || email.Trim().Equals("") || oNmr.Equals("") || oNmr.Equals(-1))
            {
                MessageBox.Show("Virhe - Kaikki  vaaditut kentät pitää olla täytettynä");
            }
            else
            {
                bool lisaaOpiskelija = opiskelija.lisaaOpiskelija(enimi, snimi, pnumero, email, oNmr);
                if (lisaaOpiskelija)
                {
                    MessageBox.Show("Uusi piskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            tietoTauluDG.DataSource = opiskelija.haeOpiskelijat();

        }

        private void paivitaBT_Click(object sender, EventArgs e)
        {

            string enimi = firstNameTB.Text;
            string snimi = lastNameTB.Text;
            string pnumero = tarkistaPuhelin(phoneTB.Text);
            string email = emailTB.Text;
            int oNmr = Numeroksi(opiskelijaNroTB.Text);
            int oId = Numeroksi(idTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || pnumero.Trim().Equals("") || email.Trim().Equals("") || oNmr.Equals("") || oNmr.Equals(-1) || oNmr.Equals("") || oNmr.Equals(-1))
            {
                MessageBox.Show("Virhe - Kaikki  vaaditut kentät pitää olla täytettynä");
            }
            else
            {
                bool muutaOpiskelija = opiskelija.muokkaaOpiskelijaa(oId, enimi, snimi, pnumero, email, oNmr);
                if (muutaOpiskelija)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("opiskelijaa ei pystytty muokkaamaan", "Opiskelijan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            tietoTauluDG.DataSource = opiskelija.haeOpiskelijat();

        }



        private int Numeroksi(string luku)
        {
            try
            {
                return Int32.Parse(luku);
            }
            catch (Exception ex)
            {
                MessageBox.Show("numero virheellinen.", ex.Message);
                return -1;
            }
        }

        private string tarkistaPuhelin(string numero)
        {
            try
            {
                Int32.Parse(numero);
                return numero;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Anna puhelin numero ilman erikoismerkkejä tai välilyöntejä");
                return "";
            }

        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            int oId = Numeroksi(idTB.Text);

            if (oId.Equals("") || oId.Equals(-1))
            {
                MessageBox.Show("Virhe - määriteltyä opiskelijaa ei ole");
            }
            else
            {
                bool poista= opiskelija.poistaOpiskelija(oId);
                if (poista)
                {
                    MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("opiskelijaa ei pystytty Poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            tietoTauluDG.DataSource = opiskelija.haeOpiskelijat();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tietoTauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void tietoTauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = tietoTauluDG.CurrentRow.Cells[0].Value.ToString();
            firstNameTB.Text = tietoTauluDG.CurrentRow.Cells[1].Value.ToString();
            lastNameTB.Text = tietoTauluDG.CurrentRow.Cells[2].Value.ToString();
            phoneTB.Text = tietoTauluDG.CurrentRow.Cells[3].Value.ToString();
            emailTB.Text = tietoTauluDG.CurrentRow.Cells[4].Value.ToString();
            opiskelijaNroTB.Text = tietoTauluDG.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
