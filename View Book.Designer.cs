namespace Library_Management_System
{
    partial class View_Book
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Book));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBookName_RefreshButton = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_ViewBook = new System.Windows.Forms.DataGridView();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_ViewBook = new System.Windows.Forms.Panel();
            this.buttonCancel_ViewBook = new System.Windows.Forms.Button();
            this.buttonDelete_ViewBook = new System.Windows.Forms.Button();
            this.buttonUpdate_ViewBook = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBookQuantity_ViewBook = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBookPurchaseDate = new System.Windows.Forms.TextBox();
            this.textBoxBookPrice_ViewBook = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBookPublication_ViewBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBookAuthor_ViewBook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBookName_ViewBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
      //      this.library_Management_SystemDataSet = new Library_Management_System.Library_Management_SystemDataSet();
            this.libraryManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBookAccessionNo_ViewBook = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBookCallNo_ViewBook = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxBookDepartment_ViewBook = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBookSubtitle_ViewBook = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxBookEdition_ViewBook = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxBookVolume_ViewBook = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewBook)).BeginInit();
            this.panel_ViewBook.SuspendLayout();
     //       ((System.ComponentModel.ISupportInitialize)(this.library_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 177);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(510, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(453, 55);
            this.label8.TabIndex = 1;
            this.label8.Text = "View and Edit Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(370, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name";
            // 
            // textBoxBookName_RefreshButton
            // 
            this.textBoxBookName_RefreshButton.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookName_RefreshButton.Location = new System.Drawing.Point(485, 199);
            this.textBoxBookName_RefreshButton.Name = "textBoxBookName_RefreshButton";
            this.textBoxBookName_RefreshButton.Size = new System.Drawing.Size(194, 29);
            this.textBoxBookName_RefreshButton.TabIndex = 0;
            this.textBoxBookName_RefreshButton.TextChanged += new System.EventHandler(this.textBoxBookName_RefreshButton_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(691, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_ViewBook
            // 
            this.dataGridView_ViewBook.AllowUserToAddRows = false;
            this.dataGridView_ViewBook.AllowUserToDeleteRows = false;
            this.dataGridView_ViewBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ViewBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_ViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNo});
            this.dataGridView_ViewBook.Location = new System.Drawing.Point(12, 243);
            this.dataGridView_ViewBook.Name = "dataGridView_ViewBook";
            this.dataGridView_ViewBook.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ViewBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_ViewBook.ShowCellErrors = false;
            this.dataGridView_ViewBook.ShowRowErrors = false;
            this.dataGridView_ViewBook.Size = new System.Drawing.Size(1184, 286);
            this.dataGridView_ViewBook.TabIndex = 4;
            this.dataGridView_ViewBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ViewBook_CellClick);
            this.dataGridView_ViewBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ViewBook_CellContentClick);
            this.dataGridView_ViewBook.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_ViewBook_RowPostPaint);
            // 
            // serialNo
            // 
            this.serialNo.HeaderText = "S.No";
            this.serialNo.Name = "serialNo";
            this.serialNo.ReadOnly = true;
            // 
            // panel_ViewBook
            // 
            this.panel_ViewBook.BackColor = System.Drawing.Color.Orange;
            this.panel_ViewBook.Controls.Add(this.buttonCancel_ViewBook);
            this.panel_ViewBook.Controls.Add(this.textBoxBookVolume_ViewBook);
            this.panel_ViewBook.Controls.Add(this.textBoxBookEdition_ViewBook);
            this.panel_ViewBook.Controls.Add(this.buttonDelete_ViewBook);
            this.panel_ViewBook.Controls.Add(this.buttonUpdate_ViewBook);
            this.panel_ViewBook.Controls.Add(this.textBoxBookSubtitle_ViewBook);
            this.panel_ViewBook.Controls.Add(this.textBoxBookDepartment_ViewBook);
            this.panel_ViewBook.Controls.Add(this.textBoxBookCallNo_ViewBook);
            this.panel_ViewBook.Controls.Add(this.textBoxBookAccessionNo_ViewBook);
            this.panel_ViewBook.Controls.Add(this.label7);
            this.panel_ViewBook.Controls.Add(this.textBoxBookQuantity_ViewBook);
            this.panel_ViewBook.Controls.Add(this.label14);
            this.panel_ViewBook.Controls.Add(this.label6);
            this.panel_ViewBook.Controls.Add(this.label13);
            this.panel_ViewBook.Controls.Add(this.textBoxBookPurchaseDate);
            this.panel_ViewBook.Controls.Add(this.label12);
            this.panel_ViewBook.Controls.Add(this.textBoxBookPrice_ViewBook);
            this.panel_ViewBook.Controls.Add(this.label11);
            this.panel_ViewBook.Controls.Add(this.label5);
            this.panel_ViewBook.Controls.Add(this.label10);
            this.panel_ViewBook.Controls.Add(this.textBoxBookPublication_ViewBook);
            this.panel_ViewBook.Controls.Add(this.label9);
            this.panel_ViewBook.Controls.Add(this.label4);
            this.panel_ViewBook.Controls.Add(this.textBoxBookAuthor_ViewBook);
            this.panel_ViewBook.Controls.Add(this.label3);
            this.panel_ViewBook.Controls.Add(this.textBoxBookName_ViewBook);
            this.panel_ViewBook.Controls.Add(this.label2);
            this.panel_ViewBook.Location = new System.Drawing.Point(12, 535);
            this.panel_ViewBook.Name = "panel_ViewBook";
            this.panel_ViewBook.Size = new System.Drawing.Size(1184, 208);
            this.panel_ViewBook.TabIndex = 5;
            this.panel_ViewBook.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ViewBook_Paint);
            // 
            // buttonCancel_ViewBook
            // 
            this.buttonCancel_ViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel_ViewBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel_ViewBook.Location = new System.Drawing.Point(921, 119);
            this.buttonCancel_ViewBook.Name = "buttonCancel_ViewBook";
            this.buttonCancel_ViewBook.Size = new System.Drawing.Size(99, 34);
            this.buttonCancel_ViewBook.TabIndex = 14;
            this.buttonCancel_ViewBook.Text = "Cancel";
            this.buttonCancel_ViewBook.UseVisualStyleBackColor = true;
            this.buttonCancel_ViewBook.Click += new System.EventHandler(this.buttonCancel_ViewBook_Click);
            // 
            // buttonDelete_ViewBook
            // 
            this.buttonDelete_ViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete_ViewBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete_ViewBook.Location = new System.Drawing.Point(831, 119);
            this.buttonDelete_ViewBook.Name = "buttonDelete_ViewBook";
            this.buttonDelete_ViewBook.Size = new System.Drawing.Size(84, 34);
            this.buttonDelete_ViewBook.TabIndex = 13;
            this.buttonDelete_ViewBook.Text = "Delete";
            this.buttonDelete_ViewBook.UseVisualStyleBackColor = true;
            this.buttonDelete_ViewBook.Click += new System.EventHandler(this.buttonDelete_ViewBook_Click);
            // 
            // buttonUpdate_ViewBook
            // 
            this.buttonUpdate_ViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate_ViewBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate_ViewBook.Location = new System.Drawing.Point(732, 119);
            this.buttonUpdate_ViewBook.Name = "buttonUpdate_ViewBook";
            this.buttonUpdate_ViewBook.Size = new System.Drawing.Size(93, 34);
            this.buttonUpdate_ViewBook.TabIndex = 12;
            this.buttonUpdate_ViewBook.Text = "Update";
            this.buttonUpdate_ViewBook.UseVisualStyleBackColor = true;
            this.buttonUpdate_ViewBook.Click += new System.EventHandler(this.buttonUpdate_ViewBook_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(406, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Purchase Date";
            // 
            // textBoxBookQuantity_ViewBook
            // 
            this.textBoxBookQuantity_ViewBook.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookQuantity_ViewBook.Location = new System.Drawing.Point(831, 49);
            this.textBoxBookQuantity_ViewBook.Name = "textBoxBookQuantity_ViewBook";
            this.textBoxBookQuantity_ViewBook.Size = new System.Drawing.Size(138, 29);
            this.textBoxBookQuantity_ViewBook.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(746, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantity";
            // 
            // textBoxBookPurchaseDate
            // 
            this.textBoxBookPurchaseDate.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookPurchaseDate.Location = new System.Drawing.Point(537, 80);
            this.textBoxBookPurchaseDate.Name = "textBoxBookPurchaseDate";
            this.textBoxBookPurchaseDate.Size = new System.Drawing.Size(138, 29);
            this.textBoxBookPurchaseDate.TabIndex = 7;
            this.textBoxBookPurchaseDate.TextChanged += new System.EventHandler(this.textBoxBookPurchaseDate_TextChanged);
            // 
            // textBoxBookPrice_ViewBook
            // 
            this.textBoxBookPrice_ViewBook.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookPrice_ViewBook.Location = new System.Drawing.Point(831, 16);
            this.textBoxBookPrice_ViewBook.Name = "textBoxBookPrice_ViewBook";
            this.textBoxBookPrice_ViewBook.Size = new System.Drawing.Size(138, 29);
            this.textBoxBookPrice_ViewBook.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(746, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price";
            // 
            // textBoxBookPublication_ViewBook
            // 
            this.textBoxBookPublication_ViewBook.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookPublication_ViewBook.Location = new System.Drawing.Point(537, 49);
            this.textBoxBookPublication_ViewBook.Name = "textBoxBookPublication_ViewBook";
            this.textBoxBookPublication_ViewBook.Size = new System.Drawing.Size(203, 29);
            this.textBoxBookPublication_ViewBook.TabIndex = 6;
            this.textBoxBookPublication_ViewBook.TextChanged += new System.EventHandler(this.textBoxBookPublication_ViewBook_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(67, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subtitle";
            // 
            // textBoxBookAuthor_ViewBook
            // 
            this.textBoxBookAuthor_ViewBook.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookAuthor_ViewBook.Location = new System.Drawing.Point(193, 52);
            this.textBoxBookAuthor_ViewBook.Name = "textBoxBookAuthor_ViewBook";
            this.textBoxBookAuthor_ViewBook.Size = new System.Drawing.Size(208, 29);
            this.textBoxBookAuthor_ViewBook.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(67, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Author Name";
            // 
            // textBoxBookName_ViewBook
            // 
            this.textBoxBookName_ViewBook.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookName_ViewBook.Location = new System.Drawing.Point(193, 18);
            this.textBoxBookName_ViewBook.Name = "textBoxBookName_ViewBook";
            this.textBoxBookName_ViewBook.Size = new System.Drawing.Size(208, 29);
            this.textBoxBookName_ViewBook.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(70, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name";
            // 
            // library_Management_SystemDataSet
            // 
      //      this.library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet";
       //     this.library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryManagementSystemDataSetBindingSource
            // 
      //      this.libraryManagementSystemDataSetBindingSource.DataSource = this.library_Management_SystemDataSet;
            this.libraryManagementSystemDataSetBindingSource.Position = 0;
            // 
            // textBoxBookAccessionNo_ViewBook
            // 
            this.textBoxBookAccessionNo_ViewBook.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookAccessionNo_ViewBook.Location = new System.Drawing.Point(193, 117);
            this.textBoxBookAccessionNo_ViewBook.Name = "textBoxBookAccessionNo_ViewBook";
            this.textBoxBookAccessionNo_ViewBook.Size = new System.Drawing.Size(138, 29);
            this.textBoxBookAccessionNo_ViewBook.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(67, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Accession No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(67, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Call No";
            // 
            // textBoxBookCallNo_ViewBook
            // 
            this.textBoxBookCallNo_ViewBook.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookCallNo_ViewBook.Location = new System.Drawing.Point(193, 149);
            this.textBoxBookCallNo_ViewBook.Name = "textBoxBookCallNo_ViewBook";
            this.textBoxBookCallNo_ViewBook.Size = new System.Drawing.Size(138, 29);
            this.textBoxBookCallNo_ViewBook.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(407, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Department";
            // 
            // textBoxBookDepartment_ViewBook
            // 
            this.textBoxBookDepartment_ViewBook.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookDepartment_ViewBook.Location = new System.Drawing.Point(537, 17);
            this.textBoxBookDepartment_ViewBook.Name = "textBoxBookDepartment_ViewBook";
            this.textBoxBookDepartment_ViewBook.Size = new System.Drawing.Size(203, 29);
            this.textBoxBookDepartment_ViewBook.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(407, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Publisher";
            // 
            // textBoxBookSubtitle_ViewBook
            // 
            this.textBoxBookSubtitle_ViewBook.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookSubtitle_ViewBook.Location = new System.Drawing.Point(193, 85);
            this.textBoxBookSubtitle_ViewBook.Name = "textBoxBookSubtitle_ViewBook";
            this.textBoxBookSubtitle_ViewBook.Size = new System.Drawing.Size(207, 29);
            this.textBoxBookSubtitle_ViewBook.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(409, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Edition";
            // 
            // textBoxBookEdition_ViewBook
            // 
            this.textBoxBookEdition_ViewBook.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookEdition_ViewBook.Location = new System.Drawing.Point(537, 146);
            this.textBoxBookEdition_ViewBook.Name = "textBoxBookEdition_ViewBook";
            this.textBoxBookEdition_ViewBook.Size = new System.Drawing.Size(138, 29);
            this.textBoxBookEdition_ViewBook.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(407, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Volume";
            // 
            // textBoxBookVolume_ViewBook
            // 
            this.textBoxBookVolume_ViewBook.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxBookVolume_ViewBook.Location = new System.Drawing.Point(537, 113);
            this.textBoxBookVolume_ViewBook.Name = "textBoxBookVolume_ViewBook";
            this.textBoxBookVolume_ViewBook.Size = new System.Drawing.Size(138, 29);
            this.textBoxBookVolume_ViewBook.TabIndex = 8;
            // 
            // View_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1197, 719);
            this.Controls.Add(this.panel_ViewBook);
            this.Controls.Add(this.dataGridView_ViewBook);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBookName_RefreshButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_Book";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.View_Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewBook)).EndInit();
            this.panel_ViewBook.ResumeLayout(false);
            this.panel_ViewBook.PerformLayout();
    //        ((System.ComponentModel.ISupportInitialize)(this.library_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBookName_RefreshButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_ViewBook;
        private System.Windows.Forms.Panel panel_ViewBook;
        private System.Windows.Forms.Button buttonCancel_ViewBook;
        private System.Windows.Forms.Button buttonDelete_ViewBook;
        private System.Windows.Forms.Button buttonUpdate_ViewBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBookQuantity_ViewBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBookPrice_ViewBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBookPublication_ViewBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBookAuthor_ViewBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBookName_ViewBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBookPurchaseDate;
        private System.Windows.Forms.Label label8;
        
        private System.Windows.Forms.BindingSource libraryManagementSystemDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
        private System.Windows.Forms.TextBox textBoxBookVolume_ViewBook;
        private System.Windows.Forms.TextBox textBoxBookEdition_ViewBook;
        private System.Windows.Forms.TextBox textBoxBookSubtitle_ViewBook;
        private System.Windows.Forms.TextBox textBoxBookDepartment_ViewBook;
        private System.Windows.Forms.TextBox textBoxBookCallNo_ViewBook;
        private System.Windows.Forms.TextBox textBoxBookAccessionNo_ViewBook;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}