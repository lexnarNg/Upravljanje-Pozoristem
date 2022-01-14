using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepertoarPozorista
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Doctor-Who\Documents\PozoristeDB1.mdf;Integrated Security=True;Connect Timeout=30");

        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Predstave obj = new Predstave();
            obj.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Korisnici obj = new Korisnici();
            obj.Show();
            this.Hide();
        }
        
        private void Pocetna_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select SUM (KolicinaKarata) from PredstaveTbl ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            kolKnjiga.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select count (*) from KorisniciTabl ", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            ukupnoKorisnikaLbl.Text = dt1.Rows[0][0].ToString();
            Con.Close();
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
