
namespace RepertoarPozorista
{
    partial class Glavna
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
            this.label1 = new System.Windows.Forms.Label();
            this.linijaUcitaj = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcentiLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repertoar Pozorišta";
            // 
            // linijaUcitaj
            // 
            this.linijaUcitaj.BackColor = System.Drawing.Color.Black;
            this.linijaUcitaj.ForeColor = System.Drawing.Color.Black;
            this.linijaUcitaj.Location = new System.Drawing.Point(12, 448);
            this.linijaUcitaj.Name = "linijaUcitaj";
            this.linijaUcitaj.Size = new System.Drawing.Size(1031, 10);
            this.linijaUcitaj.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Učitavanje...";
            // 
            // ProcentiLbl
            // 
            this.ProcentiLbl.AutoSize = true;
            this.ProcentiLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcentiLbl.ForeColor = System.Drawing.Color.White;
            this.ProcentiLbl.Location = new System.Drawing.Point(148, 415);
            this.ProcentiLbl.Name = "ProcentiLbl";
            this.ProcentiLbl.Size = new System.Drawing.Size(32, 30);
            this.ProcentiLbl.TabIndex = 4;
            this.ProcentiLbl.Text = "%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(427, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 226);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Glavna
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1056, 470);
            this.Controls.Add(this.ProcentiLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linijaUcitaj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Glavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Glavna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar linijaUcitaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProcentiLbl;
        private System.Windows.Forms.Timer timer1;
    }
}

