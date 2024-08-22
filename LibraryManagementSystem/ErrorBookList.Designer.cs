namespace LibraryManagementSystem
{
    partial class ErrorBookList
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
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBookError = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbError = new System.Windows.Forms.TextBox();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.cbAZ = new System.Windows.Forms.ComboBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookError)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbAZ);
            this.panel1.Controls.Add(this.cbSort);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLoadAll);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 100);
            this.panel1.TabIndex = 2;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(104, 35);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(399, 22);
            this.txbSearch.TabIndex = 2;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Lỗi:";
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(509, 30);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(132, 32);
            this.btnLoadAll.TabIndex = 0;
            this.btnLoadAll.Text = "Xem Tất Cả";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvBookError);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 311);
            this.panel2.TabIndex = 3;
            // 
            // dgvBookError
            // 
            this.dgvBookError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookError.Location = new System.Drawing.Point(3, 3);
            this.dgvBookError.Name = "dgvBookError";
            this.dgvBookError.RowHeadersWidth = 51;
            this.dgvBookError.RowTemplate.Height = 24;
            this.dgvBookError.Size = new System.Drawing.Size(1136, 305);
            this.dgvBookError.TabIndex = 0;
            this.dgvBookError.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookError_CellClick);
            this.dgvBookError.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookError_RowEnter);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txbStatus);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txbError);
            this.panel3.Controls.Add(this.txbBookID);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnFix);
            this.panel3.Location = new System.Drawing.Point(12, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1142, 175);
            this.panel3.TabIndex = 3;
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(646, 24);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(161, 22);
            this.txbStatus.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Trạng Thái:";
            // 
            // txbError
            // 
            this.txbError.Location = new System.Drawing.Point(150, 68);
            this.txbError.Multiline = true;
            this.txbError.Name = "txbError";
            this.txbError.Size = new System.Drawing.Size(657, 104);
            this.txbError.TabIndex = 8;
            // 
            // txbBookID
            // 
            this.txbBookID.Location = new System.Drawing.Point(150, 24);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.Size = new System.Drawing.Size(161, 22);
            this.txbBookID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lỗi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Sách:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1025, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 41);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(884, 100);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 41);
            this.btnFix.TabIndex = 1;
            this.btnFix.Text = "Sửa Lỗi";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // cbAZ
            // 
            this.cbAZ.FormattingEnabled = true;
            this.cbAZ.Items.AddRange(new object[] {
            "A - Z",
            "Z - A"});
            this.cbAZ.Location = new System.Drawing.Point(1037, 35);
            this.cbAZ.Name = "cbAZ";
            this.cbAZ.Size = new System.Drawing.Size(79, 24);
            this.cbAZ.TabIndex = 17;
            this.cbAZ.Text = "A - Z";
            this.cbAZ.TextChanged += new System.EventHandler(this.cbAZ_TextChanged);
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Tên Sách",
            "Trạng Thái"});
            this.cbSort.Location = new System.Drawing.Point(911, 35);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 24);
            this.cbSort.TabIndex = 16;
            this.cbSort.Text = "Sắp Xếp Theo";
            this.cbSort.TextChanged += new System.EventHandler(this.cbSort_TextChanged);
            // 
            // ErrorBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 622);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ErrorBookList";
            this.Text = "ErrorBookList";
            this.Load += new System.EventHandler(this.ErrorBookList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookError)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBookError;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.TextBox txbError;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAZ;
        private System.Windows.Forms.ComboBox cbSort;
    }
}