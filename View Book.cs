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
    public partial class View_Book : Form
    {
        public View_Book()
        {
            InitializeComponent();
        }

        private void View_Book_Load(object sender, EventArgs e)
        {
            try
            {
                panel_ViewBook.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                //cmd.CommandText = "Select ROW_Number() over (Order by newBookName) as SerialNo, newBookID as 'Book ID', newBookName as 'Book Name', newBookAuthor as 'Book Author', newBookPublish as 'Book Publisher', newBookPDate as 'Book Publish Date', newBookPrice as 'Book Price', newBookQuantity as 'Book Quantity' from newBook";
               //Select ROW_Number() over(Order by stuName) as SerialNo, newStudentID as 'Student ID', stuName as 'Student Name', stuEnrollNo as 'Roll No.', stuDepartment as 'Department', stuSemester as 'Semester', stuContact as 'Contact', stuMail as 'Email'  from newStudent";
                cmd.CommandText = "select newBookID as 'Book ID', newBookName as 'Book Name', newBookAuthor  as 'Author', newBookSubtitle as 'Subtitle', newBookAccessionNo as 'AccessionNo', newBookCallNo as 'CallNo', newBookDepartment as 'Department', newBookPublisher as 'Publisher', newBookPDate as 'Purchase Date',newBookVolume as 'Volume', newBookEdition as 'Edition', newBookPrice as 'Price', newBookQuantity as 'Quantity' from newBook";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                //Filling the datagridview

                dataGridView_ViewBook.DataSource = ds.Tables[0];
                //panel_ViewBook.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning", ex.Message);
            }

        }
       

        private void dataGridView_ViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView_ViewBook.Text = "Book ID";
           // dataGridView_ViewBook.Columns["newBookName"].HeaderText = "Book Name";


        }
        //
        // GLOBAL VARIABLES
        //
        int newBookID;
        Int64 rowID;
        //private readonly object DataControlRowType;

        //
        //
        //
        private void dataGridView_ViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView_ViewBook.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    //
                    //VERSION 2 UPDATE: HERE IS THE LINE WHERE I CHANGED CELLS VALUE FROM 0 TO 1
                    //
                    newBookID = int.Parse(dataGridView_ViewBook.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                panel_ViewBook.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "Select * from newBook where newBookID=" + newBookID + "";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                //Loading the data from gridview to panel
                // rowID = Int64.Parse(ds.Tables[0].Rows[0][2].ToString());
                //    if(ds.Tables[0].Rows.Count>=0)

                rowID = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                //  else
                // {
                //     MessageBox.Show("Error");
                // }
                //
                // VERSION 1.2 UPDATE HERE
                //
                //textBoxBookName_ViewBook.Text = ds.Tables[0].Rows[0][1].ToString();
                //textBoxBookAuthor_ViewBook.Text = ds.Tables[0].Rows[0][2].ToString();
                //textBoxBookPublication_ViewBook.Text = ds.Tables[0].Rows[0][3].ToString();
                //textBoxBookPurchaseDate.Text = ds.Tables[0].Rows[0][4].ToString();
                //textBoxBookPrice_ViewBook.Text = ds.Tables[0].Rows[0][5].ToString();
                //textBoxBookQuantity_ViewBook.Text = ds.Tables[0].Rows[0][6].ToString();

                textBoxBookName_ViewBook.Text = ds.Tables[0].Rows[0][1].ToString();
                textBoxBookAuthor_ViewBook.Text = ds.Tables[0].Rows[0][2].ToString();
                textBoxBookSubtitle_ViewBook.Text = ds.Tables[0].Rows[0][3].ToString();
                textBoxBookAccessionNo_ViewBook.Text = ds.Tables[0].Rows[0][4].ToString();
                textBoxBookCallNo_ViewBook.Text = ds.Tables[0].Rows[0][5].ToString();
                textBoxBookDepartment_ViewBook.Text = ds.Tables[0].Rows[0][6].ToString();
                textBoxBookPublication_ViewBook.Text = ds.Tables[0].Rows[0][7].ToString();
                textBoxBookPurchaseDate.Text = ds.Tables[0].Rows[0][8].ToString();
                textBoxBookVolume_ViewBook.Text = ds.Tables[0].Rows[0][9].ToString();
                textBoxBookEdition_ViewBook.Text = ds.Tables[0].Rows[0][10].ToString();
                textBoxBookPrice_ViewBook.Text = ds.Tables[0].Rows[0][11].ToString();
                textBoxBookQuantity_ViewBook.Text = ds.Tables[0].Rows[0][12].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning", ex.Message);
            }
        }
        private void buttonCancel_ViewBook_Click(object sender, EventArgs e)
        {
            //panel_ViewBook.Visible = false;
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void textBoxBookName_RefreshButton_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBookName_RefreshButton.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Select * from newBook where newBookName LIKE'" + textBoxBookName_RefreshButton.Text + "%'";

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    dataGridView_ViewBook.DataSource = ds.Tables[0];
                }
                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Select * from newBook"; //where newBookName LIKE '" + textBoxBookName_RefreshButton.Text + "%'";
                   

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    dataGridView_ViewBook.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning", ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxBookName_RefreshButton.Clear();
           // panel_ViewBook.Visible = false;
        }

        private void buttonUpdate_ViewBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to update the table?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Update Successful.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string bname = textBoxBookName_ViewBook.Text;
                    string bauthor = textBoxBookAuthor_ViewBook.Text;
                    string bsubtitle = textBoxBookSubtitle_ViewBook.Text;
                    string baccessionno = textBoxBookAccessionNo_ViewBook.Text;
                    string bcallno = textBoxBookCallNo_ViewBook.Text;
                    string bdepart = textBoxBookDepartment_ViewBook.Text;
                    string bpublisher = textBoxBookPublication_ViewBook.Text;
                    string bdate = textBoxBookPurchaseDate.Text;
                    string bvolume = textBoxBookVolume_ViewBook.Text;
                    string bedition = textBoxBookEdition_ViewBook.Text;
                    Int64 bprice = Int64.Parse(textBoxBookPrice_ViewBook.Text);
                    Int64 bquantity = Int64.Parse(textBoxBookQuantity_ViewBook.Text);


                    //string bookname = textBoxBookName_ViewBook.Text;
                    //string bookauthor = textBoxBookAuthor_ViewBook.Text;
                    //string publication = textBoxBookPublication_ViewBook.Text;
                    //string update = textBoxBookPurchaseDate.Text;
                    //Int64 price = Int64.Parse(textBoxBookPrice_ViewBook.Text);
                    //Int64 quantity = Int64.Parse(textBoxBookQuantity_ViewBook.Text);
                    //SQL connection
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Update newBook set newBookName ='" + bname + "', newBookAuthor ='" + bauthor + "',newBookSubtitle ='" + bsubtitle + "', newBookAccessionNo =" + baccessionno + ", newBookCallNo=" + bcallno + ",newBookDepartment ='" + bdepart + "', newBookPublisher ='" + bpublisher + "', newBookPDate ='" + bdate + "',newBookVolume ='" + bvolume + "',newBookEdition ='" + bedition + "' ,newBookPrice =" + bprice + ", newBookQuantity =" + bquantity + " where newBookID=" + rowID + "";

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    View_Book_Load(this, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_ViewBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete the selected record?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show("Deleted Successfully.");
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=DESKTOP-2M6S92M\SQLEXPRESS; Initial Catalog='LMS'; Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Delete from newBook where newBookID =" + rowID + "";

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    View_Book_Load(this, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning", ex.Message);
            }
        }

        private void panel_ViewBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxBookPublication_ViewBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBookPurchaseDate_TextChanged(object sender, EventArgs e)
        {

        }

        //
        //VERSION 2 UPDATE: HERE I USED "ROW_POST_PAINT" EVENT FOR SERIAL NO GENERATION.
        //

        private void dataGridView_ViewBook_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView_ViewBook.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
