using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConnectionStringLibrary;
using System.Configuration;
using System.Data;

namespace Clinical
{
    class adddoctorclass
    {
        public void adddoctor(string query) 
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ToString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        
        
        }
        
        public void updatedata(string query) 
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ToString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        }

       
        public DataSet showdata(string query) 
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ToString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;

        }
    }
}
