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
    public partial class Racun : Form
    {
        public Racun()
        {
            InitializeComponent();
            populate();
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
         private void UpdatePredstava()
        {
            int novaKolicina = pocetno - Convert.ToInt32(KolicinaTBRacun.Text);
            try
            {
                Con.Open();
                string query = "update PredstaveTbl set KolicinaKarata= " + novaKolicina +  "where idPredstave=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Izmena Uspesno Obavljena!!!");
                Con.Close();
                populate();
                //reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }

        int n = 0;
        int grdTotal = 0;
        private void DodajNaRacunDGM_Click(object sender, EventArgs e)
        {
            if(KolicinaTBRacun.Text=="" || Convert.ToInt32(KolicinaTBRacun.Text) > pocetno)
            {
                MessageBox.Show("Molim Vas popunite POLJE KOLIČINA");
            }else
            {
                int total = Convert.ToInt32(KolicinaTBRacun.Text) * Convert.ToInt32(CenaTBRacun.Text);
                DataGridViewRow noviRed = new DataGridViewRow();
                noviRed.CreateCells(DGVRacun);
                noviRed.Cells[0].Value = n + 1;
                noviRed.Cells[1].Value = NazivPredstaveTBRacun.Text;
                noviRed.Cells[2].Value = CenaTBRacun.Text;
                noviRed.Cells[3].Value = KolicinaTBRacun.Text;
                noviRed.Cells[4].Value = total;
                DGVRacun.Rows.Add(noviRed);
                n++;
                UpdatePredstava();
                grdTotal = grdTotal + total;
                totalLbl.Text =  grdTotal+"RSD";


            }
        }
        int key = 0 ;
        int pocetno = 0;
        private void lstPredstava_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NazivPredstaveTBRacun.Text = lstPredstava.CurrentRow.Cells[1].Value.ToString();
            //KolicinaTBRacun.Text = lstPredstava.CurrentRow.Cells[4].Value.ToString();
            CenaTBRacun.Text = lstPredstava.CurrentRow.Cells[5].Value.ToString();

            if (NazivPredstaveTBRacun.Text == ""){
                key = 0;
                pocetno = 0;
            }
            else{
                key = Convert.ToInt32(lstPredstava.CurrentRow.Cells[0].Value.ToString());
                pocetno = Convert.ToInt32(lstPredstava.CurrentRow.Cells[4].Value.ToString());
            }
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset() {
            NazivPredstaveTBRacun.Text = "";
            KolicinaTBRacun.Text = "";
            ImeKupcaTBRacun.Text = "";
            CenaTBRacun.Text = "";


        }
        private void resetujDGMRacun_Click(object sender, EventArgs e)
        {
            Reset();
        }    
 
        private void Racun_Load(object sender, EventArgs e)
        {
            lblKorisnika.Text = Login.KorisnickoIme;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
        
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 25;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void KolicinaTBRacun_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(KolicinaTBRacun.Text, "  ^ [0-9]"))
            {
                MessageBox.Show("Molim Vas popunite POLJE KOLIČINA");
                KolicinaTBRacun.Text = "";
            }
        }
        int idPredstave, cena, kolicina, suma, pocPozicija = 60;
        string nazivPredstave;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Pozoriste", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(160));
            e.Graphics.DrawString("ID   PREDSTAVA              CENA       KOLICINA        SUMA", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(26,40));

            foreach (DataGridViewRow row in DGVRacun.Rows) {

                idPredstave = Convert.ToInt32(row.Cells["Column1"].Value);
                nazivPredstave = "" + row.Cells["Column2"].Value;
                cena = Convert.ToInt32(row.Cells["Column3"].Value);
                kolicina = Convert.ToInt32(row.Cells["Column4"].Value);
                suma = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString(""+idPredstave,new Font ("Century Gothic",8, FontStyle.Bold),Brushes.Black,new Point(26, pocPozicija));
                e.Graphics.DrawString("" + nazivPredstave, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(45, pocPozicija));
                e.Graphics.DrawString("" + cena, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(192, pocPozicija));
               e.Graphics.DrawString("" +  kolicina, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(275, pocPozicija));
                e.Graphics.DrawString("" + suma, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(355, pocPozicija));

                pocPozicija = pocPozicija + 45;
            }

            e.Graphics.DrawString("UKUPNA SUMA NARUCENOG : RSD" + grdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(40, pocPozicija + 50));
            e.Graphics.DrawString("=======REPERTOAR POZORISTA=======", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(70, pocPozicija + 85));

            DGVRacun.Rows.Clear();
            DGVRacun.Refresh();
            pocPozicija = 100;
            grdTotal = 0;

        }

        private void stampajDGMRacun_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm",400,600);
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK) {

                printDocument1.Print();
            }
        }
    }
}
