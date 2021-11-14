using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Library_Management_System
{
    public partial class SendCode : Form
    {
        string randomCode;
        public static string to;
        public SendCode()
        {
            InitializeComponent();
        }

        private void buttonSendCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEmail.Text != "")
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(9999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (textBoxEmail.Text).ToString();
                    from = "daksonlms@gmail.com";
                    pass = "#Pa55word";
                    messageBody = "Your reset code is " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Password Resetting Code";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code sent successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Entry.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if(randomCode== (textBoxVerifyCode.Text).ToString())
            {
                to = textBoxEmail.Text;
                ResetPassword rp = new ResetPassword();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Code Entered.");
            }
        }

        private void SendCode_Load(object sender, EventArgs e)
        {

        }
    }
}
