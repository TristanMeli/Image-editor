using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageEditing
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            Panel_Salva.Location = new Point(371, 332);
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
            var dlg = new OpenFileDialog();
            dlg.Title = "Scegli l'immagne";
            dlg.Filter = "all files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Matita.BorderStyle = BorderStyle.FixedSingle;
            //aForge
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
    }
}
