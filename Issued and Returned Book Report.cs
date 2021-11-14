using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Issued_and_Returned_Book_Report : Form
    {
        public Issued_and_Returned_Book_Report()
        {
            InitializeComponent();
        }
        ReportDocument rd;

        private void crystalReportViewer3_Load(object sender, EventArgs e)
        {

        }

        private void Issued_and_Returned_Book_Report_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("select * from IRBook", con);
                cmd.Connection = con; 


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                rd = new ReportDocument();

                rd.Load(Application.StartupPath + "\\Reports\\CrystalReportIRBook.rpt");
                rd.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                if (rd != null)
                {
                    rd.Close();
                }
            }
        }
    }
    
}
