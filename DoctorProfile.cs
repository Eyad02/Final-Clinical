using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class DoctorProfile : Form
    {
        SqlConnection con = new SqlConnection("Data Source=EYAD-EL-HAWARY\\SQLEXPRESS;Initial Catalog=Orthopedic_DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public DoctorProfile()
        {
            InitializeComponent();
        }

        private void DoctorView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorViewApp f2 = new DoctorViewApp();
            f2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DoctorLogin lg = new DoctorLogin();
            lg.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void GetPatname()
        {
            DoctorLogin dl = new DoctorLogin();
            con.Open();
            string query = "select * from doctorinfo where national_id = 20200";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox9.Text = dr["doctor_id"].ToString();
                textBox2.Text = dr["dname"].ToString();
                textBox8.Text = dr["address"].ToString();
                textBox4.Text = dr["username"].ToString();
                textBox2.Text = dr["password"].ToString();
                textBox7.Text = dr["ddob"].ToString();
                
            }
            con.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FollowUp fp = new FollowUp();
            fp.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MedicalRecord mr = new MedicalRecord();
            mr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doc_Integrated_View di = new Doc_Integrated_View();
            di.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prescription pr = new Prescription();
            pr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Xray_Zoom xz = new Xray_Zoom();
            xz.Show();
            this.Hide();
        }
    }
}
