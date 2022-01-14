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
    public partial class Predstave : Form
    {
        public Predstave()
        {
            InitializeComponent();
            populate();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Doctor-Who\Documents\PozoristeDB1.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * FROM PredstaveTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            lstPredstava.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Filter()
        {
            Con.Open();
            string query = "select * FROM PredstaveTbl where Zanr='"+cmbPretragaPredstaveZanr.SelectedItem.ToString()+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            lstPredstava.DataSource = ds.Tables[0];
            Con.Close();


        }
        private void SačuvajDGMPredstave_Click_1(object sender, EventArgs e)
        {
            if (txtNazivPredstave.Text == "" || txtAutorPredstave.Text == "" || ComboOdaberiZanr.SelectedIndex== -1 || txtKolicinaKarata.Text == "" || txtCenaPredstave.Text == "")
            {
                MessageBox.Show("Unesite Trazene Informacije!!!");
            }
            else
            {
                try {
                    Con.Open();
                    string query = " INSERT INTO PredstaveTbl (NazivPredstave, Autor,Zanr,KolicinaKarata,Cena)  values ('"+txtNazivPredstave.Text+ "','"+txtAutorPredstave.Text+"','" + ComboOdaberiZanr.SelectedItem.ToString() + "', '"+ txtKolicinaKarata.Text+"', '"+ txtCenaPredstave.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Predstava Sacuvana Uspesno!");
                    Con.Close();
                    populate();
                    reset();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboPretragaZanrPredstave_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void osveziDGMPredstave_Click(object sender, EventArgs e)
        {
            populate();
            cmbPretragaPredstaveZanr.SelectedIndex = -1;
        }
        private void reset()
        {
            txtNazivPredstave.Text = "";
            txtAutorPredstave.Text = "";
            ComboOdaberiZanr.SelectedIndex = -1;
            txtKolicinaKarata.Text = "";
            txtCenaPredstave.Text = "";

        }
        private void resetujDGMPredstave_Click(object sender, EventArgs e)
        {
            reset();
            
        }
        //Selektori redova i kolona
        int key = 0;
        private void lstPredstava_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            txtNazivPredstave.Text = lstPredstava.CurrentRow.Cells[1].Value.ToString();
            txtAutorPredstave.Text = lstPredstava.CurrentRow.Cells[2].Value.ToString();
            ComboOdaberiZanr.SelectedItem = lstPredstava.CurrentRow.Cells[3].Value.ToString();
            txtKolicinaKarata.Text = lstPredstava.CurrentRow.Cells[4].Value.ToString();
            txtCenaPredstave.Text = lstPredstava.CurrentRow.Cells[5].Value.ToString();
            
            if (txtNazivPredstave.Text == "")

            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(lstPredstava.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void ObrisiDGMPredstave_Click(object sender, EventArgs e)
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
                    string query = "delete from PredstaveTbl where idPredstave = " +key+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Predstava Obrisana Uspesno!");
                    Con.Close();
                    populate();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        
        private void IzmeniDGMPredstave_Click(object sender, EventArgs e)
        {
            if (txtNazivPredstave.Text == "" || txtAutorPredstave.Text == "" || ComboOdaberiZanr.SelectedIndex == -1 || txtKolicinaKarata.Text == "" || txtCenaPredstave.Text == "")
            {
                MessageBox.Show("Unesite Trazene Informacije!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PredstaveTbl set NazivPredstave= '"+txtNazivPredstave.Text+ "', Autor= '"+txtAutorPredstave.Text+"', Zanr='"+ComboOdaberiZanr.SelectedItem.ToString()+"', KolicinaKarata= "+txtKolicinaKarata.Text+", Cena="+txtCenaPredstave.Text+ "where idPredstave="+key+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Izmena Uspesno Obavljena!!!");
                    Con.Close();
                    populate();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        //Medjusobno povezivanje formi
        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Korisnici obj = new Korisnici();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Pocetna obj = new Pocetna();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
