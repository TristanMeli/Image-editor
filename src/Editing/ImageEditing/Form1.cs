// Image Processing filters demo
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2006-2011
// contacts@aforgenet.com
//
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using System.ComponentModel;
using Image = System.Drawing.Image;
using Point = System.Drawing.Point;
using System.Drawing.Drawing2D;

namespace ImageEditing
{
    public partial class ImageEditor : Form
    {
        int R = 0;
        int G = 0;
        int B = 0;
        bool nuovo = false;
        private System.Drawing.Bitmap sourceImage;
        private System.Drawing.Bitmap filteredImage;
        private string imagePath = "";
        Bitmap DrawArea;
        bool smatita = false;
        bool sgomma = false;

        Point lastPoint = Point.Empty;

        bool isMouseDown = new Boolean();
        //int x = 150;

        public ImageEditor()
        {
            InitializeComponent();

            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);

            pictureBox1.Image = DrawArea;
            Panel_Salva.Location = new System.Drawing.Point(371, 232);        
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            g.Clear(Color.Transparent);
            g.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        void LoadImageFromDialog()
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Scegli l'immagine";
            dlg.Filter = "all files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imagePath = dlg.FileName;
                LoadImage();
                if (!CheckImageIntegrity())
                {
                    pictureBox1.Image = null;
                    MessageBox.Show("L'applicazione supporta solo immagini a colori", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void LoadImage()
        {
            pictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
            sourceImage = (Bitmap)Bitmap.FromFile(imagePath);
        }

        bool CheckImageIntegrity()
        {
            if ((sourceImage.PixelFormat == PixelFormat.Format16bppGrayScale) ||
                        (Bitmap.GetPixelFormatSize(sourceImage.PixelFormat) > 32))
            {
                sourceImage.Dispose();
                sourceImage = null;
                return false;
            }
            else
            {
                // make sure the image has 24 bpp format
                if (sourceImage.PixelFormat != PixelFormat.Format24bppRgb)
                {
                    Bitmap temp = AForge.Imaging.Image.Clone(sourceImage, PixelFormat.Format24bppRgb);
                    sourceImage.Dispose();
                    sourceImage = temp;
                }
            }
            return true;
        }

        private void caricaImmagineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImageFromDialog();
            nuovo = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Zoom.BorderStyle = default;
            Matita.BorderStyle = BorderStyle.FixedSingle;
            Gomma.BorderStyle = default;
            Testo.BorderStyle = default;
            Riempi.BorderStyle = default;

            bool sgomma = false;
            bool smatita = true;

            R = 0;
            G = 0;
            B = 0;

            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";

            //Graphics g;
            //g = Graphics.FromImage(DrawArea);

            //Pen mypen = new Pen(Color.Black);

            //g.DrawLine(mypen, 0, 0, 200, x);

            //pictureBox1.Image = DrawArea;

            //g.Dispose();
            //x++;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void centeredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void stretchedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Salva.Visible = true;
            Panel_Salva.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome = textBox2.Text;
            textBox2.Clear();
            if (File.Exists(nome + "Png"))
            {
                MessageBox.Show("Nome gia usato");
                Panel_Salva.Visible = false;
                return;
            }
            pictureBox1.Image.Save(nome + ".Png", ImageFormat.Png);
            MessageBox.Show("Immagine salvata");
            Panel_Salva.Visible = false;
        }

        private void Riempi_Click(object sender, EventArgs e)
        {
            bool sgomma = true;
            bool smatita = false;

            R = 255;
            G = 255;
            B = 255;

            textBox7.Text = "255";
            textBox8.Text = "255";
            textBox9.Text = "255";
            Zoom.BorderStyle = default;
            Matita.BorderStyle = default;
            Gomma.BorderStyle = BorderStyle.FixedSingle;
            Testo.BorderStyle = default;
            Riempi.BorderStyle = default;
        }

        private void Zoom_Click(object sender, EventArgs e)
        {
            Zoom.BorderStyle = BorderStyle.FixedSingle;
            Matita.BorderStyle = default;
            Gomma.BorderStyle = default;
            Testo.BorderStyle = default;
            Riempi.BorderStyle = default;
        }

        private void Testo_Click(object sender, EventArgs e)
        {
            Zoom.BorderStyle = default;
            Matita.BorderStyle = default;
            Gomma.BorderStyle = default;
            Testo.BorderStyle = BorderStyle.FixedSingle;
            Riempi.BorderStyle = default;
        }

        private void Riempi_Click_1(object sender, EventArgs e)
        {
            Zoom.BorderStyle = default;
            Matita.BorderStyle = default;
            Gomma.BorderStyle = default;
            Testo.BorderStyle = default;
            Riempi.BorderStyle = BorderStyle.FixedSingle;
            
            Color sfondo = Color.FromArgb(R, G, B);

            pictureBox1.BackColor = sfondo;

            if (nuovo == true)
            {
                DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox1.Image = DrawArea;

                Graphics g;
                g = Graphics.FromImage(DrawArea);
                g.Clear(sfondo);
                g.Dispose();
            }
        }

        // On Filters->Color filtering
        private void colorFiltersItem_Click(object sender, System.EventArgs e)
        {
            ApplyFilter(new ColorFiltering(new IntRange(25, 230), new IntRange(25, 230), new IntRange(25, 230)));
            //colorFiltersItem.Checked = true;
            //sta roba non funziona
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Graphics g;
            //g = Graphics.FromImage(DrawArea);

            //Pen mypen = new Pen(Brushes.Black);
            //g.DrawLine(mypen, 0, 0, 200, 200);
            //g.Clear(Color.White);
            //g.Dispose();
        }


        // Clear current image in picture box
        private void ClearCurrentImage()
        {
            // clear current image from picture box
            pictureBox1.Image = null;
            // free current image
            if ((noneToolStripMenuItem.Checked == false) && (filteredImage != null))
            {
                filteredImage.Dispose();
                filteredImage = null;
            }
            // uncheck all menu items
            //foreach (MenuItem item in filtersItem.MenuItems)
            //    item.Checked = false;
        }

        // Apply filter to the source image and show the filtered image
        private void ApplyFilter(IFilter filter)
        {
            ClearCurrentImage();
           
            filteredImage = filter.Apply(sourceImage);
            
            pictureBox1.Image = filteredImage;
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCurrentImage();
            LoadImage();
            noneToolStripMenuItem.Checked = true;
            UncheckAllMenuItems();
        }

        void UncheckAllMenuItems()
        {
            rayscaleFiltersItem.Checked = false;
            sepiaToolStripMenuItem.Checked = false;
            invertToolStripMenuItem.Checked = false;
            rotateChannelToolStripMenuItem.Checked = false;
            colorFilteringToolStripMenuItem.Checked = false;
            hueModifierToolStripMenuItem.Checked = false;
            saturationAdjustingToolStripMenuItem.Checked = false;
            contrastAdjustingToolStripMenuItem.Checked = false;
            yCbCrLinearCorrectionToolStripMenuItem.Checked = false;
            thresholdBinarizationToolStripMenuItem.Checked = false;
            orderedDitheringToolStripMenuItem.Checked = false;
            sharpenToolStripMenuItem.Checked = false;
            differenceEdgeDetectorToolStripMenuItem.Checked = false;
            homogenityEdgeDetectorToolStripMenuItem.Checked = false;
            sobelEdgeDetectorToolStripMenuItem.Checked = false;
            levelsLinearCorrectionToolStripMenuItem.Checked = false;
            brightnessAdjustingToolStripMenuItem.Checked = false;
            hSLFilteringToolStripMenuItem.Checked = false;
            yCbCrFilteringToolStripMenuItem.Checked = false;
            floydSteinbergDitheringToolStripMenuItem.Checked = false;
            convolutionToolStripMenuItem.Checked = false;
            gaussianBlurToolStripMenuItem.Checked = false;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem1.Checked = false;
            jitterToolStripMenuItem.Checked = false;
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(Grayscale.CommonAlgorithms.BT709);
            rayscaleFiltersItem.Checked = true;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new Sepia());
            sepiaToolStripMenuItem.Checked = true;
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new Invert());
            invertToolStripMenuItem.Checked = true;
        }

        private void rotateChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new RotateChannels());
            rotateChannelToolStripMenuItem.Checked = true;
        }

        private void colorFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new ColorFiltering(new IntRange(25, 230), new IntRange(25, 230), new IntRange(25, 230)));
            colorFilteringToolStripMenuItem.Checked = true;
        }

        private void hueModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new HueModifier(50));
            hueModifierToolStripMenuItem.Checked = true;
        }

        private void saturationAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new SaturationCorrection(0.15f));
            saturationAdjustingToolStripMenuItem.Checked = true;
        }

        private void contrastAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new ContrastCorrection());
            contrastAdjustingToolStripMenuItem.Checked = true;
        }

        private void yCbCrLinearCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            YCbCrLinear filter = new YCbCrLinear();

            filter.InCb = new Range(-0.3f, 0.3f);

            ApplyFilter(filter);
            yCbCrLinearCorrectionToolStripMenuItem.Checked = true;
        }

        private void thresholdBinarizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            Bitmap originalImage = sourceImage;
            
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            
            ApplyFilter(new Threshold());
            
            sourceImage.Dispose();
            sourceImage = originalImage;

            thresholdBinarizationToolStripMenuItem.Checked = true;
        }

        private void orderedDitheringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            Bitmap originalImage = sourceImage;
            
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            
            ApplyFilter(new OrderedDithering());
            
            sourceImage.Dispose();
            sourceImage = originalImage;

            orderedDitheringToolStripMenuItem.Checked = true;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new Sharpen());
            sharpenToolStripMenuItem.Checked = true;
        }

        private void differenceEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            Bitmap originalImage = sourceImage;
            
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            
            ApplyFilter(new DifferenceEdgeDetector());
            
            sourceImage.Dispose();
            sourceImage = originalImage;

            differenceEdgeDetectorToolStripMenuItem.Checked = true;
        }

        private void homogenityEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            Bitmap originalImage = sourceImage;
            
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            
            ApplyFilter(new HomogenityEdgeDetector());
            
            sourceImage.Dispose();
            sourceImage = originalImage;

            homogenityEdgeDetectorToolStripMenuItem.Checked = true;
        }

        private void sobelEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            Bitmap originalImage = sourceImage;
            
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            
            ApplyFilter(new SobelEdgeDetector());
            
            sourceImage.Dispose();
            sourceImage = originalImage;

            sobelEdgeDetectorToolStripMenuItem.Checked = true;
        }

        private void levelsLinearCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            LevelsLinear filter = new LevelsLinear();

            filter.InRed = new IntRange(30, 230);
            filter.InGreen = new IntRange(50, 240);
            filter.InBlue = new IntRange(10, 210);

            ApplyFilter(filter);
            levelsLinearCorrectionToolStripMenuItem.Checked = true;
        }

        private void brightnessAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new BrightnessCorrection());
            brightnessAdjustingToolStripMenuItem.Checked = true;
        }
            
        private void hSLFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new HSLFiltering(new IntRange(330, 30), new Range(0, 1), new Range(0, 1)));
            hSLFilteringToolStripMenuItem.Checked = true;
        }

        private void yCbCrFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new YCbCrFiltering(new Range(0.2f, 0.9f), new Range(-0.3f, 0.3f), new Range(-0.3f, 0.3f)));
            yCbCrFilteringToolStripMenuItem.Checked = true;
        }

        private void floydSteinbergDitheringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            Bitmap originalImage = sourceImage;

            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);

            ApplyFilter(new FloydSteinbergDithering());

            sourceImage.Dispose();
            sourceImage = originalImage;

            floydSteinbergDitheringToolStripMenuItem.Checked = true;
        }

        private void convolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new Convolution(new int[,] {
                                { 1, 2, 3, 2, 1 },
                                { 2, 4, 5, 4, 2 },
                                { 3, 5, 6, 5, 3 },
                                { 2, 4, 5, 4, 2 },
                                { 1, 2, 3, 2, 1 } }));
            convolutionToolStripMenuItem.Checked = true;
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new GaussianBlur(2.0, 7));
            gaussianBlurToolStripMenuItem.Checked = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new Texturer(new TextileTexture(), 1.0, 0.8));
            toolStripMenuItem2.Checked = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new OilPainting());
            toolStripMenuItem1.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Dimenzione immagine : " + rectW + "," + rectH;
            label1.Visible = true;
            Cursor = Cursors.Default;
            Bitmap bmp2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp2, pictureBox1.ClientRectangle);

            Bitmap img = new Bitmap(rectW, rectW);

            for (int i=0; i<rectW; i++)
            {
                for (int y=0; y<rectH; y++)
                {
                    Color pxlclr = bmp2.GetPixel(px + i, py + y);
                    img.SetPixel(i, y, pxlclr);
                }
            }
            pictureBox1.Image = (Image)img;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true))
                return;
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var bitmap1 = Bitmap.FromFile(dlg.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Image = bitmap1;

                if (radioButton1.Checked == true)
                {
                    bitmap1.RotateFlip(RotateFlipType.Rotate90FlipX);
                    pictureBox1.Image = bitmap1;
                }

                if (radioButton2.Checked == true)
                {
                    bitmap1.RotateFlip(RotateFlipType.Rotate180FlipX);
                    pictureBox1.Image = bitmap1;
                }

                if (radioButton3.Checked == true)
                {
                    bitmap1.RotateFlip(RotateFlipType.Rotate270FlipX);
                    pictureBox1.Image = bitmap1;
                }
            }
        }

        private void jitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllMenuItems();
            ApplyFilter(new Jitter());
            jitterToolStripMenuItem.Checked = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // salva immagine
        }
        Image Zooom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                R = 0;
                cambia_colore(R, G, B);
                return;
            }
            if (int.Parse(textBox7.Text) > 255)
            {
                R = 255;
                textBox7.Text = "255";
                cambia_colore(R, G, B);
                return;
            }
            R = int.Parse(textBox7.Text);
            cambia_colore(R, G, B);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                B = 0;
                cambia_colore(R, G, B);
                return;
            }
            if (int.Parse(textBox9.Text) > 255)
            {
                B = 255;
                textBox9.Text = "255";
                cambia_colore(R, G, B);
                return;
            }
            B = int.Parse(textBox9.Text);
            cambia_colore(R, G, B);
        }

        private void cambia_colore(int R, int G, int B)
        {
            pictureBox2.BackColor = Color.FromArgb(R, G, B);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                G = 0;
                cambia_colore(R, G, B);
                return;
            }
            if (int.Parse(textBox8.Text) > 255)
            {
                G = 255;
                textBox8.Text = "255";
                cambia_colore(R, G, B);
                return;
            }
            G = int.Parse(textBox8.Text);
            cambia_colore(R, G, B);
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuovo = true;
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = DrawArea;

            Graphics g;
            g = Graphics.FromImage(DrawArea);
            g.Clear(Color.White);
            g.Dispose();
        }

        private void tmatita_Tick(object sender, EventArgs e)
        {
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = DrawArea;
            Pen matita;

            //Graphics g;
            //g = Graphics.FromImage(DrawArea);
            //g.DrawRectangle(matita, );
            //g.Dispose();
        }

        private void tgomma_Tick(object sender, EventArgs e)
        {
            //gomma
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            tmatita.Stop();
            tgomma.Stop();

            isMouseDown = false;

            lastPoint = Point.Empty;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            tmatita.Stop();
            tgomma.Stop();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
                lastPoint = e.Location;

                isMouseDown = true;
            
            //if (smatita == true)
            //{
            //    tmatita.Start();
            //}

            //if (sgomma == true)
            //{
            //    tgomma.Start();
            //}
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
                if (isMouseDown == true)

                {

                    if (lastPoint != null)

                    {

                        if (pictureBox1.Image == null)

                        {

                            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                            pictureBox1.Image = bmp;

                        }

                        using (Graphics g = Graphics.FromImage(pictureBox1.Image))

                        {

                            g.DrawLine(new Pen(Color.FromArgb(R, G, B), int.Parse(textBox10.Text)), lastPoint, e.Location);
                            //g.SmoothingMode = SmoothingMode.AntiAliasing;

                        }

                        pictureBox1.Invalidate();

                        lastPoint = e.Location;

                    }

                }
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                
                textBox10.Text = "1";
                return;
            }

            if (int.Parse(textBox10.Text) < 1)
            {
                textBox10.Text = "1";
                return;
            }

            if (int.Parse(textBox10.Text) > 100)
            {
                textBox10.Text = "100";
                return;
            }
           
        }

        private void Matita_MouseHover(object sender, EventArgs e)
        {
            label13.Show();
        }

        private void Matita_MouseLeave(object sender, EventArgs e)
        {
            label13.Hide();
        }

        private void Riempi_MouseHover(object sender, EventArgs e)
        {
            label14.Show();
        }

        private void Riempi_MouseLeave(object sender, EventArgs e)
        {
            label14.Hide();
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Gomma_MouseHover(object sender, EventArgs e)
        {
            label15.Show();
        }

        private void Gomma_MouseLeave(object sender, EventArgs e)
        {
            label15.Hide();
        }

        private void label16_MouseHover(object sender, EventArgs e)
        {

        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Zoom_MouseHover(object sender, EventArgs e)
        {
            label16.Show();
        }

        private void Zoom_MouseLeave(object sender, EventArgs e)
        {
            label16.Hide();
        }

        private void Testo_MouseHover(object sender, EventArgs e)
        {
            label17.Show();
        }

        private void Testo_MouseLeave(object sender, EventArgs e)
        {
            label17.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //if (radioButton4.Checked==false)
            //{
            //    MessageBox.Show("selezionare il bottone per tagliare");
            //    return;
            //}
            //pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            //pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            //pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            //Controls.Add(pictureBox1);
        }
        int px, py, rectW, rectH;
        public Pen pen = new Pen(Color.White);
        
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }
        
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default;
        }

    }
}

