namespace LibraryManagementSystem
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentBorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAZ = new System.Windows.Forms.ComboBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.dgvLoan = new System.Windows.Forms.DataGridView();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpReturnedDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpOverdue = new System.Windows.Forms.DateTimePicker();
            this.dtpBorrowedDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnComfirmReturned = new System.Windows.Forms.Button();
            this.txbLoanID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbAmountOfFine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.issuesToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.borrowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.viewBookDetailsToolStripMenuItem});
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(104, 50);
            this.booksToolStripMenuItem.Text = "Sách";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.addBookToolStripMenuItem.Text = "Thêm Sách";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // viewBookDetailsToolStripMenuItem
            // 
            this.viewBookDetailsToolStripMenuItem.Name = "viewBookDetailsToolStripMenuItem";
            this.viewBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.viewBookDetailsToolStripMenuItem.Text = "Xem Chi Tiết";
            this.viewBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewBookDetailsToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewStudentDetailsToolStripMenuItem,
            this.viewStudentBorrowToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(84, 50);
            this.studentsToolStripMenuItem.Text = "Sinh Viên";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.addStudentToolStripMenuItem.Text = "Thêm Sinh Viên";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // viewStudentDetailsToolStripMenuItem
            // 
            this.viewStudentDetailsToolStripMenuItem.Name = "viewStudentDetailsToolStripMenuItem";
            this.viewStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.viewStudentDetailsToolStripMenuItem.Text = "Thông tin sinh viên";
            this.viewStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentDetailsToolStripMenuItem_Click);
            // 
            // viewStudentBorrowToolStripMenuItem
            // 
            this.viewStudentBorrowToolStripMenuItem.Name = "viewStudentBorrowToolStripMenuItem";
            this.viewStudentBorrowToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.viewStudentBorrowToolStripMenuItem.Text = "Tìm Sinh Viên Mượn Sách";
            this.viewStudentBorrowToolStripMenuItem.Click += new System.EventHandler(this.viewStudentBorrowToolStripMenuItem_Click);
            // 
            // issuesToolStripMenuItem
            // 
            this.issuesToolStripMenuItem.Name = "issuesToolStripMenuItem";
            this.issuesToolStripMenuItem.Size = new System.Drawing.Size(78, 50);
            this.issuesToolStripMenuItem.Text = "Sách Lỗi";
            this.issuesToolStripMenuItem.Click += new System.EventHandler(this.issuesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(61, 50);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(132, 50);
            this.borrowToolStripMenuItem.Text = "Đang Chờ Mượn";
            this.borrowToolStripMenuItem.Click += new System.EventHandler(this.borrowToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbAZ);
            this.panel1.Controls.Add(this.cbSort);
            this.panel1.Controls.Add(this.dgvLoan);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 433);
            this.panel1.TabIndex = 1;
            // 
            // cbAZ
            // 
            this.cbAZ.FormattingEnabled = true;
            this.cbAZ.Items.AddRange(new object[] {
            "A - Z",
            "Z - A"});
            this.cbAZ.Location = new System.Drawing.Point(701, 22);
            this.cbAZ.Name = "cbAZ";
            this.cbAZ.Size = new System.Drawing.Size(67, 24);
            this.cbAZ.TabIndex = 32;
            this.cbAZ.Text = "A - Z";
            this.cbAZ.TextChanged += new System.EventHandler(this.cbAZ_TextChanged);
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Tên Sách",
            "Tên Người Mượn",
            "Số Lượng Mượn",
            "Ngày Mượn",
            "Trạng Thái",
            "Phạt"});
            this.cbSort.Location = new System.Drawing.Point(574, 22);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 24);
            this.cbSort.TabIndex = 31;
            this.cbSort.Text = "Săp Xếp";
            this.cbSort.TextChanged += new System.EventHandler(this.cbSort_TextChanged);
            // 
            // dgvLoan
            // 
            this.dgvLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoan.Location = new System.Drawing.Point(19, 68);
            this.dgvLoan.Name = "dgvLoan";
            this.dgvLoan.RowHeadersWidth = 51;
            this.dgvLoan.RowTemplate.Height = 24;
            this.dgvLoan.Size = new System.Drawing.Size(850, 362);
            this.dgvLoan.TabIndex = 0;
            this.dgvLoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoan_CellClick);
            this.dgvLoan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoan_RowEnter);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(88, 22);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(258, 22);
            this.txbSearch.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tìm Kiếm:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(363, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txbStatus);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dtpReturnedDate);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dtpOverdue);
            this.panel2.Controls.Add(this.dtpBorrowedDate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.numericAmount);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txbAddress);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnComfirmReturned);
            this.panel2.Controls.Add(this.txbLoanID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txbAmountOfFine);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txbUsername);
            this.panel2.Controls.Add(this.txbPhone);
            this.panel2.Controls.Add(this.txbBookName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(890, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 558);
            this.panel2.TabIndex = 2;
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(126, 470);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(319, 22);
            this.txbStatus.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 473);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 41;
            this.label13.Text = "Trạng Thái:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(409, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "VND";
            // 
            // dtpReturnedDate
            // 
            this.dtpReturnedDate.Location = new System.Drawing.Point(126, 396);
            this.dtpReturnedDate.Name = "dtpReturnedDate";
            this.dtpReturnedDate.Size = new System.Drawing.Size(319, 22);
            this.dtpReturnedDate.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Ngày Trả:";
            // 
            // dtpOverdue
            // 
            this.dtpOverdue.Location = new System.Drawing.Point(126, 357);
            this.dtpOverdue.Name = "dtpOverdue";
            this.dtpOverdue.Size = new System.Drawing.Size(319, 22);
            this.dtpOverdue.TabIndex = 37;
            // 
            // dtpBorrowedDate
            // 
            this.dtpBorrowedDate.Location = new System.Drawing.Point(126, 316);
            this.dtpBorrowedDate.Name = "dtpBorrowedDate";
            this.dtpBorrowedDate.Size = new System.Drawing.Size(319, 22);
            this.dtpBorrowedDate.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Ngày Mượn:";
            // 
            // numericAmount
            // 
            this.numericAmount.Location = new System.Drawing.Point(126, 275);
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(319, 22);
            this.numericAmount.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Số Lượng:";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(126, 139);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(319, 22);
            this.txbAddress.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Địa Chỉ:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(261, 513);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 38);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnComfirmReturned
            // 
            this.btnComfirmReturned.Location = new System.Drawing.Point(68, 513);
            this.btnComfirmReturned.Name = "btnComfirmReturned";
            this.btnComfirmReturned.Size = new System.Drawing.Size(151, 38);
            this.btnComfirmReturned.TabIndex = 26;
            this.btnComfirmReturned.Text = "Xác Nhận Trả Sách";
            this.btnComfirmReturned.UseVisualStyleBackColor = true;
            this.btnComfirmReturned.Click += new System.EventHandler(this.btnComfirmReturned_Click);
            // 
            // txbLoanID
            // 
            this.txbLoanID.Location = new System.Drawing.Point(126, 54);
            this.txbLoanID.Name = "txbLoanID";
            this.txbLoanID.Size = new System.Drawing.Size(319, 22);
            this.txbLoanID.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mã Mượn:";
            // 
            // txbAmountOfFine
            // 
            this.txbAmountOfFine.Location = new System.Drawing.Point(126, 434);
            this.txbAmountOfFine.Name = "txbAmountOfFine";
            this.txbAmountOfFine.Size = new System.Drawing.Size(277, 22);
            this.txbAmountOfFine.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phạt:";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(126, 93);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(319, 22);
            this.txbUsername.TabIndex = 21;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(126, 183);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(319, 22);
            this.txbPhone.TabIndex = 20;
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(126, 229);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(319, 22);
            this.txbBookName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hạn Trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Số Điện Thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Người Mượn:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(12, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1341, 71);
            this.panel3.TabIndex = 3;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1365, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoard";
            this.Text = "Quản Lý Thư Viện";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentBorrowToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnComfirmReturned;
        private System.Windows.Forms.TextBox txbLoanID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbAmountOfFine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpBorrowedDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpOverdue;
        private System.Windows.Forms.DateTimePicker dtpReturnedDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.ComboBox cbAZ;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
    }
}

