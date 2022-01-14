
namespace RepertoarPozorista
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Izlaz = new System.Windows.Forms.Button();
            this.AdminLbl = new System.Windows.Forms.Label();
            this.LogInDugme = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifraGlavna = new System.Windows.Forms.TextBox();
            this.txtKorisnickoGlavna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 481);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(68, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "DOBRO DOŠLI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(50, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Obiman Repertoar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(59, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ljubazno Osoblje";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.AdminLbl);
            this.panel2.Controls.Add(this.LogInDugme);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSifraGlavna);
            this.panel2.Controls.Add(this.txtKorisnickoGlavna);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(293, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 481);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Izlaz
            // 
            this.Izlaz.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Izlaz.ForeColor = System.Drawing.Color.Crimson;
            this.Izlaz.Location = new System.Drawing.Point(766, 1);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(32, 33);
            this.Izlaz.TabIndex = 9;
            this.Izlaz.Text = "X";
            this.Izlaz.UseVisualStyleBackColor = false;
            this.Izlaz.Click += new System.EventHandler(this.Izlaz_Click);
            this.Izlaz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Izlaz_KeyDown);
            // 
            // AdminLbl
            // 
            this.AdminLbl.AutoSize = true;
            this.AdminLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLbl.ForeColor = System.Drawing.Color.White;
            this.AdminLbl.Location = new System.Drawing.Point(177, 416);
            this.AdminLbl.Name = "AdminLbl";
            this.AdminLbl.Size = new System.Drawing.Size(137, 23);
            this.AdminLbl.TabIndex = 8;
            this.AdminLbl.Text = "Administrator";
            this.AdminLbl.Click += new System.EventHandler(this.AdminLbl_Click);
            // 
            // LogInDugme
            // 
            this.LogInDugme.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LogInDugme.ForeColor = System.Drawing.Color.Black;
            this.LogInDugme.Location = new System.Drawing.Point(166, 353);
            this.LogInDugme.Name = "LogInDugme";
            this.LogInDugme.Size = new System.Drawing.Size(156, 42);
            this.LogInDugme.TabIndex = 7;
            this.LogInDugme.Text = "LogIn";
            this.LogInDugme.UseVisualStyleBackColor = false;
            this.LogInDugme.Click += new System.EventHandler(this.LogInDugme_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Šifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Korisničko Ime";
            // 
            // txtSifraGlavna
            // 
            this.txtSifraGlavna.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSifraGlavna.Location = new System.Drawing.Point(190, 290);
            this.txtSifraGlavna.Name = "txtSifraGlavna";
            this.txtSifraGlavna.PasswordChar = '*';
            this.txtSifraGlavna.Size = new System.Drawing.Size(254, 32);
            this.txtSifraGlavna.TabIndex = 4;
            // 
            // txtKorisnickoGlavna
            // 
            this.txtKorisnickoGlavna.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtKorisnickoGlavna.Location = new System.Drawing.Point(190, 238);
            this.txtKorisnickoGlavna.Name = "txtKorisnickoGlavna";
            this.txtKorisnickoGlavna.Size = new System.Drawing.Size(254, 32);
            this.txtKorisnickoGlavna.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pozorište";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.Izlaz);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AdminLbl;
        private System.Windows.Forms.Button LogInDugme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifraGlavna;
        private System.Windows.Forms.TextBox txtKorisnickoGlavna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Izlaz;
    }
}