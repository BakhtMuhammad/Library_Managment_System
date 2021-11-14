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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void buttonExit_AddS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Alert", MessageBoxButtons.YesNo)==DialogResult.Yes)
            this.Close();
        }

        //private void buttonRefresh_AddS_Click(object sender, EventArgs e)
        //{
        //    textBoxStudentName_AddS.Clear();
        //    textBoxEnrollNo_AddS.Clear();
        //    textBoxDepartment_AddS.Clear();
        //    textBoxSemester_AddS.Clear();
        //    textBoxStudetContact_AddS.Clear();
        //    textBoxStudentMail_AddS.Clear();

        //}

        private void buttonSaveInfo_AddS_Click(object sender, EventArgs e)
        {
            try
                {
                if (textBoxStudentName_AddS.Text != "" && textBoxEnrollNo_AddS.Text != "" && textBoxDepartment_AddS.Text != "" && textBoxSemester_AddS.Text != "" && textBoxStudetContact_AddS.Text != "" && textBoxStudentMail_AddS.Text != "")
                {
                    //sname, sEnroll, sDep, sSem, sCont, sMail
                    string sname = textBoxStudentName_AddS.Text;
                    string sEnroll = textBoxEnrollNo_AddS.Text;
                    string sDep = textBoxDepartment_AddS.Text;
                    string sSem = textBoxSemester_AddS.Text;
                    Int64 sCont = Int64.Parse(textBoxStudetContact_AddS.Text);
                    string sMail = textBoxStudentMail_AddS.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source = DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog = 'LMS'; Integrated Security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Insert into newStudent (stuName, stuEnrollNo, stuDepartment, stuSemester, stuContact, stuMail) values ('" + sname + "', '" + sEnroll + "', '" + sDep + "','" + sSem + "'," + sCont + ", '" + sMail + "')";

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    MessageBox.Show("New Student Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxStudentName_AddS.Clear();
                    textBoxEnrollNo_AddS.Clear();
                    textBoxDepartment_AddS.Clear();
                    textBoxSemester_AddS.Clear();
                    textBoxStudetContact_AddS.Clear();
                    textBoxStudentMail_AddS.Clear();

                }

                else
                {
                    MessageBox.Show("Please fill all the required fills.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                //string message = "Plase make sure valide entry.";
                MessageBox.Show(ex.Message, "Make sure a valid entry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_AddS_Click(object sender, EventArgs e)
        {
            textBoxStudentName_AddS.Clear();
            textBoxEnrollNo_AddS.Clear();
            textBoxDepartment_AddS.Clear();
            textBoxSemester_AddS.Clear();
            textBoxStudetContact_AddS.Clear();
            textBoxStudentMail_AddS.Clear();
        }
    }
}
