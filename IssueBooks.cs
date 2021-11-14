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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand ("select newBookName from newBook",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                for(int i=0; i<dr.FieldCount; i++)
                {
                    comboBoxBookName_IB.Items.Add(dr.GetString(i));
                }
            }
            dr.Close();
            con.Close();
        }

        int count;
        private void buttonSearch_IB_Click(object sender, EventArgs e)
        {
            if (textBoxEnterRollNo_IB.Text !="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from newStudent where stuEnrollNo = '"+textBoxEnterRollNo_IB.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                /////////////////////////////////////////
                ////Code to check how many books have been issued to this Enrollment Number
                //cmd.CommandText = "Select count(stdEnroll) from IRBook where stdEnroll= '" + textBoxEnterRollNo_IB.Text + "' and bookReturnDate is NULL";
                //SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                //DataSet ds1 = new DataSet();
                //sda.Fill(ds1);
                //count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                ///////////////////////////////////////

                if (ds.Tables[0].Rows.Count !=0)
                {
                    textBoxStuName_IB.Text = ds.Tables[0].Rows[0][1].ToString();
                    textBoxDept_IB.Text = ds.Tables[0].Rows[0][3].ToString();
                    textBoxStuSem_IB.Text = ds.Tables[0].Rows[0][4].ToString();
                    textBoxStuCont_IB.Text = ds.Tables[0].Rows[0][5].ToString();
                    textBoxStuEmail_IB.Text = ds.Tables[0].Rows[0][6].ToString();
                   
                }
                else
                {
                    textBoxStuName_IB.Clear();
                    textBoxDept_IB.Clear();
                    textBoxStuSem_IB.Clear();
                    textBoxStuCont_IB.Clear();
                    textBoxStuEmail_IB.Clear();
                    MessageBox.Show("Invalid entry", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }

            }
        }
      

        private void buttonRefresh_IB_Click(object sender, EventArgs e)
        {
            textBoxEnterRollNo_IB.Clear();
        }

        private void buttonIssueBook_Click(object sender, EventArgs e)
        {
            if(textBoxStuName_IB.Text !="")
            {
                if (comboBoxBookName_IB.SelectedIndex !=-1 && count <=2)
                {
                    string enroll = textBoxEnterRollNo_IB.Text;
                    string name = textBoxStuName_IB.Text;
                    string dep = textBoxDept_IB.Text;
                    string sem = textBoxStuSem_IB.Text;
                    Int64 cont = Int64.Parse(textBoxStuCont_IB.Text);
                    string email = textBoxStuEmail_IB.Text;
                    string bookname = comboBoxBookName_IB.Text;
                    string bookissue = dateTimePickerBookIssueD.Text;

                    /*
                                                                                                                                                                
                      */                                                                                                                                   
                    SqlConnection con = new SqlConnection();                                                                                               
                    con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "Insert into IRBook(stdEnroll, stdName, stdDept, stdSem, stdContact, stdEmail, bookName,bookIssueDate) values('"+enroll+"','"+name+"', '"+dep+"', '"+sem+"',"+cont+", '"+email+"', '"+bookname+"', '"+bookissue+"')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Issued Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show(" book is not available /Make valid entery/Can't issue more than 3 books per student.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid Entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxStuName_IB.Clear();
            textBoxDept_IB.Clear();
            textBoxStuSem_IB.Clear();
            textBoxStuCont_IB.Clear();
            textBoxStuEmail_IB.Clear();
            comboBoxBookName_IB.Text = "";
        }

        private void buttonExit_IB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            this.Close();
        }

        private void textBoxEnterRollNo_IB_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEnterRollNo_IB.Text=="")
            {
                textBoxStuName_IB.Clear();
                textBoxStuCont_IB.Clear();
                textBoxStuEmail_IB.Clear();
                textBoxStuSem_IB.Clear();
                textBoxDept_IB.Clear();
            }
        }

        private void textBoxStuName_IB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
