namespace Klijent
{
    partial class FrmPretragaKursevaZaOcenjivanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgvKursevi = new System.Windows.Forms.DataGridView();
            this.btnOcena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kriterijum za pretragu:";
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Location = new System.Drawing.Point(151, 19);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(220, 20);
            this.txtKriterijum.TabIndex = 1;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(398, 17);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(85, 23);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Pretraži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvKursevi
            // 
            this.dgvKursevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKursevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKursevi.Location = new System.Drawing.Point(13, 58);
            this.dgvKursevi.Name = "dgvKursevi";
            this.dgvKursevi.Size = new System.Drawing.Size(470, 313);
            this.dgvKursevi.TabIndex = 3;
            // 
            // btnOcena
            // 
            this.btnOcena.Location = new System.Drawing.Point(356, 399);
            this.btnOcena.Name = "btnOcena";
            this.btnOcena.Size = new System.Drawing.Size(127, 39);
            this.btnOcena.TabIndex = 4;
            this.btnOcena.Text = "Dodaj ocene";
            this.btnOcena.UseVisualStyleBackColor = true;
            this.btnOcena.Click += new System.EventHandler(this.btnOcena_Click);
            // 
            // FrmPretragaKursevaZaOcenjivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.btnOcena);
            this.Controls.Add(this.dgvKursevi);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtKriterijum);
            this.Controls.Add(this.label1);
            this.Name = "FrmPretragaKursevaZaOcenjivanje";
            this.Text = "Pretraga kurseva za ocenjivanje";
            this.Load += new System.EventHandler(this.FrmPretragaPasaZaOcenjivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridView dgvKursevi;
        private System.Windows.Forms.Button btnOcena;
    }
}