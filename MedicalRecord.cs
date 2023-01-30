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
    public partial class MedicalRecord : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc\\OneDrive\\Desktop\\Database\\database\\Final_Glamourous_Clinic-main\\Project_Clinical_1\\Clinical_DB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        public MedicalRecord()
        {
            InitializeComponent();

        }
        

        private void MedicalRecord_Load(object sender, EventArgs e)
        {
            
        }
        /*private void GetPatName()
        {
            con.Open();
            string query = "select * from patientinfo where national_id=" + comboBox1.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox3.Text = dr["patientname"].ToString();
            }
            con.Close();
        }*/
        /*private void GetPatid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select national_id from patientinfo", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("national_id", typeof(int));
            dt.Load(rdr);
            comboBox1.ValueMember = "national_id";
            comboBox1.DataSource = dt;
            con.Close();
        }*/
        
        private void button1_Click(object sender, EventArgs e)
        {
        DoctorProfile f2 = new DoctorProfile();
        f2.Show();
        this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "insert into medicalRecord values('" + maskedTextBox2.Text + "','" + textBox3.Text +"','"+dateTimePicker1.Value.Date+"','"+textBox1.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')";
            adddoctorclass ad = new adddoctorclass();
            try
            {
                ad.adddoctor(query);
                MessageBox.Show("Medical Record Added Successfully");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
