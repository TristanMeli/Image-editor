using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


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
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Image = System.Drawing.Image.FromFile(dlg.FileName);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
