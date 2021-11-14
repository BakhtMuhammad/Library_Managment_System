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

namespace Library_Management_System
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void buttonSearch_RB_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from IRBook where stdEnroll = '"+textBoxEnterEnroll_RB.Text+"' and bookReturnDate is NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count !=0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid entry", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            try
            {

                //panel1.Visible=false;
                textBoxEnterEnroll_RB.Clear();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                // cmd.CommandText = "Select * from IRBook where bookReturnDate is null";
                cmd.CommandText = "Select id as 'Student ID', stdEnroll as 'Roll No.', stdName as 'Student Name',stdDept  as 'Department',stdSem as 'Semester',stdContact as 'Contact',stdEmail as 'Email',bookName as 'Book Name',bookIssueDate as 'Book Issue Date', bookReturnDate as 'Book Return Date' from IRBook";

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //
        //Loading specific columns from database to text boxes
        //

        Int64 rowid;
        string bookname;
        string bookissuedate;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //panel1.Visible = true;
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    //UPDATE CHANGE CELL VALUE FROM ZERO TO ONE
                    rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    bookname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    bookissuedate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                }
                textBoxBookName_RB.Text = bookname;
                textBoxBookIssueDate_RB.Text = bookissuedate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReturn_RB_Click(object sender, EventArgs e)
        {
            try
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "Update IRBook set bookReturnDate = '" + dateTimePickerBookReturnDate_RB.Text + "' where stdEnroll = '" + textBoxEnterEnroll_RB.Text + "' AND id = " + rowid + "";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Returned Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReturnBook_Load(this, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExit_RB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_RB_Click(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBoxEnterEnroll_RB_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEnterEnroll_RB.Text =="")
            {
                //panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void buttonRefresh_RB_Click(object sender, EventArgs e)
        {
            textBoxEnterEnroll_RB.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //
        //VERSION 2 UPDATE: HERE I USED "ROW_POST_PAINT" EVENT FOR SERIAL NO GENERATION.
        //

        //private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{
        //    dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        //}
    }
}
