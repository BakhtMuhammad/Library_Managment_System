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
    public partial class ResetPassword : Form
    {
        string username = SendCode.to;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == textBoxRetypePassword.Text)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Update loginTable SET password ='" + textBoxRetypePassword.Text + "' where username = '" + username + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Updated Successfully");
            }
            else
            {
                MessageBox.Show("The new password doesn't match, please make sure the correct one.");
            }
        }

        private void buttonResetPLogin_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
