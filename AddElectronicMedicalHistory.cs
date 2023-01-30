using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace Clinical
{
    public partial class AddElectronicMedicalHistory : Form
    {
        static string labfilename;
        static string Xfilename;
        public AddElectronicMedicalHistory()
        {
            InitializeComponent();
        }

        private void PatientMedicalHistory_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addPatientPersonalHistory f2 = new addPatientPersonalHistory();
            f2.Show();
            linkLabel1.LinkVisited = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPerson f2 = new AddPerson();
            f2.Show();
            this.Hide();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "insert into patientmedicalinfo values('" + pname.Text + "','" + maskedTextBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + bloodtype.Text + "','" + bloodpressure.Text + "','" + textBox3.Text + "','" + vitamined.Text + "','" + anemia.Text + "','" + bodytemprature.Text + "','" + cholesterol.Text + "','" + bloodglucose.Text + "','" + visitedOrthopedist.Text + "','" + haveyousurgery.Text + "','" + textBox7.Text + "','" + allergic.Text + "','" + takingMedicatio.Text  + "','"+ breathingdis.Text + "','"+comboBox6.Text+"','" +textBox6.Text+"','"+ Path.GetFileName(Xfilename).ToString() + "','"+ Path.GetFileName(labfilename).ToString() + "')";
            adddoctorclass add = new adddoctorclass();
            try
            {
                add.adddoctor(query);
                MessageBox.Show("Patient Medical Info Inserted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            string saveDirectory = Path.GetDirectoryName(Application.ExecutablePath) + @"\demoimage\";
            using (OpenFileDialog op = new OpenFileDialog())
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(saveDirectory))
                    {
                        Directory.CreateDirectory(saveDirectory);

                    }
                    Xfilename = Path.GetFileName(op.FileName);
                    string FileSavePath = Path.Combine(saveDirectory, Xfilename);
                    File.Copy(op.FileName, FileSavePath, true);
                    pictureBox1.Image = new Bitmap(op.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    textBox2.Text = Xfilename.ToString();

                }
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
           
            string saveDirectory = Path.GetDirectoryName(Application.ExecutablePath) + @"\demoimage\";
            using (OpenFileDialog op = new OpenFileDialog())
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(saveDirectory))
                    {
                        Directory.CreateDirectory(saveDirectory);

                    }
                    labfilename = Path.GetFileName(op.FileName);
                    string FileSavePath = Path.Combine(saveDirectory, labfilename);
                    File.Copy(op.FileName, FileSavePath, true);
                    pictureBox3.Image = new Bitmap(op.FileName);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    textBox1.Text = labfilename.ToString();

                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bodytemprature_TextChanged(object sender, EventArgs e)
        {
            
        }
       

        private void bodytemprature_Leave_1(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(bodytemprature.Text, out box_int);
            if (box_int < 37 && bodytemprature.Text != "")
            {
                bodytemprature.Text = "37";
                MessageBox.Show("minimum Allowed Number is 37");

            }
            else if (box_int > 42 && bodytemprature.Text != "")
            {
                bodytemprature.Text = "42";
                MessageBox.Show("Maximum Allowed Number is 42");
            }
        }

        private void bloodpressure_TextChanged(object sender, EventArgs e)
        {

        }
        private void bloodpressure_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_Leave(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bloodpressure_Leave_1(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(bloodpressure.Text, out box_int);
            if (box_int < 110 && bloodpressure.Text != "")
            {
                bloodpressure.Text = "110";
                MessageBox.Show("minimum Allowed Number is 110");

            }
            else if (box_int > 220 && bloodpressure.Text != "")
            {
                bloodpressure.Text = "220";
                MessageBox.Show("Maximum Allowed Number is 220");
            }
        }

        private void textBox3_Leave_1(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(textBox3.Text, out box_int);
            if (box_int < 70 && textBox3.Text != "")
            {
                textBox3.Text = "70";
                MessageBox.Show("minimum Allowed Number is 70");

            }
            else if (box_int > 130 && textBox3.Text != "")
            {
                textBox3.Text = "130";
                MessageBox.Show("Maximum Allowed Number is 130");
            }
        }

        private void bloodglucose_TextChanged(object sender, EventArgs e)
        {

        }

        private void bloodglucose_Leave(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(bloodglucose.Text, out box_int);
            if (box_int < 80 && bloodglucose.Text != "")
            {
                bloodglucose.Text = "80";
                MessageBox.Show("minimum Allowed Number is 80");

            }
            else if (box_int > 300 && bloodglucose.Text != "")
            {
                bloodglucose.Text = "300";
                MessageBox.Show("Maximum Allowed Number is 300");
            }
        }
    }
}
