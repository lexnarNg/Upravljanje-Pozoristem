using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepertoarPozorista
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            linijaUcitaj.Value = startpos;
            ProcentiLbl.Text = startpos + "%";
            if (linijaUcitaj.Value == 100)
            {
                linijaUcitaj.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();


            }
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
