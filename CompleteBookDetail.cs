using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagedList;

namespace Library_Management_System
{
    public partial class CompleteBookDetail : Form
    {
        public CompleteBookDetail()
        {
            InitializeComponent();
        }

        private void CompleteBookDetail_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select id as 'id', stdEnroll as 'Student Roll No', stdName as 'Name', stdDept as 'Department', stdSem as 'Semester', stdContact as 'Contact', stdEmail as 'Email', bookName as 'Book Name', bookIssueDate as 'Book Issue Date', bookReturnDate as 'Book Return Date' from IRBook where bookReturnDate is null";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            cmd.CommandText = "Select id as 'id',stdEnroll as 'Student Roll No', stdName as 'Name', stdDept as 'Department', stdSem as 'Semester', stdContact as 'Contact', stdEmail as 'Email', bookName as 'Book Name', bookIssueDate as 'Book Issue Date', bookReturnDate as 'Book Return Date' from IRBook where bookReturnDate is not null";
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
            // this.reportViewer1.RefreshReport();
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //Print Issue Book Button
        //private void button1_Click(object sender, EventArgs e)
        //{

        //}


        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    Bitmap bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
        //    dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
        //    e.Graphics.DrawImage(bitmap, 0, 0);
        //}
        //
        //Code for Excel
        //
        private void buttonExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excellapp = new Microsoft.Office.Interop.Excel.Application();
                excellapp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    excellapp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excellapp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excellapp.Columns.AutoFit();
                excellapp.Visible = true;
            }
        }

        //
        //Export to EXCEL Button
        //

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView2.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excellapp = new Microsoft.Office.Interop.Excel.Application();
                excellapp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
                {
                    excellapp.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        excellapp.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excellapp.Columns.AutoFit();
                excellapp.Visible = true;
            }
        }
        //
        //Version 2
        //
        //private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{
        //    dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        //}

        ////
        ////VERSION 2 UPDATE: HERE I USED "ROW_POST_PAINT" EVENT FOR SERIAL NO. GENERATION.
        ////

        //private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{
        //    dataGridView2.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        //}
    }
}
