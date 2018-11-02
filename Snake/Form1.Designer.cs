namespace Snake
{
    partial class Formulář
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
            this.pbPozadi = new System.Windows.Forms.PictureBox();
            this.lblTextSkore = new System.Windows.Forms.Label();
            this.lblKonecHry = new System.Windows.Forms.Label();
            this.lblSkore = new System.Windows.Forms.Label();
            this.herniCasovac = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozadi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPozadi
            // 
            this.pbPozadi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbPozadi.Location = new System.Drawing.Point(12, 27);
            this.pbPozadi.Name = "pbPozadi";
            this.pbPozadi.Size = new System.Drawing.Size(542, 515);
            this.pbPozadi.TabIndex = 0;
            this.pbPozadi.TabStop = false;
            this.pbPozadi.Click += new System.EventHandler(this.pbPozadi_Click);
            this.pbPozadi.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPozadi_Paint);
            // 
            // lblTextSkore
            // 
            this.lblTextSkore.AutoSize = true;
            this.lblTextSkore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTextSkore.Location = new System.Drawing.Point(585, 38);
            this.lblTextSkore.Name = "lblTextSkore";
            this.lblTextSkore.Size = new System.Drawing.Size(109, 37);
            this.lblTextSkore.TabIndex = 1;
            this.lblTextSkore.Text = "Skóre:";
            // 
            // lblKonecHry
            // 
            this.lblKonecHry.AutoSize = true;
            this.lblKonecHry.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKonecHry.Location = new System.Drawing.Point(12, 38);
            this.lblKonecHry.Name = "lblKonecHry";
            this.lblKonecHry.Size = new System.Drawing.Size(160, 37);
            this.lblKonecHry.TabIndex = 2;
            this.lblKonecHry.Text = "Konec hry";
            // 
            // lblSkore
            // 
            this.lblSkore.AutoSize = true;
            this.lblSkore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSkore.Location = new System.Drawing.Point(700, 38);
            this.lblSkore.Name = "lblSkore";
            this.lblSkore.Size = new System.Drawing.Size(0, 37);
            this.lblSkore.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hraToolStripMenuItem
            // 
            this.hraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nápovědaToolStripMenuItem});
            this.hraToolStripMenuItem.Name = "hraToolStripMenuItem";
            this.hraToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.hraToolStripMenuItem.Text = "Hra";
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            this.nápovědaToolStripMenuItem.Click += new System.EventHandler(this.nápovědaToolStripMenuItem_Click);
            // 
            // Formulář
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 554);
            this.Controls.Add(this.lblSkore);
            this.Controls.Add(this.lblKonecHry);
            this.Controls.Add(this.lblTextSkore);
            this.Controls.Add(this.pbPozadi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formulář";
            this.Text = "Had";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPozadi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPozadi;
        private System.Windows.Forms.Label lblTextSkore;
        private System.Windows.Forms.Label lblKonecHry;
        private System.Windows.Forms.Label lblSkore;
        private System.Windows.Forms.Timer herniCasovac;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nápovědaToolStripMenuItem;
    }
}

