namespace LibraryManagementSystem
{
    partial class ViewStudentInfo
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
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbOrderDetails = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbUserID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbSearchID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbSearchID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnLoadAll);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(974, 35);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(134, 31);
            this.btnLoadAll.TabIndex = 5;
            this.btnLoadAll.Text = "Xem Tất Cả";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(432, 39);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(497, 22);
            this.txbSearch.TabIndex = 4;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvUsers);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1355, 357);
            this.panel2.TabIndex = 1;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(3, 3);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1349, 351);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            this.dgvUsers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUsers_CellFormatting);
            this.dgvUsers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_RowEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbPassword);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txbOrderDetails);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txbUserID);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txbUsername);
            this.panel3.Controls.Add(this.txbAddress);
            this.panel3.Controls.Add(this.txbPhone);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Location = new System.Drawing.Point(12, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1355, 178);
            this.panel3.TabIndex = 1;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(568, 141);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(296, 22);
            this.txbPassword.TabIndex = 41;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Mật Khẩu:";
            // 
            // txbOrderDetails
            // 
            this.txbOrderDetails.Location = new System.Drawing.Point(568, 89);
            this.txbOrderDetails.Name = "txbOrderDetails";
            this.txbOrderDetails.Size = new System.Drawing.Size(296, 22);
            this.txbOrderDetails.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Thông tin Mượn:";
            // 
            // txbUserID
            // 
            this.txbUserID.Location = new System.Drawing.Point(126, 24);
            this.txbUserID.Name = "txbUserID";
            this.txbUserID.Size = new System.Drawing.Size(292, 22);
            this.txbUserID.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mã Số:";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(126, 86);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(292, 22);
            this.txbUsername.TabIndex = 35;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(126, 138);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(292, 22);
            this.txbAddress.TabIndex = 34;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(568, 24);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(296, 22);
            this.txbPhone.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tên Đầy Đủ:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(916, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 38);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1213, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 38);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1065, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 38);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbSearchID
            // 
            this.txbSearchID.Location = new System.Drawing.Point(108, 39);
            this.txbSearchID.Name = "txbSearchID";
            this.txbSearchID.Size = new System.Drawing.Size(127, 22);
            this.txbSearchID.TabIndex = 7;
            this.txbSearchID.TextChanged += new System.EventHandler(this.txbSearchID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tìm Mã Số:";
            // 
            // ViewStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 671);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewStudentInfo";
            this.Text = "ViewStudentInfo";
            this.Load += new System.EventHandler(this.ViewStudentInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbOrderDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSearchID;
        private System.Windows.Forms.Label label8;
    }
}