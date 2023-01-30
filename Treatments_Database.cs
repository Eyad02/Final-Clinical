using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinical
{
    public partial class Treatments_Database : Form
    {
        public Treatments_Database()
        {
            InitializeComponent();
        }

        private void Treatments_Load(object sender, EventArgs e)
        {
            populate();
        }

        void populate()
        {
            adddoctorclass ad = new adddoctorclass();
            string query = "select * from treatmentstbl";
            DataSet ds = ad.showdata(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into treatmentstbl values('" + textBox2.Text + "','" + textBox1.Text + "')";
            adddoctorclass ad = new adddoctorclass();
            try
            {
                ad.adddoctor(query);
                MessageBox.Show("Treatment Added Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NurseView nv = new NurseView();
            nv.Show();
            this.Hide();
        }
    }
}
