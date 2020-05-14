namespace ImageEditing
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaImmagineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Matita = new System.Windows.Forms.PictureBox();
            this.Pennarello = new System.Windows.Forms.PictureBox();
            this.Riempi = new System.Windows.Forms.PictureBox();
            this.Spray = new System.Windows.Forms.PictureBox();
            this.Ritaglia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pennarello)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Riempi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ritaglia)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(715, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1073, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caricaImmagineToolStripMenuItem,
            this.salvaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // caricaImmagineToolStripMenuItem
            // 
            this.caricaImmagineToolStripMenuItem.Name = "caricaImmagineToolStripMenuItem";
            this.caricaImmagineToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.caricaImmagineToolStripMenuItem.Text = "Carica";
            this.caricaImmagineToolStripMenuItem.Click += new System.EventHandler(this.caricaImmagineToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.salvaToolStripMenuItem.Text = "Salva";
            // 
            // Matita
            // 
            this.Matita.Image = ((System.Drawing.Image)(resources.GetObject("Matita.Image")));
            this.Matita.Location = new System.Drawing.Point(0, 27);
            this.Matita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Matita.Name = "Matita";
            this.Matita.Size = new System.Drawing.Size(43, 41);
            this.Matita.TabIndex = 2;
            this.Matita.TabStop = false;
            this.Matita.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Pennarello
            // 
            this.Pennarello.BackColor = System.Drawing.Color.White;
            this.Pennarello.Location = new System.Drawing.Point(47, 27);
            this.Pennarello.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pennarello.Name = "Pennarello";
            this.Pennarello.Size = new System.Drawing.Size(43, 41);
            this.Pennarello.TabIndex = 3;
            this.Pennarello.TabStop = false;
            // 
            // Riempi
            // 
            this.Riempi.BackColor = System.Drawing.Color.White;
            this.Riempi.Location = new System.Drawing.Point(93, 27);
            this.Riempi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Riempi.Name = "Riempi";
            this.Riempi.Size = new System.Drawing.Size(43, 41);
            this.Riempi.TabIndex = 4;
            this.Riempi.TabStop = false;
            // 
            // Spray
            // 
            this.Spray.BackColor = System.Drawing.Color.White;
            this.Spray.Location = new System.Drawing.Point(140, 27);
            this.Spray.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Spray.Name = "Spray";
            this.Spray.Size = new System.Drawing.Size(43, 41);
            this.Spray.TabIndex = 5;
            this.Spray.TabStop = false;
            // 
            // Ritaglia
            // 
            this.Ritaglia.BackColor = System.Drawing.Color.White;
            this.Ritaglia.Location = new System.Drawing.Point(187, 27);
            this.Ritaglia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ritaglia.Name = "Ritaglia";
            this.Ritaglia.Size = new System.Drawing.Size(43, 41);
            this.Ritaglia.TabIndex = 6;
            this.Ritaglia.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1073, 648);
            this.Controls.Add(this.Ritaglia);
            this.Controls.Add(this.Spray);
            this.Controls.Add(this.Riempi);
            this.Controls.Add(this.Pennarello);
            this.Controls.Add(this.Matita);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pennarello)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Riempi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ritaglia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caricaImmagineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.PictureBox Matita;
        private System.Windows.Forms.PictureBox Pennarello;
        private System.Windows.Forms.PictureBox Riempi;
        private System.Windows.Forms.PictureBox Spray;
        private System.Windows.Forms.PictureBox Ritaglia;
    }
}

