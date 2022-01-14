using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RepertoarPozorista
{
    public partial class Korisnici : Form
    {
        public Korisnici()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Doctor-Who\Documents\PozoristeDB1.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * FROM KorisniciTabl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVKorisnici.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Izlaz1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SačuvajDGMKorisnici_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoKorisnici.Text == "" || txttelefoKorisnika.Text == "" || txtAdresaKorisnika.Text == "" || txtSifraKorisnika.Text == "")
            {
                MessageBox.Show("Unesite Trazene Informacije!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = " INSERT INTO KorisniciTabl (KorisnickoIme, Telefon,Adresa,Sifra)  values ('" + txtKorisnickoKorisnici.Text + "','" + txttelefoKorisnika.Text + "', '" + txtAdresaKorisnika.Text + "', '" + txtSifraKorisnika.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Korisnik Dodat Uspesno!");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Reset()
        {
            txtKorisnickoKorisnici.Text = "";
            txtSifraKorisnika.Text = "";
            txtAdresaKorisnika.Text = "";
            txttelefoKorisnika.Text = "";

        }
        private void resetujDGMKorisnici_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ObrisiDGMKorisnici_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Unesite Trazene Informacije!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from KorisniciTabl where idKorisnika = " + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Korisnik Obrisan Uspesno!");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void DGVKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKorisnickoKorisnici.Text = DGVKorisnici.CurrentRow.Cells[1].Value.ToString();
            txtSifraKorisnika.Text = DGVKorisnici.CurrentRow.Cells[2].Value.ToString();
            txtAdresaKorisnika.Text = DGVKorisnici.CurrentRow.Cells[3].Value.ToString();
            txttelefoKorisnika.Text = DGVKorisnici.CurrentRow.Cells[4].Value.ToString();

            if (txtKorisnickoKorisnici.Text == "")

            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DGVKorisnici.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void IzmeniDGMKorisnici_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoKorisnici.Text == "" || txttelefoKorisnika.Text == "" || txtAdresaKorisnika.Text == "" || txtSifraKorisnika.Text == "")
            {
                MessageBox.Show("Unesite Trazene Informacije!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update KorisniciTabl set KorisnickoIme= '" + txtKorisnickoKorisnici.Text + "', Telefon= '" + txttelefoKorisnika.Text + "', Adresa='" + txtAdresaKorisnika.Text + "', Sifra= '" + txtSifraKorisnika.Text + "' where idKorisnika=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Izmena Informacija o Korisniku Uspesna!");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Predstave obj = new Predstave();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Pocetna obj = new Pocetna();
            obj.Show();
            this.Hide();
        }
    }
}
