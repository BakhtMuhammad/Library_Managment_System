namespace Library_Management_System
{
    partial class a
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(a));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRefresh_ViewStuInfo = new System.Windows.Forms.Button();
            this.textBoxSearch_ViewStuInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxStuEmail_ViewStuInfo = new System.Windows.Forms.TextBox();
            this.textBoxStuCont_ViewStuInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStuSem_ViewStuInfo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDept_ViewStuInfo = new System.Windows.Forms.TextBox();
            this.textBoxStuName_ViewStuInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEnrollPanel_ViewStuInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancel_ViewStuInfo = new System.Windows.Forms.Button();
            this.buttonDelete_ViewStuInfo = new System.Windows.Forms.Button();
            this.buttonUpdate_ViewStuInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 145);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(356, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRefresh_ViewStuInfo
            // 
            this.buttonRefresh_ViewStuInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh_ViewStuInfo.Location = new System.Drawing.Point(450, 154);
            this.buttonRefresh_ViewStuInfo.Name = "buttonRefresh_ViewStuInfo";
            this.buttonRefresh_ViewStuInfo.Size = new System.Drawing.Size(92, 34);
            this.buttonRefresh_ViewStuInfo.TabIndex = 2;
            this.buttonRefresh_ViewStuInfo.Text = "Refresh";
            this.buttonRefresh_ViewStuInfo.UseVisualStyleBackColor = true;
            this.buttonRefresh_ViewStuInfo.Click += new System.EventHandler(this.buttonRefresh_ViewStuInfo_Click);
            // 
            // textBoxSearch_ViewStuInfo
            // 
            this.textBoxSearch_ViewStuInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxSearch_ViewStuInfo.Location = new System.Drawing.Point(302, 156);
            this.textBoxSearch_ViewStuInfo.Name = "textBoxSearch_ViewStuInfo";
            this.textBoxSearch_ViewStuInfo.Size = new System.Drawing.Size(135, 29);
            this.textBoxSearch_ViewStuInfo.TabIndex = 3;
            this.textBoxSearch_ViewStuInfo.TextChanged += new System.EventHandler(this.textBoxSearch_ViewStuInfo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enrollment No.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNo});
            this.dataGridView1.Location = new System.Drawing.Point(3, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(736, 306);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // serialNo
            // 
            this.serialNo.HeaderText = "S.No";
            this.serialNo.Name = "serialNo";
            this.serialNo.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Controls.Add(this.textBoxStuEmail_ViewStuInfo);
            this.panel2.Controls.Add(this.textBoxStuCont_ViewStuInfo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxStuSem_ViewStuInfo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxDept_ViewStuInfo);
            this.panel2.Controls.Add(this.textBoxStuName_ViewStuInfo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxEnrollPanel_ViewStuInfo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonCancel_ViewStuInfo);
            this.panel2.Controls.Add(this.buttonDelete_ViewStuInfo);
            this.panel2.Controls.Add(this.buttonUpdate_ViewStuInfo);
            this.panel2.Location = new System.Drawing.Point(3, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 184);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBoxStuEmail_ViewStuInfo
            // 
            this.textBoxStuEmail_ViewStuInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxStuEmail_ViewStuInfo.Location = new System.Drawing.Point(548, 93);
            this.textBoxStuEmail_ViewStuInfo.Name = "textBoxStuEmail_ViewStuInfo";
            this.textBoxStuEmail_ViewStuInfo.Size = new System.Drawing.Size(135, 29);
            this.textBoxStuEmail_ViewStuInfo.TabIndex = 3;
            // 
            // textBoxStuCont_ViewStuInfo
            // 
            this.textBoxStuCont_ViewStuInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxStuCont_ViewStuInfo.Location = new System.Drawing.Point(548, 59);
            this.textBoxStuCont_ViewStuInfo.Name = "textBoxStuCont_ViewStuInfo";
            this.textBoxStuCont_ViewStuInfo.Size = new System.Drawing.Size(135, 29);
            this.textBoxStuCont_ViewStuInfo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Student Email";
            // 
            // textBoxStuSem_ViewStuInfo
            // 
            this.textBoxStuSem_ViewStuInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxStuSem_ViewStuInfo.Location = new System.Drawing.Point(548, 26);
            this.textBoxStuSem_ViewStuInfo.Name = "textBoxStuSem_ViewStuInfo";
            this.textBoxStuSem_ViewStuInfo.Size = new System.Drawing.Size(135, 29);
            this.textBoxStuSem_ViewStuInfo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Student Contact";
            // 
            // textBoxDept_ViewStuInfo
            // 
            this.textBoxDept_ViewStuInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxDept_ViewStuInfo.Location = new System.Drawing.Point(208, 95);
            this.textBoxDept_ViewStuInfo.Name = "textBoxDept_ViewStuInfo";
            this.textBoxDept_ViewStuInfo.Size = new System.Drawing.Size(135, 29);
            this.textBoxDept_ViewStuInfo.TabIndex = 3;
            // 
            // textBoxStuName_ViewStuInfo
            // 
            this.textBoxStuName_ViewStuInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxStuName_ViewStuInfo.Location = new System.Drawing.Point(208, 60);
            this.textBoxStuName_ViewStuInfo.Name = "textBoxStuName_ViewStuInfo";
            this.textBoxStuName_ViewStuInfo.Size = new System.Drawing.Size(135, 29);
            this.textBoxStuName_ViewStuInfo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Student Semester";
            // 
            // textBoxEnrollPanel_ViewStuInfo
            // 
            this.textBoxEnrollPanel_ViewStuInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxEnrollPanel_ViewStuInfo.Location = new System.Drawing.Point(208, 24);
            this.textBoxEnrollPanel_ViewStuInfo.Name = "textBoxEnrollPanel_ViewStuInfo";
            this.textBoxEnrollPanel_ViewStuInfo.Size = new System.Drawing.Size(135, 29);
            this.textBoxEnrollPanel_ViewStuInfo.TabIndex = 3;
            this.textBoxEnrollPanel_ViewStuInfo.TextChanged += new System.EventHandler(this.textBoxEnrollPanel_ViewStuInfo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enrollment No.";
            // 
            // buttonCancel_ViewStuInfo
            // 
            this.buttonCancel_ViewStuInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel_ViewStuInfo.Location = new System.Drawing.Point(589, 141);
            this.buttonCancel_ViewStuInfo.Name = "buttonCancel_ViewStuInfo";
            this.buttonCancel_ViewStuInfo.Size = new System.Drawing.Size(92, 34);
            this.buttonCancel_ViewStuInfo.TabIndex = 2;
            this.buttonCancel_ViewStuInfo.Text = "Cancel";
            this.buttonCancel_ViewStuInfo.UseVisualStyleBackColor = true;
            this.buttonCancel_ViewStuInfo.Click += new System.EventHandler(this.buttonCancel_ViewStuInfo_Click);
            // 
            // buttonDelete_ViewStuInfo
            // 
            this.buttonDelete_ViewStuInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete_ViewStuInfo.Location = new System.Drawing.Point(477, 141);
            this.buttonDelete_ViewStuInfo.Name = "buttonDelete_ViewStuInfo";
            this.buttonDelete_ViewStuInfo.Size = new System.Drawing.Size(92, 34);
            this.buttonDelete_ViewStuInfo.TabIndex = 2;
            this.buttonDelete_ViewStuInfo.Text = "Delete";
            this.buttonDelete_ViewStuInfo.UseVisualStyleBackColor = true;
            this.buttonDelete_ViewStuInfo.Click += new System.EventHandler(this.buttonDelete_ViewStuInfo_Click);
            // 
            // buttonUpdate_ViewStuInfo
            // 
            this.buttonUpdate_ViewStuInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate_ViewStuInfo.Location = new System.Drawing.Point(363, 141);
            this.buttonUpdate_ViewStuInfo.Name = "buttonUpdate_ViewStuInfo";
            this.buttonUpdate_ViewStuInfo.Size = new System.Drawing.Size(92, 34);
            this.buttonUpdate_ViewStuInfo.TabIndex = 2;
            this.buttonUpdate_ViewStuInfo.Text = "Update";
            this.buttonUpdate_ViewStuInfo.UseVisualStyleBackColor = true;
            this.buttonUpdate_ViewStuInfo.Click += new System.EventHandler(this.buttonUpdate_ViewStuInfo_Click);
            // 
            // a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(741, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSearch_ViewStuInfo);
            this.Controls.Add(this.buttonRefresh_ViewStuInfo);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "a";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.a_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRefresh_ViewStuInfo;
        private System.Windows.Forms.TextBox textBoxSearch_ViewStuInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxStuEmail_ViewStuInfo;
        private System.Windows.Forms.TextBox textBoxStuCont_ViewStuInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStuSem_ViewStuInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDept_ViewStuInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEnrollPanel_ViewStuInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStuName_ViewStuInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel_ViewStuInfo;
        private System.Windows.Forms.Button buttonDelete_ViewStuInfo;
        private System.Windows.Forms.Button buttonUpdate_ViewStuInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
    }
}