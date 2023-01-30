using System;
using System.Collections;
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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinical
{
    public partial class Labresults : Form
    {
        SqlConnection sqlcon;
        SqlDataAdapter sqladp;
        DataTable data = new DataTable();
        int pos;

        public Labresults()
        {
            InitializeComponent();
        }

        private void Labresults_Load(object sender, EventArgs e)
        {
            pos = 0;   
        }
        public void displaytext(int rono)
        {
            string query = "select labresults from patientmedicalinfo where national_id = '" + textBox1.Text + "'";
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
            pos = pos - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displaytext(pos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Doc_Integrated_View dc = new Doc_Integrated_View();
            dc.Show();
            this.Hide();
        }
    }
}
