using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AllBooks : Form
    {
        public AllBooks()
        {
            InitializeComponent();
        }
        ReportDocument rd;

        private void AllBooks_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("select * from newBook", con);
                cmd.Connection = con;


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                rd = new ReportDocument();

                rd.Load(Application.StartupPath + "\\Reports\\CrystalReportAllBooks.rpt");
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
