using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            Image newImage = pictureBox1.Image;
            RectangleF A = new RectangleF(x, y, w, a);
            newImage = ClassLibrary1.Class1.Taglia(x, y, a, w, newImage);
            pictureBox1.Image = newImage; 

        }
    }
}
