namespace LibraryManagementSystem
{
    partial class UserProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbOrderDetails = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbUserID = new System.Windows.Forms.TextBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đầy Đủ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật Khẩu:";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(178, 199);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(333, 22);
            this.txbPhone.TabIndex = 4;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(178, 248);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(333, 22);
            this.txbPassword.TabIndex = 5;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(178, 153);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(333, 22);
            this.txbAddress.TabIndex = 6;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(178, 101);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(333, 22);
            this.txbUsername.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbOrderDetails
            // 
            this.txbOrderDetails.Location = new System.Drawing.Point(178, 301);
            this.txbOrderDetails.Name = "txbOrderDetails";
            this.txbOrderDetails.Size = new System.Drawing.Size(333, 22);
            this.txbOrderDetails.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Order Details:";
            // 
            // txbUserID
            // 
            this.txbUserID.Location = new System.Drawing.Point(178, 45);
            this.txbUserID.Name = "txbUserID";
            this.txbUserID.Size = new System.Drawing.Size(333, 22);
            this.txbUserID.TabIndex = 13;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(77, 48);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(49, 16);
            this.lbUserID.TabIndex = 12;
            this.lbUserID.Text = "Mã Số:";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 454);
            this.Controls.Add(this.txbUserID);
            this.Controls.Add(this.lbUserID);
            this.Controls.Add(this.txbOrderDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbOrderDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbUserID;
        private System.Windows.Forms.Label lbUserID;
    }
}