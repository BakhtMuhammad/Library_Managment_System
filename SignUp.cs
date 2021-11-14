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
using System.Security.Cryptography;

namespace Library_Management_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

           
        }

        //Encrytption method
        static string Encrypt(string value)
        {
            using(MD5CryptoServiceProvider md5= new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //Encrypt(textBoxPassword.Text);
            if (textBoxPassword.Text != textBoxRetypePass.Text)
            {
                MessageBox.Show("Password doesn't match. Please type again.");
            }
            else
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                //Inserting the values in the database
                con.Open();
                cmd.CommandText = "insert into userRegistrationTable (firstName, lastName, username, userPassword) values ('" + textBoxFirstName.Text + "', '" + textBoxLastName.Text + "','" + textBoxUserName.Text + "','" + Encrypt(textBoxPassword.Text) + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                

                MessageBox.Show("User Registered Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
