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






namespace ImageEditing
{
    public partial class Form1 : Form
    {
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
            var dlg = new OpenFileDialog();
            dlg.Title = "Scegli l'immagne";
            dlg.Filter = "all files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
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
        private void button1_Click(object sender, PaintEventArgs e)
        {
            var dlg = new OpenFileDialog();
            System.Drawing.Image newImage = System.Drawing.Image.FromFile(dlg.FileName);

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
    }
}
