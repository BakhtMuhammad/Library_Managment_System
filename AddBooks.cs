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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void buttonSaveAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBookName.Text != "" && textBoxBookAuthorName.Text != "" && textBoxBookSubtitle.Text !="" && textBoxBookAccessionNo.Text != "" && textBoxCallNo.Text != "" && textBoxDepartment.Text != "" && textBoxBookVolume.Text != "" && textBoxBookEdition.Text != "" && textBoxBookPublication.Text != "" && textBox5BookPrice.Text != "" && textBoxBookQuantity.Text != "")
                {
                   
                  //  try
                   // {
                    string bname = textBoxBookName.Text;
                    string bauthor = textBoxBookAuthorName.Text;
                    string bsubtitle = textBoxBookSubtitle.Text;
                    string baccessionno = textBoxBookAccessionNo.Text;
                    string bcallno = textBoxCallNo.Text;
                    string bdepart = textBoxDepartment.Text;
                    string bpublisher = textBoxBookPublication.Text;
                    string bdate = dateTimePicker.Text;
                    string bvolume = textBoxBookVolume.Text;
                    string bedition = textBoxBookEdition.Text;
                    Int64 bprice = Int64.Parse(textBox5BookPrice.Text);
                    Int64 bquantity = Int64.Parse(textBoxBookQuantity.Text);
                    //int a = 0;

                    //Database Connectivity
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    //Inserting the values in the database
                    con.Open();
                    cmd.CommandText = "insert into newBook (newBookName, newBookAuthor, newBookSubtitle, newBookAccessionNo, newBookCallNo, newBookDepartment, newBookPublisher, newBookPDate, newBookVolume, newBookEdition, newBookPrice, newBookQuantity)" +
                    " values ('"+bname+ "', '" + bauthor + "','" + bsubtitle + "'," + baccessionno + "," + bcallno + ", '" + bdepart + "','" + bpublisher + "','" + bdate + "','" + bvolume + "','" + bedition + "'," + bprice + "," + bquantity + ")";
                    cmd.ExecuteNonQuery();
                    con.Close();
                   
                    MessageBox.Show("Book Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxBookName.Clear();
                    textBoxBookAuthorName.Clear();
                    textBoxBookSubtitle.Clear();
                    textBoxBookAccessionNo.Clear();
                    textBoxCallNo.Clear();
                    textBoxDepartment.Clear();
                    textBoxBookVolume.Clear();
                    textBoxBookEdition.Clear();

                    textBoxBookPublication.Clear();
                        //dateTimePicker.Clear();
                        textBox5BookPrice.Clear();
                        textBoxBookQuantity.Clear();
                        
                }
               

                else
                {
                    MessageBox.Show("Please make sure all fields are completed.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //"Make sure valid entry in all fields.", MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }
        }

        private void buttonCancelAddBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxBookName.Clear();
            textBoxBookAuthorName.Clear();
            textBoxBookSubtitle.Clear();
            textBoxBookAccessionNo.Clear();
            textBoxCallNo.Clear();
            textBoxDepartment.Clear();
            textBoxBookVolume.Clear();
            textBoxBookEdition.Clear();

            textBoxBookPublication.Clear();
            //dateTimePicker.Clear();
            textBox5BookPrice.Clear();
            textBoxBookQuantity.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
