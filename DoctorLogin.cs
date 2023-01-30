using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinical
{
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlcon = ConfigurationManager.ConnectionStrings["db"].ToString();

            SqlConnection con = new SqlConnection(sqlcon);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select count(*) from Doctorinfo where username ='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                DoctorProfile dv = new DoctorProfile();
                dv.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Pass or username");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            NurseLogin nl = new NurseLogin();
            nl.Show();
            this.Hide();
        }

        private void DoctorLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
