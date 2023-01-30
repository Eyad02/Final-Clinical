using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Clinical
{
    
    public partial class Xray_Zoom : Form
    {
        SqlConnection sqlcon;
        SqlDataAdapter sqladp;
        DataTable data = new DataTable();
        int pos;
        Image img;
        public Xray_Zoom()
        {
            InitializeComponent();
        }
        /*Image Zoom(Image im, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width),
                Convert.ToInt32(img.Height * size.Height));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;

        }
        PictureBox org;*/
        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 6;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;
            pos = 0;

            this.DoubleBuffered = true; //minimizes the strutter
            
         

        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            /*if (trackBar1.Value != 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = Zoom(pictureBox1.Image, new Size(trackBar1.Value, trackBar1.Value));
            }*/
        }
        public void displaytext(int rono)
        {
            string query = "select Xray from patientmedicalinfo where national_id = '"+ textBox1.Text +"'";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString()))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(data);

                    }
                }
                
            }
            string X = data.Rows[rono][0].ToString();
            string r = Path.GetDirectoryName(Application.ExecutablePath) + @"\demoimage\" + X;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load(r);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*using (OpenFileDialog dialog = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "JPEG|*.jpg" })
            {

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(dialog.FileName);
                    picimage = pictureBox1.Image;

                }
            }*/

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos = 0;
            displaytext(pos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pos = pos + 1;
            if (pos >= data.Rows.Count)
            {
                pos--;
                MessageBox.Show("last record");
            }
            displaytext(pos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pos = data.Rows.Count - 1;
            displaytext(pos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displaytext(pos);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Doc_Integrated_View dc = new Doc_Integrated_View();
            dc.Show();
            this.Hide();
        }

        
    }
}
