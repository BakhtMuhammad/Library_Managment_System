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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxUserName.Text == "User Name")
            {
                textBoxUserName.Clear();
            }
            //else
            //{
            //    textBoxPassword.Text = "Password";
            //}
        }

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Clear();
                textBoxPassword.PasswordChar = '*';
            }
            //else
            //{
            //    textBoxUserName.Text = "User Name";
            //}
        }

       

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/daksoninstitute/");
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            this.Hide();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //SQL Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from userRegistrationTable where userName='" + textBoxUserName.Text + "' and userPassword = '" + textBoxPassword.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count !=0)
            {
                this.Hide();
                DashBoard dashboard = new DashBoard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("User name or Password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SendCode sc = new SendCode();
            sc.Show();
            this.Hide();
        }
    }
}
