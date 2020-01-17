namespace Klijent
{
    partial class FrmOcenjivanje
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOcena = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.btnDodajOcenu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOcene = new System.Windows.Forms.DataGridView();
            this.cmbPsi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacuvajOcene = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcene)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ocena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum ocenjivanja:";
            // 
            // txtOcena
            // 
            this.txtOcena.Location = new System.Drawing.Point(82, 59);
            this.txtOcena.Name = "txtOcena";
            this.txtOcena.Size = new System.Drawing.Size(62, 20);
            this.txtOcena.TabIndex = 7;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(279, 59);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(185, 20);
            this.txtDatum.TabIndex = 8;
            // 
            // btnDodajOcenu
            // 
            this.btnDodajOcenu.Location = new System.Drawing.Point(279, 102);
            this.btnDodajOcenu.Name = "btnDodajOcenu";
            this.btnDodajOcenu.Size = new System.Drawing.Size(185, 26);
            this.btnDodajOcenu.TabIndex = 10;
            this.btnDodajOcenu.Text = "Dodaj ocenu";
            this.btnDodajOcenu.UseVisualStyleBackColor = true;
            this.btnDodajOcenu.Click += new System.EventHandler(this.btnDodajOcenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOcene);
            this.groupBox1.Controls.Add(this.cmbPsi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOcena);
            this.groupBox1.Controls.Add(this.btnDodajOcenu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDatum);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 407);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos ocena";
            // 
            // dgvOcene
            // 
            this.dgvOcene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcene.Location = new System.Drawing.Point(12, 156);
            this.dgvOcene.Name = "dgvOcene";
            this.dgvOcene.Size = new System.Drawing.Size(452, 233);
            this.dgvOcene.TabIndex = 13;
            // 
            // cmbPsi
            // 
            this.cmbPsi.FormattingEnabled = true;
            this.cmbPsi.Location = new System.Drawing.Point(82, 21);
            this.cmbPsi.Name = "cmbPsi";
            this.cmbPsi.Size = new System.Drawing.Size(179, 21);
            this.cmbPsi.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Odaberi psa:";
            // 
            // btnSacuvajOcene
            // 
            this.btnSacuvajOcene.Location = new System.Drawing.Point(328, 462);
            this.btnSacuvajOcene.Name = "btnSacuvajOcene";
            this.btnSacuvajOcene.Size = new System.Drawing.Size(188, 23);
            this.btnSacuvajOcene.TabIndex = 13;
            this.btnSacuvajOcene.Text = "SACUVAJ OCENE";
            this.btnSacuvajOcene.UseVisualStyleBackColor = true;
            this.btnSacuvajOcene.Click += new System.EventHandler(this.btnSacuvajOcene_Click);
            // 
            // FrmOcenjivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 515);
            this.Controls.Add(this.btnSacuvajOcene);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOcenjivanje";
            this.Text = "Unos ocena";
            this.Load += new System.EventHandler(this.FrmOcenjivanje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOcena;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button btnDodajOcenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOcene;
        private System.Windows.Forms.ComboBox cmbPsi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvajOcene;
    }
}