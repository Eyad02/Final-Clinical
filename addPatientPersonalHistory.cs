
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace Clinical
{
    public partial class addPatientPersonalHistory : Form
    {
        static string pfilename; 
        public addPatientPersonalHistory()
        {
            InitializeComponent();
        }

        private void PatientPersonalHistory_Load(object sender, EventArgs e)
        {

        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddElectronicMedicalHistory f2 = new AddElectronicMedicalHistory();
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
            string query = "insert into patientinfo values('"+maskedTextBox1.Text+"','"+Pname.Text+"','"+Email.Text+"','"+maskedTextBox4.Text+"','"+comboBox2.Text+"','"+Page.Text+"','"+dateTimePicker1.Value.Date+"','"+textBox2.Text+"','"+textBox3.Text+"','"+comboBox6.Text+"','"+comboBox1.Text+"','"+ Salary.Text+"','"+Address.Text+"','"+no_of_children.Text+"','"+ParentName.Text+"','"+insurancecompany.Text+"','"+insurancePhone.Text+"','"+insuranceAddress.Text+"','"+ Path.GetFileName(pfilename).ToString() + "')";
            adddoctorclass add = new adddoctorclass();
            try
            {
                add.adddoctor(query);
                MessageBox.Show("Patient Info Inserted");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Pname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Page_TextChanged(object sender, EventArgs e)
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
                    pfilename = Path.GetFileName(op.FileName);
                    string FileSavePath = Path.Combine(saveDirectory, pfilename);
                    File.Copy(op.FileName, FileSavePath, true);
                    pictureBox3.Image = new Bitmap(op.FileName);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    textBox1.Text = pfilename.ToString();

                }
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
