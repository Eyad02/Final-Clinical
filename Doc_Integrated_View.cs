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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinical
{
    public partial class Doc_Integrated_View : Form
    {
        SqlConnection sqlcon;
        SqlDataAdapter sqladp;
        DataTable data = new DataTable();
        int pos;

        public Doc_Integrated_View()
        {
            InitializeComponent();
        }

        private void Doc_Integrated_View_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(@"Data Source=EYAD-EL-HAWARY\SQLEXPRESS;Initial Catalog=Orthopedic_DB;Integrated Security=True");
            sqladp = new SqlDataAdapter("select Xray, labresults, patim from patientmedicalinfo, patientinfo", sqlcon);
            sqladp.Fill(data);
            pos = 0;

        }

        public void populatepersonal()
        {
            adddoctorclass ad = new adddoctorclass();
            string query = "select * from patientinfo where national_id = " + maskedTextBox2.Text + ";";
            DataSet ds = ad.showdata(query);
            patp.DataSource = ds.Tables[0];
        }

        public void populatemedical()
        {
            adddoctorclass ad = new adddoctorclass();
            string query = "select patientname, height, weigth, bloodtype, bloodpressure1, bloodpressure2, vitaminD, Anemia, bodytemp, cholesterol, bloodglucose, visit_orthopedic, did_a_surgery, allergies, allergic_to_any_medicine, taking_any_medicine, breathingdisorder, Asthma, additionalinfo from patientmedicalinfo where national_id = " + maskedTextBox2.Text + ";";
            DataSet ds = ad.showdata(query);
            patm.DataSource = ds.Tables[0];
        }

        public void displaytext(int rono)
        {
            string p = data.Rows[rono][2].ToString();
            string i = Path.GetDirectoryName(Application.ExecutablePath) + @"\demoimage\" + p;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load(i);
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xray_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            populatepersonal();
            populatemedical();
            displaytext(pos);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorProfile dp = new DoctorProfile();
            dp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void patm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Labresults lr = new Labresults();
            lr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Xray_Zoom ts = new Xray_Zoom();
            ts.Show();

        }
    }
}
