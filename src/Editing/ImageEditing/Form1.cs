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





namespace ImageEditing
{
    public partial class Form1 : Form
    {
        Image immagine;

        public Form1()
        {
            InitializeComponent();

            Panel_Salva.Location = new System.Drawing.Point(371, 332);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Scegli l'immagne";
            dlg.Filter = "all files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
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

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Zoom.BorderStyle = default;
            Matita.BorderStyle = BorderStyle.FixedSingle;
            Gomma.BorderStyle = default;
            Testo.BorderStyle = default;
            Riempi.BorderStyle = default;
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
            Image newImage = Image.FromFile(dlg.FileName);

            float x = 0.0F;
            float w = 0.0F;
            float a = 0.0F;
            float y = 0.0F;

            label1.Text = "dimenzioni per l'asse x";
            x= float.Parse(textBox1.Text);
            
            label1.Text = "dimenzioni per l'asse y";
            y = float.Parse(textBox1.Text);

            label1.Text = "dimenzioni per l'altezza";
            a = float.Parse(textBox1.Text);

            label1.Text = "dimenzioni per la larghezza";
            w = float.Parse(textBox1.Text);

            RectangleF A = new RectangleF(x,y,w,a);
            GraphicsUnit h = GraphicsUnit.Pixel;

            e.Graphics.DrawImage(newImage, x, y, A, h);

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
            Zoom.BorderStyle=BorderStyle.FixedSingle;
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
    }
}
