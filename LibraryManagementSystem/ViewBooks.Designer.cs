namespace LibraryManagementSystem
{
    partial class ViewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbDetails = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAZ = new System.Windows.Forms.ComboBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.dtpPublicationDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpPublicationDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.cbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.cbAuthorFilter = new System.Windows.Forms.ComboBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbAuthorName = new System.Windows.Forms.TextBox();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.txbFloorID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbShelfID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.txbDescriptions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbDatePublication = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.txbDetails);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.dgvBooks);
            this.panel1.Location = new System.Drawing.Point(12, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 367);
            this.panel1.TabIndex = 0;
            // 
            // txbDetails
            // 
            this.txbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDetails.Location = new System.Drawing.Point(896, 238);
            this.txbDetails.Multiline = true;
            this.txbDetails.Name = "txbDetails";
            this.txbDetails.ReadOnly = true;
            this.txbDetails.Size = new System.Drawing.Size(389, 126);
            this.txbDetails.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(896, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(389, 229);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // dgvBooks
            // 
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(3, 3);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(887, 361);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgBooks_CellClick);
            this.dgvBooks.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgBooks_RowEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.ckbDatePublication);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbAZ);
            this.panel2.Controls.Add(this.cbSort);
            this.panel2.Controls.Add(this.dtpPublicationDateTo);
            this.panel2.Controls.Add(this.dtpPublicationDateFrom);
            this.panel2.Controls.Add(this.btnLoadAll);
            this.panel2.Controls.Add(this.cbCategoryFilter);
            this.panel2.Controls.Add(this.cbAuthorFilter);
            this.panel2.Controls.Add(this.txbSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 147);
            this.panel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Lọc Danh Mục:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Lọc Tác Giả:";
            // 
            // cbAZ
            // 
            this.cbAZ.FormattingEnabled = true;
            this.cbAZ.Items.AddRange(new object[] {
            "A - Z",
            "Z - A"});
            this.cbAZ.Location = new System.Drawing.Point(1022, 32);
            this.cbAZ.Name = "cbAZ";
            this.cbAZ.Size = new System.Drawing.Size(79, 24);
            this.cbAZ.TabIndex = 15;
            this.cbAZ.Text = "A - Z";
            this.cbAZ.TextChanged += new System.EventHandler(this.cbAZ_TextChanged);
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Tên Sách",
            "Tác Giả",
            "Danh Mục",
            "Ngày Xuất Bản",
            "Số Lượng"});
            this.cbSort.Location = new System.Drawing.Point(896, 32);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 24);
            this.cbSort.TabIndex = 14;
            this.cbSort.Text = "Sắp Xếp Theo";
            this.cbSort.TextChanged += new System.EventHandler(this.cbSort_TextChanged);
            // 
            // dtpPublicationDateTo
            // 
            this.dtpPublicationDateTo.Location = new System.Drawing.Point(482, 84);
            this.dtpPublicationDateTo.Name = "dtpPublicationDateTo";
            this.dtpPublicationDateTo.Size = new System.Drawing.Size(247, 22);
            this.dtpPublicationDateTo.TabIndex = 11;
            this.dtpPublicationDateTo.ValueChanged += new System.EventHandler(this.dtpPublicationDateTo_ValueChanged);
            // 
            // dtpPublicationDateFrom
            // 
            this.dtpPublicationDateFrom.Location = new System.Drawing.Point(482, 44);
            this.dtpPublicationDateFrom.Name = "dtpPublicationDateFrom";
            this.dtpPublicationDateFrom.Size = new System.Drawing.Size(247, 22);
            this.dtpPublicationDateFrom.TabIndex = 9;
            this.dtpPublicationDateFrom.ValueChanged += new System.EventHandler(this.dtpPublicationDateFrom_ValueChanged);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(1185, 20);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(75, 46);
            this.btnLoadAll.TabIndex = 8;
            this.btnLoadAll.Text = "Load All";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // cbCategoryFilter
            // 
            this.cbCategoryFilter.FormattingEnabled = true;
            this.cbCategoryFilter.Location = new System.Drawing.Point(139, 98);
            this.cbCategoryFilter.Name = "cbCategoryFilter";
            this.cbCategoryFilter.Size = new System.Drawing.Size(275, 24);
            this.cbCategoryFilter.TabIndex = 6;
            this.cbCategoryFilter.TextChanged += new System.EventHandler(this.cbCategoryFilter_TextChanged);
            // 
            // cbAuthorFilter
            // 
            this.cbAuthorFilter.FormattingEnabled = true;
            this.cbAuthorFilter.IntegralHeight = false;
            this.cbAuthorFilter.Location = new System.Drawing.Point(139, 57);
            this.cbAuthorFilter.Name = "cbAuthorFilter";
            this.cbAuthorFilter.Size = new System.Drawing.Size(275, 24);
            this.cbAuthorFilter.TabIndex = 5;
            this.cbAuthorFilter.TextChanged += new System.EventHandler(this.cbAuthorFilter_TextChanged);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(139, 17);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(275, 22);
            this.txbSearch.TabIndex = 1;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Sách";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.txbAuthorName);
            this.panel3.Controls.Add(this.txbCategoryName);
            this.panel3.Controls.Add(this.txbFloorID);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txbShelfID);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.numericQuantity);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dtpPublicationDate);
            this.panel3.Controls.Add(this.txbDescriptions);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txbBookName);
            this.panel3.Controls.Add(this.txbBookID);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 538);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1288, 192);
            this.panel3.TabIndex = 2;
            // 
            // txbAuthorName
            // 
            this.txbAuthorName.Location = new System.Drawing.Point(139, 109);
            this.txbAuthorName.Name = "txbAuthorName";
            this.txbAuthorName.ReadOnly = true;
            this.txbAuthorName.Size = new System.Drawing.Size(227, 22);
            this.txbAuthorName.TabIndex = 32;
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Location = new System.Drawing.Point(139, 147);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.ReadOnly = true;
            this.txbCategoryName.Size = new System.Drawing.Size(225, 22);
            this.txbCategoryName.TabIndex = 31;
            // 
            // txbFloorID
            // 
            this.txbFloorID.Location = new System.Drawing.Point(534, 148);
            this.txbFloorID.Name = "txbFloorID";
            this.txbFloorID.ReadOnly = true;
            this.txbFloorID.Size = new System.Drawing.Size(255, 22);
            this.txbFloorID.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(429, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tầng:";
            // 
            // txbShelfID
            // 
            this.txbShelfID.Location = new System.Drawing.Point(534, 109);
            this.txbShelfID.Name = "txbShelfID";
            this.txbShelfID.ReadOnly = true;
            this.txbShelfID.Size = new System.Drawing.Size(255, 22);
            this.txbShelfID.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(429, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Kệ Số:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1157, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 38);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1009, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 38);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(873, 129);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 38);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(1009, 29);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(92, 22);
            this.numericQuantity.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(936, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số Lượng:";
            // 
            // dtpPublicationDate
            // 
            this.dtpPublicationDate.Location = new System.Drawing.Point(534, 31);
            this.dtpPublicationDate.Name = "dtpPublicationDate";
            this.dtpPublicationDate.Size = new System.Drawing.Size(255, 22);
            this.dtpPublicationDate.TabIndex = 21;
            // 
            // txbDescriptions
            // 
            this.txbDescriptions.Location = new System.Drawing.Point(534, 69);
            this.txbDescriptions.Name = "txbDescriptions";
            this.txbDescriptions.ReadOnly = true;
            this.txbDescriptions.Size = new System.Drawing.Size(255, 22);
            this.txbDescriptions.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mô Tả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ngày Xuất Bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Danh Mục:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên Tác Giả:";
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(139, 69);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.ReadOnly = true;
            this.txbBookName.Size = new System.Drawing.Size(225, 22);
            this.txbBookName.TabIndex = 13;
            // 
            // txbBookID
            // 
            this.txbBookID.Location = new System.Drawing.Point(139, 28);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.ReadOnly = true;
            this.txbBookID.Size = new System.Drawing.Size(225, 22);
            this.txbBookID.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Sách:";
            // 
            // ckbDatePublication
            // 
            this.ckbDatePublication.AutoSize = true;
            this.ckbDatePublication.Location = new System.Drawing.Point(482, 19);
            this.ckbDatePublication.Name = "ckbDatePublication";
            this.ckbDatePublication.Size = new System.Drawing.Size(118, 20);
            this.ckbDatePublication.TabIndex = 20;
            this.ckbDatePublication.Text = "Ngày Xuất Bản";
            this.ckbDatePublication.UseVisualStyleBackColor = true;
            this.ckbDatePublication.CheckedChanged += new System.EventHandler(this.ckbDatePublication_CheckedChanged);
            // 
            // ViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 742);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewBooks";
            this.Text = "ViewBooks";
            this.Load += new System.EventHandler(this.ViewBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPublicationDate;
        private System.Windows.Forms.TextBox txbDescriptions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbCategoryFilter;
        private System.Windows.Forms.ComboBox cbAuthorFilter;
        private System.Windows.Forms.TextBox txbDetails;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txbFloorID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbShelfID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.DateTimePicker dtpPublicationDateTo;
        private System.Windows.Forms.DateTimePicker dtpPublicationDateFrom;
        private System.Windows.Forms.ComboBox cbAZ;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.TextBox txbAuthorName;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckbDatePublication;
    }
}