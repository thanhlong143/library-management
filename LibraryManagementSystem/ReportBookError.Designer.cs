namespace LibraryManagementSystem
{
    partial class ReportBookError
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbErrorDescription = new System.Windows.Forms.TextBox();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.txbUserID = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mô Tả Lỗi:";
            // 
            // txbErrorDescription
            // 
            this.txbErrorDescription.Location = new System.Drawing.Point(148, 194);
            this.txbErrorDescription.Multiline = true;
            this.txbErrorDescription.Name = "txbErrorDescription";
            this.txbErrorDescription.Size = new System.Drawing.Size(366, 178);
            this.txbErrorDescription.TabIndex = 4;
            // 
            // txbBookID
            // 
            this.txbBookID.Location = new System.Drawing.Point(148, 118);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.Size = new System.Drawing.Size(366, 22);
            this.txbBookID.TabIndex = 5;
            // 
            // txbUserID
            // 
            this.txbUserID.Location = new System.Drawing.Point(148, 54);
            this.txbUserID.Name = "txbUserID";
            this.txbUserID.Size = new System.Drawing.Size(366, 22);
            this.txbUserID.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(148, 416);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 44);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(322, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 44);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReportBookError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 482);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbUserID);
            this.Controls.Add(this.txbBookID);
            this.Controls.Add(this.txbErrorDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ReportBookError";
            this.Text = "ReportBookError";
            this.Load += new System.EventHandler(this.ReportBookError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbErrorDescription;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.TextBox txbUserID;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
    }
}