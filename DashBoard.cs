using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to exit software?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // if (MessageBox.Show("Are you sure to exit software?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
           // {
                Application.Exit();
           // }
        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks addbooks = new AddBooks();
            addbooks.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Book viewbook = new View_Book();
            viewbook.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addstu = new AddStudent();
            addstu.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a viewStuInfo = new a();
            viewStuInfo.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks issuebooks = new IssueBooks();
            issuebooks.Show();
        }

        private void returnedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetail cbd = new CompleteBookDetail();
            cbd.Show();
        }

        private void finalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    FinalReport fr = new FinalReport();
        //    fr.Show();
        //   // CompleteBookDetail cv = new CompleteBookDetail();
            //cv.Show();
        }

        private void licenseAgreementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            License_Agreement la = new License_Agreement();
            la.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Help hp = new Help();
            //hp.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            label2.Text = "DAKSON Institute of Health Sciences";
            //button2.Hide();
            //button3.Hide();
            //button1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Ali College of Pharmacy Technician";
            //button1.Hide();
            //button2.Hide();
            //button3.Hide();
            //button2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Nazar College of Pharmacy";
            //button1.Hide();
            //button3.Hide();
            //button3.Show();
        }

        private void issuedReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issued_and_Returned_Book_Report IRR = new Issued_and_Returned_Book_Report();
            IRR.Show();
        }

        private void allBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllBooks ab = new AllBooks();
            ab.Show();
        }

        //private void backupAndRestoreDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Backup_and_Restore br = new Backup_and_Restore();
        //    br.Show();
        //}
    }
}
