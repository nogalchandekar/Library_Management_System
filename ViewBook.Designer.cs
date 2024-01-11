namespace Library_Management_System
{
    partial class ViewBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bookname = new System.Windows.Forms.Label();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbook_id = new System.Windows.Forms.NumericUpDown();
            this.bookid = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.subjectname = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSemester = new System.Windows.Forms.NumericUpDown();
            this.txtYears = new System.Windows.Forms.NumericUpDown();
            this.txtNo_ofBooks = new System.Windows.Forms.NumericUpDown();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.NumericUpDown();
            this.semester = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.Label();
            this.noofbooks = new System.Windows.Forms.Label();
            this.authornamae = new System.Windows.Forms.Label();
            this.bname = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbook_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo_ofBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookId)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 166);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(424, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ViewBooks";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bookname
            // 
            this.bookname.AutoSize = true;
            this.bookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookname.Location = new System.Drawing.Point(159, 196);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(170, 32);
            this.bookname.TabIndex = 1;
            this.bookname.Text = "Book Name";
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(356, 200);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(292, 22);
            this.txtBName.TabIndex = 2;
            this.txtBName.TextChanged += new System.EventHandler(this.txtBName_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(669, 196);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 31);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1162, 422);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.txtbook_id);
            this.panel2.Controls.Add(this.bookid);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtSubName);
            this.panel2.Controls.Add(this.subjectname);
            this.panel2.Controls.Add(this.txtSubjectName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtSemester);
            this.panel2.Controls.Add(this.txtYears);
            this.panel2.Controls.Add(this.txtNo_ofBooks);
            this.panel2.Controls.Add(this.txtAuthorName);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.txtBookId);
            this.panel2.Controls.Add(this.semester);
            this.panel2.Controls.Add(this.years);
            this.panel2.Controls.Add(this.noofbooks);
            this.panel2.Controls.Add(this.authornamae);
            this.panel2.Controls.Add(this.bname);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1, 671);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1162, 254);
            this.panel2.TabIndex = 5;
           // this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtbook_id
            // 
            this.txtbook_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbook_id.Location = new System.Drawing.Point(198, 13);
            this.txtbook_id.Name = "txtbook_id";
            this.txtbook_id.Size = new System.Drawing.Size(296, 27);
            this.txtbook_id.TabIndex = 40;
            // 
            // bookid
            // 
            this.bookid.AutoSize = true;
            this.bookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookid.Location = new System.Drawing.Point(44, 15);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(76, 20);
            this.bookid.TabIndex = 39;
            this.bookid.Text = "Book ID";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(961, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 37);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(791, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 37);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(632, 149);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 37);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSubName
            // 
            this.txtSubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubName.Location = new System.Drawing.Point(791, 77);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(296, 22);
            this.txtSubName.TabIndex = 35;
            // 
            // subjectname
            // 
            this.subjectname.AutoSize = true;
            this.subjectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectname.Location = new System.Drawing.Point(612, 79);
            this.subjectname.Name = "subjectname";
            this.subjectname.Size = new System.Drawing.Size(126, 20);
            this.subjectname.TabIndex = 34;
            this.subjectname.Text = "Subject Name";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.Location = new System.Drawing.Point(540, 275);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(296, 27);
            this.txtSubjectName.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "Subject Name";
            // 
            // txtSemester
            // 
            this.txtSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemester.Location = new System.Drawing.Point(791, 20);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(296, 22);
            this.txtSemester.TabIndex = 25;
            // 
            // txtYears
            // 
            this.txtYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYears.Location = new System.Drawing.Point(198, 209);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(296, 22);
            this.txtYears.TabIndex = 24;
            // 
            // txtNo_ofBooks
            // 
            this.txtNo_ofBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo_ofBooks.Location = new System.Drawing.Point(198, 160);
            this.txtNo_ofBooks.Name = "txtNo_ofBooks";
            this.txtNo_ofBooks.Size = new System.Drawing.Size(296, 22);
            this.txtNo_ofBooks.TabIndex = 23;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(198, 107);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(296, 22);
            this.txtAuthorName.TabIndex = 22;
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(198, 65);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(296, 22);
            this.txtBookName.TabIndex = 21;
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookId.Location = new System.Drawing.Point(540, -48);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(296, 27);
            this.txtBookId.TabIndex = 20;
            // 
            // semester
            // 
            this.semester.AutoSize = true;
            this.semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.Location = new System.Drawing.Point(628, 20);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(104, 25);
            this.semester.TabIndex = 19;
            this.semester.Text = "Semester";
            // 
            // years
            // 
            this.years.AutoSize = true;
            this.years.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.years.Location = new System.Drawing.Point(44, 208);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(57, 20);
            this.years.TabIndex = 18;
            this.years.Text = "Years";
            // 
            // noofbooks
            // 
            this.noofbooks.AutoSize = true;
            this.noofbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofbooks.Location = new System.Drawing.Point(44, 159);
            this.noofbooks.Name = "noofbooks";
            this.noofbooks.Size = new System.Drawing.Size(112, 20);
            this.noofbooks.TabIndex = 17;
            this.noofbooks.Text = "No of Books";
            // 
            // authornamae
            // 
            this.authornamae.AutoSize = true;
            this.authornamae.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authornamae.Location = new System.Drawing.Point(44, 107);
            this.authornamae.Name = "authornamae";
            this.authornamae.Size = new System.Drawing.Size(118, 20);
            this.authornamae.TabIndex = 16;
            this.authornamae.Text = "Author Name";
            // 
            // bname
            // 
            this.bname.AutoSize = true;
            this.bname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bname.Location = new System.Drawing.Point(44, 65);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(105, 20);
            this.bname.TabIndex = 15;
            this.bname.Text = "Book Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(327, -48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Book ID";
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1166, 937);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtBName);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.panel1);
            this.Name = "ViewBook";
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbook_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo_ofBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bookname;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtSemester;
        private System.Windows.Forms.NumericUpDown txtYears;
        private System.Windows.Forms.NumericUpDown txtNo_ofBooks;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.NumericUpDown txtBookId;
        private System.Windows.Forms.Label semester;
        private System.Windows.Forms.Label years;
        private System.Windows.Forms.Label noofbooks;
        private System.Windows.Forms.Label authornamae;
        private System.Windows.Forms.Label bname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.Label subjectname;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown txtbook_id;
        private System.Windows.Forms.Label bookid;
    }
}