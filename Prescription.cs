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
    public partial class Prescription : Form
    {
        SqlConnection con = new SqlConnection("Data Source=EYAD-EL-HAWARY\\SQLEXPRESS;Initial Catalog=Orthopedic_DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Prescription()
        {
            InitializeComponent();
         
            GetDocid();
            GetDocname();
            GetPatid();
            GetPatname();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orthopedic_DBDataSet5.prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.orthopedic_DBDataSet5.prescription);
            using (Orthopedic_DBDataSet5 db = new Orthopedic_DBDataSet5()) 
            {
                prescriptionBindingSource.DataSource = db.prescription.ToList();
            }
        }
        private void GetPatid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select national_id from patientinfo", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("national_id", typeof(int));
            dt.Load(rdr);
            comboBox2.ValueMember = "national_id";
            comboBox2.DataSource = dt;
            con.Close();

        }
        private void GetDocid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select doctor_id from Doctorinfo", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("doctor_id", typeof(int));
            dt.Load(rdr);
            comboBox3.ValueMember = "doctor_id";
            comboBox3.DataSource = dt;
            con.Close();

        }

        private void GetDocname()
        {
            con.Open();
            string query = "select * from Doctorinfo where doctor_id=" + comboBox3.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox4.Text = dr["dname"].ToString();
            }
            con.Close();
        }
        private void GetPatname()
        {
            con.Open();
            string query = "select * from patientinfo where national_id=" + comboBox2.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox3.Text = dr["patientname"].ToString();
            }
            con.Close();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorProfile f2 = new DoctorProfile();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "insert into prescription values('" + comboBox2.Text + "','" + comboBox3.Text + "','" +textBox4.Text + "','" + textBox3.Text + "','" +dateTimePicker1.Value.Date+"','"+textBox1.Text+"','"+comboBox1.Text+"','"+textBox2.Text+"')";
            adddoctorclass ad = new adddoctorclass();
            try
            {
                ad.adddoctor(query);
                MessageBox.Show("Prescription Added Successfully");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            GetDocname();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            GetPatname();
        }
    }
}
