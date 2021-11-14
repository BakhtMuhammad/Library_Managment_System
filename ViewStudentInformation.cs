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
    public partial class a : Form
    {
        public a()
        {
            InitializeComponent();
        }

        private void textBoxSearch_ViewStuInfo_TextChanged(object sender, EventArgs e)
        {
           try
            {
                if (textBoxSearch_ViewStuInfo.Text != "")
                {
                    //label1.Visible = false;
                   // Image img = Image.FromFile(@"D:\Visual Studio 2015\Icons and Images\GIF.gif");
                    //pictureBox1.Image = img;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source = DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog = 'LMS'; Integrated Security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Select * from newStudent where stuEnrollNo LIKE '" + textBoxSearch_ViewStuInfo.Text + "%' ";

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    label1.Visible = true;
                   // Image img = Image.FromFile(@"D:\Visual Studio 2015\Icons and Images\GIF.gif");
                   // pictureBox1.Image = img;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source = DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog = 'LMS'; Integrated Security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Select * from newStudent where stuEnrollNo LIKE '" + textBoxSearch_ViewStuInfo.Text + "%' ";
                

                // cmd.CommandText = "Select * from newStudent";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];

                }
          }
            catch(Exception ex)
         {
                MessageBox.Show(ex.Message);            }
         }

        private void a_Load(object sender, EventArgs e)
        {                                                                                             
     
            //panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog = 'LMS'; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "Select ROW_Number() over (Order by stuName) as SerialNo, newStudentID as 'Student ID', stuName as 'Student Name', stuEnrollNo as 'Roll No.', stuDepartment as 'Department', stuSemester as 'Semester', stuContact as 'Contact', stuMail as 'Email'  from newStudent";
            cmd.CommandText = "Select newStudentID as 'Student ID',stuEnrollNo as 'Roll No.', stuName as 'Student Name',  stuDepartment as 'Department', stuSemester as 'Semester', stuContact as 'Contact', stuMail as 'Email'  from newStudent";
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            panel2.Show();
        }

        int bid;
        Int64 rowid;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //
        }

        private void buttonUpdate_ViewStuInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to update the table?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Data Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string stuname = textBoxStuName_ViewStuInfo.Text;
                    string sturoll = textBoxEnrollPanel_ViewStuInfo.Text;
                    string studep = textBoxDept_ViewStuInfo.Text;
                    string stusem = textBoxStuSem_ViewStuInfo.Text;
                    Int64 stucon = Int64.Parse(textBoxStuCont_ViewStuInfo.Text);
                    string stuemail = textBoxStuEmail_ViewStuInfo.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source = DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog = 'LMS'; Integrated Security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Update newStudent set stuName ='" + stuname + "', stuEnrollNo ='" + sturoll + "', stuDepartment ='" + studep + "', stuSemester ='" + stusem + "', stuContact =" + stucon + ", stuMail ='" + stuemail + "' where newStudentID = " + rowid + "";

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    a_Load(this, null);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //
                //VERSION 2 UPDATE: HERE IS THE LINE WHERE I CHANGED CELLS VALUE FROM 0 TO 1
                //

                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                panel2.Visible = true;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog = 'LMS'; Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from newStudent where newStudentID = " + bid + "";

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                textBoxStuName_ViewStuInfo.Text = ds.Tables[0].Rows[0][1].ToString();
                textBoxEnrollPanel_ViewStuInfo.Text = ds.Tables[0].Rows[0][2].ToString();
                textBoxDept_ViewStuInfo.Text = ds.Tables[0].Rows[0][3].ToString();
                textBoxStuSem_ViewStuInfo.Text = ds.Tables[0].Rows[0][4].ToString();
                textBoxStuCont_ViewStuInfo.Text = ds.Tables[0].Rows[0][5].ToString();
                textBoxStuEmail_ViewStuInfo.Text = ds.Tables[0].Rows[0][6].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void buttonDelete_ViewStuInfo_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to delete the record?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source = DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog = 'LMS'; Integrated Security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Delete from newStudent where newStudentID=" + rowid + "";

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    a_Load(this, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_ViewStuInfo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonRefresh_ViewStuInfo_Click(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog = 'LMS'; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select newStudentID as 'Student ID',stuEnrollNo as 'Roll No.', stuName as 'Student Name',  stuDepartment as 'Department', stuSemester as 'Semester', stuContact as 'Contact', stuMail as 'Email'  from newStudent";
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            panel2.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //
        //VERSION 2 UPDATE: HERE I USED "ROW_POST_PAINT" EVENT FOR SERIAL NO GENERATION.
        //

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void textBoxEnrollPanel_ViewStuInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
