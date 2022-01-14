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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txtSifraGlavna;
            txtSifraGlavna.Focus();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Doctor-Who\Documents\PozoristeDB1.mdf;Integrated Security=True;Connect Timeout=30");
        public static string KorisnickoIme = "";
        private void Izlaz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void LogInDugme_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from KorisniciTabl where KorisnickoIme ='" + txtKorisnickoGlavna.Text + "' and Sifra='" + txtSifraGlavna.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                KorisnickoIme = txtKorisnickoGlavna.Text;
                Racun obj = new Racun();
                obj.Show();
                this.Hide();
                Con.Close();

            }
            else
            {
                MessageBox.Show("Pogresno KorisnickoIme ili Lozinka!");
            }
            Con.Close();
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminLbl_Click(object sender, EventArgs e)
        {
            AdminForma obj = new AdminForma();
            obj.Show();
            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
