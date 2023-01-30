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
    public partial class FollowUp : Form
    {
        public FollowUp()
        {
            InitializeComponent();
        }

        private void FollowUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorProfile f2 = new DoctorProfile();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "insert into followup values('" +maskedTextBox2.Text+ "','" + textBox2.Text + "','" + dateTimePicker1.Value.Date + "','" + textBox1.Text + "','" + textBox4.Text +"','"+comboBox2.Text+"','"+comboBox4.Text+"','"+textBox3.Text+"','"+comboBox8.Text+"','"+textBox5.Text+"')";
            adddoctorclass ad = new adddoctorclass();
            try
            {
                ad.adddoctor(query);
                MessageBox.Show("Follow Up Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
