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
    public partial class AdminForma : Form
    {
        public AdminForma()
        {
            InitializeComponent();
        }

        private void LogInDugme_Click(object sender, EventArgs e)
        {
            if (txtSifraGlavna.Text == "sifra")
            {
                Predstave obj = new Predstave();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Molim vas Unesite Sifru!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
