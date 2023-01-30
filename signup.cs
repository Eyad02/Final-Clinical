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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string query = "insert into Nurseinf values('" + maskedTextBox2.Text + "','" + textBox12.Text + "','" + textBox11.Text + "','" + textBox8.Text + "','" + maskedTextBox1.Text + "','" + dateTimePicker2.Value.Date + "','" + textBox9.Text + "','" + comboBox2.Text + "')";
            adddoctorclass add = new adddoctorclass();
            try
            {
                add.adddoctor(query);
                MessageBox.Show("Nurse Inserted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NurseLogin nl = new NurseLogin();
            nl.Show();
            this.Hide();
        }
    }
}
