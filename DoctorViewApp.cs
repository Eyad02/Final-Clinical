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
    public partial class DoctorViewApp : Form
    {
        public DoctorViewApp()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorProfile f2 = new DoctorProfile();
            f2.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void populate()
        {
            adddoctorclass ad = new adddoctorclass();
            string query = "select * from appointmentstbl";
            DataSet ds = ad.showdata(query);
            dataGridView1.DataSource = ds.Tables[0];

        }
        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
