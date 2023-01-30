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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinical
{
    public partial class NurseLogin : Form
    {
        public NurseLogin()
        {
            InitializeComponent();
        }

        private void NurseLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlcon = ConfigurationManager.ConnectionStrings["db"].ToString();

            SqlConnection con = new SqlConnection(sqlcon);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select count(*) from Nurseinf where username ='" + textBox1.Text + "'and password='" + AdminPass.Text + "'", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                NurseView nv = new NurseView();
                nv.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Pass or username");
                textBox1.Text = "";
                AdminPass.Text = "";
            }
            con.Close();
            /*if (AdminPass.Text == "")
            {
                MessageBox.Show("Enter the  Admin Password");

            }
            else if (AdminPass.Text == "Password")
            {
                NurseView nv = new NurseView();
                nv.Show();
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Wrong Password");
            
            }*/
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DoctorLogin l = new DoctorLogin();
            l.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            signup sn = new signup();
            sn.Show();
        }
    }
}
