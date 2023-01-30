using Patagames.Ocr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinical
{
    public partial class OCR : Form
    {
        public OCR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";



            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPEG files(*.jpeg)|*.jpeg | PNG files(*.png)|*.png | All Files(*.*) |*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = objOcr.GetTextFromImage(pictureBox1.ImageLocation);
                textBox1.Text = plainText;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NurseView nv = new NurseView();
            nv.Show();
            this.Hide();
        }
    }
}
