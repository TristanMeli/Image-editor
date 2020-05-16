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
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsLinearCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hueModifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saturationAdjustingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessAdjustingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastAdjustingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSLFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yCbCrLinearCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yCbCrFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdBinarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floydSteinbergDitheringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderedDitheringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceEdgeDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homogenityEdgeDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelEdgeDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centeredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Matita = new System.Windows.Forms.PictureBox();
            this.Riempi = new System.Windows.Forms.PictureBox();
            this.Gomma = new System.Windows.Forms.PictureBox();
            this.Testo = new System.Windows.Forms.PictureBox();
            this.Zoom = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Panel_Salva = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Riempi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gomma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Testo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).BeginInit();
            this.Panel_Salva.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 410);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.sizeModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(913, 26);
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
            this.caricaImmagineToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.caricaImmagineToolStripMenuItem.Text = "Carica";
            this.caricaImmagineToolStripMenuItem.Click += new System.EventHandler(this.caricaImmagineToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.salvaToolStripMenuItem.Text = "Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.rotateChannelToolStripMenuItem,
            this.colorFilteringToolStripMenuItem,
            this.levelsLinearCorrectionToolStripMenuItem,
            this.hueModifierToolStripMenuItem,
            this.saturationAdjustingToolStripMenuItem,
            this.brightnessAdjustingToolStripMenuItem,
            this.contrastAdjustingToolStripMenuItem,
            this.hSLFilteringToolStripMenuItem,
            this.yCbCrLinearCorrectionToolStripMenuItem,
            this.yCbCrFilteringToolStripMenuItem,
            this.thresholdBinarizationToolStripMenuItem,
            this.floydSteinbergDitheringToolStripMenuItem,
            this.orderedDitheringToolStripMenuItem,
            this.convolutionToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.differenceEdgeDetectorToolStripMenuItem,
            this.homogenityEdgeDetectorToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sobelEdgeDetectorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.jitterToolStripMenuItem});
            this.filtersToolStripMenuItem.Enabled = false;
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.filtersToolStripMenuItem.Text = "&Filters";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.noneToolStripMenuItem.Text = "&None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.grayscaleToolStripMenuItem.Text = "&Grayscale";
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.sepiaToolStripMenuItem.Text = "&Sepia";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.invertToolStripMenuItem.Text = "&Invert";
            // 
            // rotateChannelToolStripMenuItem
            // 
            this.rotateChannelToolStripMenuItem.Name = "rotateChannelToolStripMenuItem";
            this.rotateChannelToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.rotateChannelToolStripMenuItem.Text = "&Rotate channel";
            // 
            // colorFilteringToolStripMenuItem
            // 
            this.colorFilteringToolStripMenuItem.Name = "colorFilteringToolStripMenuItem";
            this.colorFilteringToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.colorFilteringToolStripMenuItem.Text = "&Color filtering";
            // 
            // levelsLinearCorrectionToolStripMenuItem
            // 
            this.levelsLinearCorrectionToolStripMenuItem.Name = "levelsLinearCorrectionToolStripMenuItem";
            this.levelsLinearCorrectionToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.levelsLinearCorrectionToolStripMenuItem.Text = "&Levels linear correction";
            // 
            // hueModifierToolStripMenuItem
            // 
            this.hueModifierToolStripMenuItem.Name = "hueModifierToolStripMenuItem";
            this.hueModifierToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.hueModifierToolStripMenuItem.Text = "&Hue modifier";
            // 
            // saturationAdjustingToolStripMenuItem
            // 
            this.saturationAdjustingToolStripMenuItem.Name = "saturationAdjustingToolStripMenuItem";
            this.saturationAdjustingToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.saturationAdjustingToolStripMenuItem.Text = "Saturation adjusting";
            // 
            // brightnessAdjustingToolStripMenuItem
            // 
            this.brightnessAdjustingToolStripMenuItem.Name = "brightnessAdjustingToolStripMenuItem";
            this.brightnessAdjustingToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.brightnessAdjustingToolStripMenuItem.Text = "Brightness adjusting";
            // 
            // contrastAdjustingToolStripMenuItem
            // 
            this.contrastAdjustingToolStripMenuItem.Name = "contrastAdjustingToolStripMenuItem";
            this.contrastAdjustingToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.contrastAdjustingToolStripMenuItem.Text = "Contrast adjusting";
            // 
            // hSLFilteringToolStripMenuItem
            // 
            this.hSLFilteringToolStripMenuItem.Name = "hSLFilteringToolStripMenuItem";
            this.hSLFilteringToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.hSLFilteringToolStripMenuItem.Text = "HSL filtering";
            // 
            // yCbCrLinearCorrectionToolStripMenuItem
            // 
            this.yCbCrLinearCorrectionToolStripMenuItem.Name = "yCbCrLinearCorrectionToolStripMenuItem";
            this.yCbCrLinearCorrectionToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.yCbCrLinearCorrectionToolStripMenuItem.Text = "YCbCr linear correction";
            // 
            // yCbCrFilteringToolStripMenuItem
            // 
            this.yCbCrFilteringToolStripMenuItem.Name = "yCbCrFilteringToolStripMenuItem";
            this.yCbCrFilteringToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.yCbCrFilteringToolStripMenuItem.Text = "YCbCr filtering";
            // 
            // thresholdBinarizationToolStripMenuItem
            // 
            this.thresholdBinarizationToolStripMenuItem.Name = "thresholdBinarizationToolStripMenuItem";
            this.thresholdBinarizationToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.thresholdBinarizationToolStripMenuItem.Text = "Threshold binarization";
            // 
            // floydSteinbergDitheringToolStripMenuItem
            // 
            this.floydSteinbergDitheringToolStripMenuItem.Name = "floydSteinbergDitheringToolStripMenuItem";
            this.floydSteinbergDitheringToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.floydSteinbergDitheringToolStripMenuItem.Text = "Floyd-Steinberg dithering";
            // 
            // orderedDitheringToolStripMenuItem
            // 
            this.orderedDitheringToolStripMenuItem.Name = "orderedDitheringToolStripMenuItem";
            this.orderedDitheringToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.orderedDitheringToolStripMenuItem.Text = "Ordered dithering";
            // 
            // convolutionToolStripMenuItem
            // 
            this.convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            this.convolutionToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.convolutionToolStripMenuItem.Text = "Convolution";
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian blur";
            // 
            // differenceEdgeDetectorToolStripMenuItem
            // 
            this.differenceEdgeDetectorToolStripMenuItem.Name = "differenceEdgeDetectorToolStripMenuItem";
            this.differenceEdgeDetectorToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.differenceEdgeDetectorToolStripMenuItem.Text = "Difference edge detector";
            // 
            // homogenityEdgeDetectorToolStripMenuItem
            // 
            this.homogenityEdgeDetectorToolStripMenuItem.Name = "homogenityEdgeDetectorToolStripMenuItem";
            this.homogenityEdgeDetectorToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.homogenityEdgeDetectorToolStripMenuItem.Text = "Homogenity edge detector";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(265, 26);
            this.toolStripMenuItem2.Text = "Texture";
            // 
            // sobelEdgeDetectorToolStripMenuItem
            // 
            this.sobelEdgeDetectorToolStripMenuItem.Name = "sobelEdgeDetectorToolStripMenuItem";
            this.sobelEdgeDetectorToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.sobelEdgeDetectorToolStripMenuItem.Text = "Sobel edge detector";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(265, 26);
            this.toolStripMenuItem1.Text = "Oil Painting";
            // 
            // jitterToolStripMenuItem
            // 
            this.jitterToolStripMenuItem.Name = "jitterToolStripMenuItem";
            this.jitterToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.jitterToolStripMenuItem.Text = "Jitter";
            // 
            // sizeModeToolStripMenuItem
            // 
            this.sizeModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.centeredToolStripMenuItem,
            this.stretchedToolStripMenuItem});
            this.sizeModeToolStripMenuItem.Name = "sizeModeToolStripMenuItem";
            this.sizeModeToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.sizeModeToolStripMenuItem.Text = "Size Mode";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // centeredToolStripMenuItem
            // 
            this.centeredToolStripMenuItem.Name = "centeredToolStripMenuItem";
            this.centeredToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.centeredToolStripMenuItem.Text = "Centered";
            this.centeredToolStripMenuItem.Click += new System.EventHandler(this.centeredToolStripMenuItem_Click);
            // 
            // stretchedToolStripMenuItem
            // 
            this.stretchedToolStripMenuItem.Name = "stretchedToolStripMenuItem";
            this.stretchedToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.stretchedToolStripMenuItem.Text = "Stretched";
            this.stretchedToolStripMenuItem.Click += new System.EventHandler(this.stretchedToolStripMenuItem_Click);
            // 
            // Matita
            // 
            this.Matita.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Matita.Image = ((System.Drawing.Image)(resources.GetObject("Matita.Image")));
            this.Matita.Location = new System.Drawing.Point(0, 27);
            this.Matita.Name = "Matita";
            this.Matita.Size = new System.Drawing.Size(43, 40);
            this.Matita.TabIndex = 2;
            this.Matita.TabStop = false;
            this.Matita.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Riempi
            // 
            this.Riempi.BackColor = System.Drawing.Color.White;
            this.Riempi.Image = ((System.Drawing.Image)(resources.GetObject("Riempi.Image")));
            this.Riempi.Location = new System.Drawing.Point(47, 27);
            this.Riempi.Name = "Riempi";
            this.Riempi.Size = new System.Drawing.Size(43, 40);
            this.Riempi.TabIndex = 3;
            this.Riempi.TabStop = false;
            this.Riempi.Click += new System.EventHandler(this.Riempi_Click_1);
            // 
            // Gomma
            // 
            this.Gomma.BackColor = System.Drawing.Color.White;
            this.Gomma.Image = ((System.Drawing.Image)(resources.GetObject("Gomma.Image")));
            this.Gomma.Location = new System.Drawing.Point(93, 27);
            this.Gomma.Name = "Gomma";
            this.Gomma.Size = new System.Drawing.Size(43, 40);
            this.Gomma.TabIndex = 4;
            this.Gomma.TabStop = false;
            this.Gomma.Click += new System.EventHandler(this.Riempi_Click);
            // 
            // Testo
            // 
            this.Testo.BackColor = System.Drawing.Color.White;
            this.Testo.Image = ((System.Drawing.Image)(resources.GetObject("Testo.Image")));
            this.Testo.Location = new System.Drawing.Point(140, 27);
            this.Testo.Name = "Testo";
            this.Testo.Size = new System.Drawing.Size(43, 40);
            this.Testo.TabIndex = 5;
            this.Testo.TabStop = false;
            this.Testo.Click += new System.EventHandler(this.Testo_Click);
            // 
            // Zoom
            // 
            this.Zoom.BackColor = System.Drawing.Color.White;
            this.Zoom.Image = ((System.Drawing.Image)(resources.GetObject("Zoom.Image")));
            this.Zoom.InitialImage = ((System.Drawing.Image)(resources.GetObject("Zoom.InitialImage")));
            this.Zoom.Location = new System.Drawing.Point(187, 27);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(43, 40);
            this.Zoom.TabIndex = 6;
            this.Zoom.TabStop = false;
            this.Zoom.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 72);
            this.button1.TabIndex = 7;
            this.button1.Text = "taglia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(745, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "taglia";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(796, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 22);
            this.textBox1.TabIndex = 9;
            // 
            // Panel_Salva
            // 
            this.Panel_Salva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_Salva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Salva.Controls.Add(this.button3);
            this.Panel_Salva.Controls.Add(this.button2);
            this.Panel_Salva.Controls.Add(this.textBox3);
            this.Panel_Salva.Controls.Add(this.label3);
            this.Panel_Salva.Controls.Add(this.textBox2);
            this.Panel_Salva.Controls.Add(this.label2);
            this.Panel_Salva.Controls.Add(this.label);
            this.Panel_Salva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel_Salva.Location = new System.Drawing.Point(2000, 303);
            this.Panel_Salva.Name = "Panel_Salva";
            this.Panel_Salva.Size = new System.Drawing.Size(365, 227);
            this.Panel_Salva.TabIndex = 10;
            this.Panel_Salva.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 68);
            this.button3.TabIndex = 6;
            this.button3.Text = "Salva";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(156, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 36);
            this.textBox3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Percorso";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(156, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 36);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(3, -1);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(103, 39);
            this.label.TabIndex = 0;
            this.label.Text = "Salva";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(913, 479);
            this.Controls.Add(this.Panel_Salva);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Zoom);
            this.Controls.Add(this.Testo);
            this.Controls.Add(this.Gomma);
            this.Controls.Add(this.Riempi);
            this.Controls.Add(this.Matita);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Riempi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gomma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Testo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).EndInit();
            this.Panel_Salva.ResumeLayout(false);
            this.Panel_Salva.PerformLayout();
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
        private System.Windows.Forms.PictureBox Riempi;
        private System.Windows.Forms.PictureBox Gomma;
        private System.Windows.Forms.PictureBox Testo;
        private System.Windows.Forms.PictureBox Zoom;
        private System.Windows.Forms.ToolStripMenuItem sizeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centeredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchedToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelsLinearCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hueModifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saturationAdjustingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessAdjustingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastAdjustingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSLFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yCbCrLinearCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yCbCrFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdBinarizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floydSteinbergDitheringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderedDitheringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem differenceEdgeDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homogenityEdgeDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sobelEdgeDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jitterToolStripMenuItem;
        private System.Windows.Forms.Panel Panel_Salva;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button3;
    }
}

