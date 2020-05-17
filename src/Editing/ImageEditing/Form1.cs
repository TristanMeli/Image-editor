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




namespace ImageEditing
{
    public partial class Form1 : Form
    {
        Image immagine;
        //Bitmap DrawArea;
        //int x = 150;

        public Form1()
        {
            InitializeComponent();

            //DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);

            //pictureBox1.Image = DrawArea;
            Panel_Salva.Location = new System.Drawing.Point(371, 232);

            //Graphics g;
            //g = Graphics.FromImage(DrawArea);
            //g.Clear(Color.Transparent);
            //g.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Scegli l'immagine";
            dlg.Filter = "all files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(dlg.FileName);
            }
        }

        private void caricaImmagineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog imm = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "all files (*.*)|*.*" })
            {
                if (imm.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(imm.FileName);
                    immagine = pictureBox1.Image;
                }

                pictureBox1.Image = System.Drawing.Image.FromFile(dlg.FileName);
                //pictureBox1.BackgroundImage = Image.FromFile(dlg.FileName);
                pictureBox1.Image = System.Drawing.Image.FromFile(dlg.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Zoom.BorderStyle = default;
            Matita.BorderStyle = BorderStyle.FixedSingle;
            Gomma.BorderStyle = default;
            Testo.BorderStyle = default;
            Riempi.BorderStyle = default;
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
<<<<<<< HEAD
=======


        private void button1_Click(object sender, PaintEventArgs e)
        {
            var dlg = new OpenFileDialog();
            System.Drawing.Image newImage = System.Drawing.Image.FromFile(dlg.FileName);
>>>>>>> 22f3a0ddb8286da040915760922fbcebab85805e

        private void button1_Click(object sender, EventArgs e)
        {
            float x = 0.0F;
            float w = 0.0F;
            float a = 0.0F;
            float y = 0.0F;

<<<<<<< HEAD
            x = float.Parse(textBox1.Text);
=======
            label1.Text = "dimenzioni per l'asse x";
            x = float.Parse(textBox1.Text);

            label1.Text = "dimenzioni per l'asse y";
            y = float.Parse(textBox1.Text);
>>>>>>> 22f3a0ddb8286da040915760922fbcebab85805e

            y = float.Parse(textBox2.Text);

            a = float.Parse(textBox3.Text);

<<<<<<< HEAD
            w = float.Parse(textBox4.Text);
=======
            RectangleF A = new RectangleF(x, y, w, a);
            GraphicsUnit h = GraphicsUnit.Pixel;
>>>>>>> 22f3a0ddb8286da040915760922fbcebab85805e

            Image newImage = pictureBox1.Image;
            RectangleF A = new RectangleF(x, y, w, a);
            newImage = ClassLibrary1.Class1.Taglia(x, y, a, w, newImage);
            pictureBox1.Image = newImage; 

        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Salva.Visible = true;

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
        }

        Image Zooom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0)
            {
                pictureBox1.Image = Zooom(immagine, new Size(trackBar1.Value, trackBar1.Value));
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Dispose();
        }
        // On Filters->Color filtering
        private void colorFiltersItem_Click(object sender, System.EventArgs e)
        {
            //ApplyFilter(new ColorFiltering(new IntRange(25, 230), new IntRange(25, 230), new IntRange(25, 230)));
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

        private System.Windows.Forms.MenuItem fileItem;
        private System.Windows.Forms.MenuItem openFileItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem exitFilrItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem sizeItem;
        private System.Windows.Forms.MenuItem normalSizeItem;
        private System.Windows.Forms.MenuItem stretchedSizeItem;
        private System.Windows.Forms.MenuItem centeredSizeItem;
        private System.Windows.Forms.MenuItem filtersItem;
        private System.Windows.Forms.MenuItem noneFiltersItem;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem sepiaFiltersItem;
        private System.Windows.Forms.MenuItem invertFiltersItem;
        private System.Windows.Forms.MenuItem rotateChannelFiltersItem;
        private System.Windows.Forms.MenuItem grayscaleFiltersItem;
        private System.Windows.Forms.MenuItem colorFiltersItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem hueModifierFiltersItem;
        private System.Windows.Forms.MenuItem saturationAdjustingFiltersItem;
        private System.Windows.Forms.MenuItem brightnessAdjustingFiltersItem;
        private System.Windows.Forms.MenuItem contrastAdjustingFiltersItem;
        private System.Windows.Forms.MenuItem hslFiltersItem;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem yCbCrLinearFiltersItem;
        private System.Windows.Forms.MenuItem yCbCrFiltersItem;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem thresholdFiltersItem;
        private System.Windows.Forms.MenuItem floydFiltersItem;
        private System.Windows.Forms.MenuItem orderedDitheringFiltersItem;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem convolutionFiltersItem;
        private System.Windows.Forms.MenuItem sharpenFiltersItem;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem differenceEdgesFiltersItem;
        private System.Windows.Forms.MenuItem homogenityEdgesFiltersItem;
        private System.Windows.Forms.MenuItem sobelEdgesFiltersItem;
        private System.Windows.Forms.MenuItem rgbLinearFiltersItem;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem jitterFiltersItem;
        private System.Windows.Forms.MenuItem oilFiltersItem;
        private MenuItem gaussianFiltersItem;
        private MenuItem textureFiltersItem;
        private IContainer component;

        private System.Drawing.Bitmap sourceImage;
        private System.Drawing.Bitmap filteredImage;



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
            foreach (MenuItem item in filtersItem.MenuItems)
                item.Checked = false;
        }

        // Apply filter to the source image and show the filtered image
        private void ApplyFilter(IFilter filter)
        {
            ClearCurrentImage();
            // apply filter
            filteredImage = filter.Apply(sourceImage);
            // display filtered image
            pictureBox1.Image = filteredImage;
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCurrentImage();
            // display source image
            pictureBox1.Image = sourceImage;
            noneToolStripMenuItem.Checked = true;
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(Grayscale.CommonAlgorithms.BT709);
            grayscaleFiltersItem.Checked = true;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Sepia());
            sepiaFiltersItem.Checked = true;
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Invert());
            invertFiltersItem.Checked = true;
        }

        private void rotateChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new RotateChannels());
            rotateChannelFiltersItem.Checked = true;
        }

        private void colorFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new ColorFiltering(new IntRange(25, 230), new IntRange(25, 230), new IntRange(25, 230)));
            colorFiltersItem.Checked = true;
        }

        private void hueModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new HueModifier(50));
            hueModifierFiltersItem.Checked = true;
        }

        private void saturationAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new SaturationCorrection(0.15f));
            saturationAdjustingFiltersItem.Checked = true;
        }

        private void contrastAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new ContrastCorrection());
            contrastAdjustingFiltersItem.Checked = true;
        }

        private void yCbCrLinearCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YCbCrLinear filter = new YCbCrLinear();

            filter.InCb = new Range(-0.3f, 0.3f);

            ApplyFilter(filter);
            yCbCrLinearFiltersItem.Checked = true;
        }

        private void thresholdBinarizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply threshold filter
            ApplyFilter(new Threshold());
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

            thresholdFiltersItem.Checked = true;
        }

        private void orderedDitheringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply threshold filter
            ApplyFilter(new OrderedDithering());
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

            orderedDitheringFiltersItem.Checked = true;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Sharpen());
            sharpenFiltersItem.Checked = true;
        }

        private void differenceEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply edge filter
            ApplyFilter(new DifferenceEdgeDetector());
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

            differenceEdgesFiltersItem.Checked = true;
        }

        private void homogenityEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply edge filter
            ApplyFilter(new HomogenityEdgeDetector());
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

            homogenityEdgesFiltersItem.Checked = true;
        }

        private void sobelEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply edge filter
            ApplyFilter(new SobelEdgeDetector());
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

            sobelEdgesFiltersItem.Checked = true;
        }

        private void levelsLinearCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelsLinear filter = new LevelsLinear();

            filter.InRed = new IntRange(30, 230);
            filter.InGreen = new IntRange(50, 240);
            filter.InBlue = new IntRange(10, 210);

            ApplyFilter(filter);
            rgbLinearFiltersItem.Checked = true;
        }
        private void brightnessAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new BrightnessCorrection());
            brightnessAdjustingFiltersItem.Checked = true;
        }
            private void brightnessAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
            {
                ApplyFilter(new BrightnessCorrection());
                brightnessAdjustingFiltersItem.Checked = true;
            }

            private void hSLFilteringToolStripMenuItem_Click(object sender, EventArgs e)
            {
                ApplyFilter(new HSLFiltering(new IntRange(330, 30), new Range(0, 1), new Range(0, 1)));
                hslFiltersItem.Checked = true;
            }

            private void yCbCrFilteringToolStripMenuItem_Click(object sender, EventArgs e)
            {
                ApplyFilter(new YCbCrFiltering(new Range(0.2f, 0.9f), new Range(-0.3f, 0.3f), new Range(-0.3f, 0.3f)));
                yCbCrFiltersItem.Checked = true;
            }

            private void floydSteinbergDitheringToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Bitmap originalImage = sourceImage;

                sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);

                ApplyFilter(new FloydSteinbergDithering());

                sourceImage.Dispose();
                sourceImage = originalImage;

                floydFiltersItem.Checked = true;
            }

            private void convolutionToolStripMenuItem_Click(object sender, EventArgs e)
            {
                ApplyFilter(new Convolution(new int[,] {
                                { 1, 2, 3, 2, 1 },
                                { 2, 4, 5, 4, 2 },
                                { 3, 5, 6, 5, 3 },
                                { 2, 4, 5, 4, 2 },
                                { 1, 2, 3, 2, 1 } }));
                convolutionFiltersItem.Checked = true;
            }

            private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
            {
                ApplyFilter(new GaussianBlur(2.0, 7));
                gaussianFiltersItem.Checked = true;
            }

            private void toolStripMenuItem2_Click(object sender, EventArgs e)
            {
                ApplyFilter(new Texturer(new TextileTexture(), 1.0, 0.8));
                textureFiltersItem.Checked = true;
            }

            private void toolStripMenuItem1_Click(object sender, EventArgs e)
            {
                ApplyFilter(new OilPainting());
                oilFiltersItem.Checked = true;
            }

            private void jitterToolStripMenuItem_Click(object sender, EventArgs e)
            {
                ApplyFilter(new Jitter());
                jitterFiltersItem.Checked = true;
            }
        
    }
}

