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
    public partial class NurseView : Form
    {
        public NurseView()
        {
            InitializeComponent();
        }

        private void NurseView_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddPerson f2 = new AddPerson();
            f2.Show(); 
            linkLabel5.LinkVisited = true;
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Appointment f2 = new Appointment();
            f2.Show();
            linkLabel1.LinkVisited = true;
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addPatientPersonalHistory f2 = new addPatientPersonalHistory();
            f2.Show();
            linkLabel2.LinkVisited = true;
            this.Hide();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DoctorLogin lg = new DoctorLogin();
            lg.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Appointment ap = new Appointment();
            ap.populate();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OCR ocr = new OCR();
            ocr.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Treatments_Database tr = new Treatments_Database();
            tr.Show();
            this.Hide();
        }

        public void populate()
        {
            adddoctorclass ad = new adddoctorclass();
            string query = "select * from appointmentstbl";
            DataSet ds = ad.showdata(query);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
