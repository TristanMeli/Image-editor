// Image Processing filters demo
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2006-2011
// contacts@aforgenet.com
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using System.ComponentModel;
using Image = System.Drawing.Image;
using System.IO;
using System.Drawing.Imaging;

namespace Image_Editor_PCTO
{
    public partial class Form1 : Form
    {
        Image immagine;

        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, PaintEventArgs e)
        {
            var dlg = new OpenFileDialog();
            System.Drawing.Image newImage = System.Drawing.Image.FromFile(dlg.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = 0.0F;
            float w = 0.0F;
            float a = 0.0F;
            float y = 0.0F;

            x = float.Parse(textBox1.Text);

            y = float.Parse(textBox2.Text);

            a = float.Parse(textBox3.Text);

            w = float.Parse(textBox4.Text);

            RectangleF A = new RectangleF(x, y, w, a);
            GraphicsUnit h = GraphicsUnit.Pixel;

            Image newImage = pictureBox1.Image; 
            newImage = ClassLibrary1.Class1.Taglia(x, y, a, w, newImage);
            pictureBox1.Image = newImage;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true))
                return;
            var dlg = new OpenFileDialog();
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


        #region
        //private void ClearCurrentImage()
        //{
        //    // clear current image from picture box
        //    pictureBox1.Image = null;
        //    // free current image
        //    if ((noneToolStripMenuItem.Checked == false) && (filteredImage != null))
        //    {
        //        filteredImage.Dispose();
        //        filteredImage = null;
        //    }
        //    // uncheck all menu items
        //    foreach (MenuItem item in filtersItem.MenuItems)
        //        item.Checked = false;
        //}

        //// Apply filter to the source image and show the filtered image
        //private void ApplyFilter(IFilter filter)
        //{
        //    ClearCurrentImage();
        //    // apply filter
        //    filteredImage = filter.Apply(sourceImage);
        //    // display filtered image
        //    pictureBox1.Image = filteredImage;
        //}

        //private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ClearCurrentImage();
        //    // display source image
        //    pictureBox1.Image = sourceImage;
        //    noneToolStripMenuItem.Checked = true;
        //}

        //private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(Grayscale.CommonAlgorithms.BT709);
        //    grayscaleFiltersItem.Checked = true;
        //}

        //private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new Sepia());
        //    sepiaFiltersItem.Checked = true;
        //}

        //private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new Invert());
        //    invertFiltersItem.Checked = true;
        //}

        //private void rotateChannelToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new RotateChannels());
        //    rotateChannelFiltersItem.Checked = true;
        //}

        //private void colorFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new ColorFiltering(new IntRange(25, 230), new IntRange(25, 230), new IntRange(25, 230)));
        //    colorFiltersItem.Checked = true;
        //}

        //private void hueModifierToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new HueModifier(50));
        //    hueModifierFiltersItem.Checked = true;
        //}

        //private void saturationAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new SaturationCorrection(0.15f));
        //    saturationAdjustingFiltersItem.Checked = true;
        //}

        //private void contrastAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new ContrastCorrection());
        //    contrastAdjustingFiltersItem.Checked = true;
        //}

        //private void yCbCrLinearCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    YCbCrLinear filter = new YCbCrLinear();

        //    filter.InCb = new Range(-0.3f, 0.3f);

        //    ApplyFilter(filter);
        //    yCbCrLinearFiltersItem.Checked = true;
        //}

        //private void thresholdBinarizationToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Bitmap originalImage = sourceImage;
        //    // get grayscale image
        //    sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
        //    // apply threshold filter
        //    ApplyFilter(new Threshold());
        //    // delete grayscale image and restore original
        //    sourceImage.Dispose();
        //    sourceImage = originalImage;

        //    thresholdFiltersItem.Checked = true;
        //}

        //private void orderedDitheringToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    // save original image
        //    Bitmap originalImage = sourceImage;
        //    // get grayscale image
        //    sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
        //    // apply threshold filter
        //    ApplyFilter(new OrderedDithering());
        //    // delete grayscale image and restore original
        //    sourceImage.Dispose();
        //    sourceImage = originalImage;

        //    orderedDitheringFiltersItem.Checked = true;
        //}

        //private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new Sharpen());
        //    sharpenFiltersItem.Checked = true;
        //}

        //private void differenceEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    // save original image
        //    Bitmap originalImage = sourceImage;
        //    // get grayscale image
        //    sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
        //    // apply edge filter
        //    ApplyFilter(new DifferenceEdgeDetector());
        //    // delete grayscale image and restore original
        //    sourceImage.Dispose();
        //    sourceImage = originalImage;

        //    differenceEdgesFiltersItem.Checked = true;
        //}

        //private void homogenityEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    // save original image
        //    Bitmap originalImage = sourceImage;
        //    // get grayscale image
        //    sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
        //    // apply edge filter
        //    ApplyFilter(new HomogenityEdgeDetector());
        //    // delete grayscale image and restore original
        //    sourceImage.Dispose();
        //    sourceImage = originalImage;

        //    homogenityEdgesFiltersItem.Checked = true;
        //}

        //private void sobelEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    // save original image
        //    Bitmap originalImage = sourceImage;
        //    // get grayscale image
        //    sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
        //    // apply edge filter
        //    ApplyFilter(new SobelEdgeDetector());
        //    // delete grayscale image and restore original
        //    sourceImage.Dispose();
        //    sourceImage = originalImage;

        //    sobelEdgesFiltersItem.Checked = true;
        //}

        //private void levelsLinearCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LevelsLinear filter = new LevelsLinear();

        //    filter.InRed = new IntRange(30, 230);
        //    filter.InGreen = new IntRange(50, 240);
        //    filter.InBlue = new IntRange(10, 210);

        //    ApplyFilter(filter);
        //    rgbLinearFiltersItem.Checked = true;
        //}
        //private void brightnessAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new BrightnessCorrection());
        //    brightnessAdjustingFiltersItem.Checked = true;
        //}
        //private void brightnessAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new BrightnessCorrection());
        //    brightnessAdjustingFiltersItem.Checked = true;
        //}

        //private void hSLFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new HSLFiltering(new IntRange(330, 30), new Range(0, 1), new Range(0, 1)));
        //    hslFiltersItem.Checked = true;
        //}

        //private void yCbCrFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new YCbCrFiltering(new Range(0.2f, 0.9f), new Range(-0.3f, 0.3f), new Range(-0.3f, 0.3f)));
        //    yCbCrFiltersItem.Checked = true;
        //}

        //private void floydSteinbergDitheringToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Bitmap originalImage = sourceImage;

        //    sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);

        //    ApplyFilter(new FloydSteinbergDithering());

        //    sourceImage.Dispose();
        //    sourceImage = originalImage;

        //    floydFiltersItem.Checked = true;
        //}

        //private void convolutionToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new Convolution(new int[,] {
        //                        { 1, 2, 3, 2, 1 },
        //                        { 2, 4, 5, 4, 2 },
        //                        { 3, 5, 6, 5, 3 },
        //                        { 2, 4, 5, 4, 2 },
        //                        { 1, 2, 3, 2, 1 } }));
        //    convolutionFiltersItem.Checked = true;
        //}

        //private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new GaussianBlur(2.0, 7));
        //    gaussianFiltersItem.Checked = true;
        //}

        //private void toolStripMenuItem2_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new Texturer(new TextileTexture(), 1.0, 0.8));
        //    textureFiltersItem.Checked = true;
        //}

        //private void toolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new OilPainting());
        //    oilFiltersItem.Checked = true;
        //}

        //private void jitterToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ApplyFilter(new Jitter());
        //    jitterFiltersItem.Checked = true;
        //}
        #endregion  //filtri//
        //filtri, lavoro daniel e bisso//
        #region
        private void caricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog imm = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "all files (*.*)|*.*" })
            {
                if (imm.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(imm.FileName);
                }

            }
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salva.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            textBox2.Clear();
            if (File.Exists(nome + "Png"))
            {
                MessageBox.Show("Nome gia usato");
                Salva.Visible = false;
                return;
            }
            pictureBox1.Image.Save(nome + ".Png", ImageFormat.Png);
            MessageBox.Show("Immagine salvata");
            Salva.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Matita.BorderStyle = BorderStyle.FixedSingle;
            Sfondo.BorderStyle = default;
            Zoom.BorderStyle = default;
            Gomma.BorderStyle = default;
            Testo.BorderStyle = default;
        }

        private void Gomma_Click(object sender, EventArgs e)
        {
            Matita.BorderStyle = default;
            Sfondo.BorderStyle = default;
            Zoom.BorderStyle = default;
            Gomma.BorderStyle = BorderStyle.FixedSingle;
            Testo.BorderStyle = default;
        }

        private void Sfondo_Click(object sender, EventArgs e)
        {
            Matita.BorderStyle = default;
            Sfondo.BorderStyle = BorderStyle.FixedSingle;
            Zoom.BorderStyle = default;
            Gomma.BorderStyle = default;
            Testo.BorderStyle = default;
        }

        private void Testo_Click(object sender, EventArgs e)
        {
            Matita.BorderStyle = default;
            Sfondo.BorderStyle = default;
            Zoom.BorderStyle = default;
            Gomma.BorderStyle = default;
            Testo.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Zoom_Click(object sender, EventArgs e)
        {
            Matita.BorderStyle = default;
            Sfondo.BorderStyle = default;
            Zoom.BorderStyle = BorderStyle.FixedSingle;
            Gomma.BorderStyle = default;
            Testo.BorderStyle = default;
        }

        //private void pictureBox2_Click(object sender, EventArgs e)
        //{
        //    Zoom.BorderStyle = default;
        //    Matita.BorderStyle = BorderStyle.FixedSingle;
        //    Gomma.BorderStyle = default;
        //    Testo.BorderStyle = default;
        //    Riempi.BorderStyle = default;
        //    //Graphics g;
        //    //g = Graphics.FromImage(DrawArea);

        //    //Pen mypen = new Pen(Color.Black);

        //    //g.DrawLine(mypen, 0, 0, 200, x);

        //    //pictureBox1.Image = DrawArea;

        //    //g.Dispose();
        //    //x++;
        //}
        //private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Panel_Salva.Visible = true;

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    string nome = textBox2.Text;
        //    textBox2.Clear();
        //    if (File.Exists(nome + "Png"))
        //    {
        //        MessageBox.Show("Nome gia usato");
        //        Panel_Salva.Visible = false;
        //        return;
        //    }
        //    pictureBox.Image.Save(nome + ".Png", ImageFormat.Png);
        //    MessageBox.Show("Immagine salvata");
        //    Panel_Salva.Visible = false;
        //}

        //private void Riempi_Click(object sender, EventArgs e)
        //{
        //    Zoom.BorderStyle = default;
        //    Matita.BorderStyle = default;
        //    Gomma.BorderStyle = BorderStyle.FixedSingle;
        //    Testo.BorderStyle = default;
        //    Riempi.BorderStyle = default;
        //}

        //private void Zoom_Click(object sender, EventArgs e)
        //{
        //    Zoom.BorderStyle = BorderStyle.FixedSingle;
        //    Matita.BorderStyle = default;
        //    Gomma.BorderStyle = default;
        //    Testo.BorderStyle = default;
        //    Riempi.BorderStyle = default;
        //}

        //private void Testo_Click(object sender, EventArgs e)
        //{
        //    Zoom.BorderStyle = default;
        //    Matita.BorderStyle = default;
        //    Gomma.BorderStyle = default;
        //    Testo.BorderStyle = BorderStyle.FixedSingle;
        //    Riempi.BorderStyle = default;
        //}

        //private void Riempi_Click_1(object sender, EventArgs e)
        //{
        //    Zoom.BorderStyle = default;
        //    Matita.BorderStyle = default;
        //    Gomma.BorderStyle = default;
        //    Testo.BorderStyle = default;
        //    Riempi.BorderStyle = BorderStyle.FixedSingle;
        //}

        //Image Zooom(Image img, Size size)
        //{
        //    Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
        //    Graphics g = Graphics.FromImage(bmp);
        //    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        //    return bmp;
        //}

        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    if (trackBar1.Value > 0)
        //    {
        //        pictureBox.Image = Zooom(immagine, new Size(trackBar1.Value, trackBar1.Value));
        //    }
        //}
        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (pictureBox.Image != null)
        //        pictureBox.Dispose();
        //}
        #endregion
        //lavoro meli e walid//


    }
}
