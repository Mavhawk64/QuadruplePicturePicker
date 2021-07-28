using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string x = (sender as Button).Text;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG (*.JPG)|*.jpg";
            Image file;
            if (f.ShowDialog() == DialogResult.OK && x != null)
            {
                file = Image.FromFile(f.FileName);
                if (x.Contains("1"))
                {
                    pictureBox1.Image = file;
                }
                else if (x.Contains("2"))
                {
                    pictureBox2.Image = file;
                }
                else if (x.Contains("3"))
                {
                    pictureBox3.Image = file;
                }
                else if (x.Contains("4"))
                {
                    pictureBox4.Image = file;
                }
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
            string x = (sender as PictureBox).Name;                                                                                                                                                                
            if (x != null)
                if (x.Contains("1"))
                {
                    pictureBox1.SizeMode = pictureBox1.SizeMode == PictureBoxSizeMode.StretchImage ? PictureBoxSizeMode.AutoSize : PictureBoxSizeMode.StretchImage;
                }
                else if (x.Contains("2"))
                {
                    pictureBox2.SizeMode = pictureBox2.SizeMode == PictureBoxSizeMode.StretchImage ? PictureBoxSizeMode.AutoSize : PictureBoxSizeMode.StretchImage;
                }
                else if (x.Contains("3"))
                {
                    pictureBox3.SizeMode = pictureBox3.SizeMode == PictureBoxSizeMode.StretchImage ? PictureBoxSizeMode.AutoSize : PictureBoxSizeMode.StretchImage;
                }
                else if (x.Contains("4"))
                {
                    pictureBox4.SizeMode = pictureBox4.SizeMode == PictureBoxSizeMode.StretchImage ? PictureBoxSizeMode.AutoSize : PictureBoxSizeMode.StretchImage;
                }
        }
    }
}
