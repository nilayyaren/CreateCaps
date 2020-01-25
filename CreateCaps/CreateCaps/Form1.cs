using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateCaps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FontDialog fontOption = new FontDialog();

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectPic = new OpenFileDialog();
            selectPic.Filter = "Image File(JPEG)|*.jpg";
            if (selectPic.ShowDialog() == DialogResult.OK)
                txtOpenFile.Text = selectPic.FileName;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Image selectedImage = Image.FromFile(txtOpenFile.Text);
            picField.SizeMode = PictureBoxSizeMode.StretchImage;
            string caption = txtCreate.Text;
            Rectangle rect = new Rectangle(0, 450, 838, 130);
            Graphics graph2 = Graphics.FromImage(selectedImage);
            graph2.FillRectangle(Brushes.Red, rect);
            Graphics graph = graph2;
            graph.DrawString(caption, fontOption.Font, Brushes.White, 0, 453);
            picField.Image = selectedImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG File(*.jpg)|*.jpg";
            saveFileDialog1.ShowDialog();
            picField.Image.Save(saveFileDialog1.FileName);
            MessageBox.Show("File Saved Succesfully!");
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontOption.ShowDialog();
        }
    }
}
