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
    public partial class Appointment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=EYAD-EL-HAWARY\\SQLEXPRESS;Initial Catalog=Orthopedic_DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Appointment()
        {
            InitializeComponent();
            
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

            populate();
            GetPatid();
            GetPatname();
            /*GettreName();*/
            

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
            comboBox1.ValueMember = "national_id";
            comboBox1.DataSource = dt;
            con.Close();

        }
        private void GetPatname()
        {
            con.Open();
            string query = "select * from patientinfo where national_id=" + comboBox1.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1.Text = dr["patientname"].ToString();
            }
            con.Close();
        }
        /*private void GettreName()
        {
            con.Open();
            string query = "select tname from treatmentstbl";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("tname", typeof(string));
            dt.Load(rdr);
            comboBox2.ValueMember = "tname";
            comboBox2.DataSource = dt;
            con.Close();

        }*/
        public void populate()
        {
            adddoctorclass ad = new adddoctorclass();
            string query = "select * from appointmentstbl";
            DataSet ds = ad.showdata(query);
            dataGridView1.DataSource = ds.Tables[0]; 
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into appointmentstbl values('" + comboBox1.Text+"','"+textBox1.Text+"','" + dateTimePicker1.Value.Date + "','"+dateTimePicker4.Value.TimeOfDay+"')";
            adddoctorclass ad = new adddoctorclass();
            try
            {
                ad.adddoctor(query);
                MessageBox.Show("Appointment Added Successfully");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            string query = "update appointmentstbl set pid = '" + comboBox1.Text + "',pname='" + textBox1.Text + "',date='" + dateTimePicker1.Value.Date+ "',time='" +dateTimePicker4.Value.TimeOfDay+"' where pid = "+comboBox1.Text+ ";" ;
            adddoctorclass ad = new adddoctorclass();
            
            try
            {
                ad.updatedata(query);
                MessageBox.Show("Appointment Updated Successfully");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adddoctorclass ad = new adddoctorclass();
            
                
            try
            {
                string query = "delete from [appointmentstbl] where  pid = "+ comboBox1.Text+""  ;
                ad.updatedata(query);
                MessageBox.Show("Appointment deleted Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            NurseView nv = new NurseView();
            nv.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetPatname();
        }
    }
}
