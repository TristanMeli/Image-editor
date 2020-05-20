namespace Image_Editor_PCTO
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Salva = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Zoom = new System.Windows.Forms.PictureBox();
            this.Testo = new System.Windows.Forms.PictureBox();
            this.Sfondo = new System.Windows.Forms.PictureBox();
            this.Gomma = new System.Windows.Forms.PictureBox();
            this.Matita = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Salva.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Testo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sfondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gomma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matita)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 327);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "taglia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "ruota";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ruota l\'immagine di quanti gradi?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(646, 269);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "90°";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(694, 269);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "180°";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(746, 269);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "270°";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem,
            this.caricaToolStripMenuItem,
            this.salvaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.nuovoToolStripMenuItem.Text = "Nuovo";
            // 
            // caricaToolStripMenuItem
            // 
            this.caricaToolStripMenuItem.Name = "caricaToolStripMenuItem";
            this.caricaToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.caricaToolStripMenuItem.Text = "Carica";
            this.caricaToolStripMenuItem.Click += new System.EventHandler(this.caricaToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.salvaToolStripMenuItem.Text = "Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // Salva
            // 
            this.Salva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Salva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Salva.Controls.Add(this.button3);
            this.Salva.Controls.Add(this.textBox5);
            this.Salva.Controls.Add(this.label7);
            this.Salva.Controls.Add(this.label6);
            this.Salva.Location = new System.Drawing.Point(10, 346);
            this.Salva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Salva.Name = "Salva";
            this.Salva.Size = new System.Drawing.Size(272, 175);
            this.Salva.TabIndex = 16;
            this.Salva.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(30, 103);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "SALVA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(104, 59);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(126, 26);
            this.textBox5.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "SALVA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.Zoom);
            this.panel1.Controls.Add(this.Testo);
            this.panel1.Controls.Add(this.Sfondo);
            this.panel1.Controls.Add(this.Gomma);
            this.panel1.Controls.Add(this.Matita);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 23);
            this.panel1.TabIndex = 17;
            // 
            // Zoom
            // 
            this.Zoom.Image = ((System.Drawing.Image)(resources.GetObject("Zoom.Image")));
            this.Zoom.Location = new System.Drawing.Point(82, 2);
            this.Zoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(16, 17);
            this.Zoom.TabIndex = 4;
            this.Zoom.TabStop = false;
            this.Zoom.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // Testo
            // 
            this.Testo.Image = ((System.Drawing.Image)(resources.GetObject("Testo.Image")));
            this.Testo.Location = new System.Drawing.Point(63, 2);
            this.Testo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Testo.Name = "Testo";
            this.Testo.Size = new System.Drawing.Size(16, 17);
            this.Testo.TabIndex = 3;
            this.Testo.TabStop = false;
            this.Testo.Click += new System.EventHandler(this.Testo_Click);
            // 
            // Sfondo
            // 
            this.Sfondo.Image = ((System.Drawing.Image)(resources.GetObject("Sfondo.Image")));
            this.Sfondo.Location = new System.Drawing.Point(44, 2);
            this.Sfondo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sfondo.Name = "Sfondo";
            this.Sfondo.Size = new System.Drawing.Size(16, 17);
            this.Sfondo.TabIndex = 2;
            this.Sfondo.TabStop = false;
            this.Sfondo.Click += new System.EventHandler(this.Sfondo_Click);
            // 
            // Gomma
            // 
            this.Gomma.Image = ((System.Drawing.Image)(resources.GetObject("Gomma.Image")));
            this.Gomma.Location = new System.Drawing.Point(25, 2);
            this.Gomma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gomma.Name = "Gomma";
            this.Gomma.Size = new System.Drawing.Size(16, 17);
            this.Gomma.TabIndex = 1;
            this.Gomma.TabStop = false;
            this.Gomma.Click += new System.EventHandler(this.Gomma_Click);
            // 
            // Matita
            // 
            this.Matita.Image = ((System.Drawing.Image)(resources.GetObject("Matita.Image")));
            this.Matita.Location = new System.Drawing.Point(6, 2);
            this.Matita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Matita.Name = "Matita";
            this.Matita.Size = new System.Drawing.Size(16, 17);
            this.Matita.TabIndex = 0;
            this.Matita.TabStop = false;
            this.Matita.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(628, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 60);
            this.button4.TabIndex = 18;
            this.button4.Text = "selezione l\'area da tagliare";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ciaoooo";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(872, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Salva);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Salva.ResumeLayout(false);
            this.Salva.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Testo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sfondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gomma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.Panel Salva;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Testo;
        private System.Windows.Forms.PictureBox Sfondo;
        private System.Windows.Forms.PictureBox Gomma;
        private System.Windows.Forms.PictureBox Matita;
        private System.Windows.Forms.PictureBox Zoom;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

