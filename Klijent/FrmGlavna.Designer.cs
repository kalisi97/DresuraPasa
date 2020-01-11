namespace Klijent
{
    partial class FrmGlavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.instruktoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucesniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogPasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaBrisanjePasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurseviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogKursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaKursevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instruktoriToolStripMenuItem,
            this.ucesniciToolStripMenuItem,
            this.kurseviToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Instruktori";
            // 
            // instruktoriToolStripMenuItem
            // 
            this.instruktoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.pretragaToolStripMenuItem});
            this.instruktoriToolStripMenuItem.Name = "instruktoriToolStripMenuItem";
            this.instruktoriToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.instruktoriToolStripMenuItem.Text = "Instruktori";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.unosToolStripMenuItem.Text = "Unos";
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.unosToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga/Izmena/Brisanje";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // ucesniciToolStripMenuItem
            // 
            this.ucesniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogPasaToolStripMenuItem,
            this.pretragaBrisanjePasaToolStripMenuItem});
            this.ucesniciToolStripMenuItem.Name = "ucesniciToolStripMenuItem";
            this.ucesniciToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.ucesniciToolStripMenuItem.Text = "Psi";
            // 
            // unosNovogPasaToolStripMenuItem
            // 
            this.unosNovogPasaToolStripMenuItem.Name = "unosNovogPasaToolStripMenuItem";
            this.unosNovogPasaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unosNovogPasaToolStripMenuItem.Text = "Unos";
            this.unosNovogPasaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogPasaToolStripMenuItem_Click);
            // 
            // pretragaBrisanjePasaToolStripMenuItem
            // 
            this.pretragaBrisanjePasaToolStripMenuItem.Name = "pretragaBrisanjePasaToolStripMenuItem";
            this.pretragaBrisanjePasaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretragaBrisanjePasaToolStripMenuItem.Text = "Pretraga/Brisanje";
            this.pretragaBrisanjePasaToolStripMenuItem.Click += new System.EventHandler(this.pretragaBrisanjePasaToolStripMenuItem_Click);
            // 
            // kurseviToolStripMenuItem
            // 
            this.kurseviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogKursaToolStripMenuItem,
            this.pretragaKursevaToolStripMenuItem});
            this.kurseviToolStripMenuItem.Name = "kurseviToolStripMenuItem";
            this.kurseviToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.kurseviToolStripMenuItem.Text = "Kursevi";
            // 
            // unosNovogKursaToolStripMenuItem
            // 
            this.unosNovogKursaToolStripMenuItem.Name = "unosNovogKursaToolStripMenuItem";
            this.unosNovogKursaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.unosNovogKursaToolStripMenuItem.Text = "Unos novog kursa";
            this.unosNovogKursaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogKursaToolStripMenuItem_Click);
            // 
            // pretragaKursevaToolStripMenuItem
            // 
            this.pretragaKursevaToolStripMenuItem.Name = "pretragaKursevaToolStripMenuItem";
            this.pretragaKursevaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pretragaKursevaToolStripMenuItem.Text = "Pretraga kurseva";
            this.pretragaKursevaToolStripMenuItem.Click += new System.EventHandler(this.pretragaKursevaToolStripMenuItem_Click);
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 191);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGlavna";
            this.Text = "Glavna forma";
            this.Load += new System.EventHandler(this.FrmGlavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem instruktoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ucesniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurseviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogPasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaBrisanjePasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogKursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaKursevaToolStripMenuItem;
    }
}