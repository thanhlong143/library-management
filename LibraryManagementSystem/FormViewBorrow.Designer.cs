namespace LibraryManagementSystem
{
    partial class FormViewBorrow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.txbShelfID = new System.Windows.Forms.TextBox();
            this.txbFloorID = new System.Windows.Forms.TextBox();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.txbBorrowID = new System.Windows.Forms.TextBox();
            this.txbUserID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBorrow);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1279, 352);
            this.panel2.TabIndex = 1;
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(3, 3);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowHeadersWidth = 51;
            this.dgvBorrow.RowTemplate.Height = 24;
            this.dgvBorrow.Size = new System.Drawing.Size(1273, 346);
            this.dgvBorrow.TabIndex = 0;
            this.dgvBorrow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellClick);
            this.dgvBorrow.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_RowEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbQuantity);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Controls.Add(this.dtpBorrowDate);
            this.panel3.Controls.Add(this.txbStatus);
            this.panel3.Controls.Add(this.txbShelfID);
            this.panel3.Controls.Add(this.txbFloorID);
            this.panel3.Controls.Add(this.txbAmount);
            this.panel3.Controls.Add(this.txbBookID);
            this.panel3.Controls.Add(this.txbBorrowID);
            this.panel3.Controls.Add(this.txbUserID);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 476);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1279, 195);
            this.panel3.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(1079, 91);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(177, 55);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Xác Nhận Cho Mượn";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(146, 147);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(244, 22);
            this.dtpBorrowDate.TabIndex = 15;
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(626, 149);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(122, 22);
            this.txbStatus.TabIndex = 14;
            // 
            // txbShelfID
            // 
            this.txbShelfID.Location = new System.Drawing.Point(626, 28);
            this.txbShelfID.Name = "txbShelfID";
            this.txbShelfID.ReadOnly = true;
            this.txbShelfID.Size = new System.Drawing.Size(122, 22);
            this.txbShelfID.TabIndex = 13;
            // 
            // txbFloorID
            // 
            this.txbFloorID.Location = new System.Drawing.Point(626, 66);
            this.txbFloorID.Name = "txbFloorID";
            this.txbFloorID.ReadOnly = true;
            this.txbFloorID.Size = new System.Drawing.Size(122, 22);
            this.txbFloorID.TabIndex = 12;
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(626, 107);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.ReadOnly = true;
            this.txbAmount.Size = new System.Drawing.Size(122, 22);
            this.txbAmount.TabIndex = 11;
            // 
            // txbBookID
            // 
            this.txbBookID.Location = new System.Drawing.Point(146, 107);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.ReadOnly = true;
            this.txbBookID.Size = new System.Drawing.Size(244, 22);
            this.txbBookID.TabIndex = 10;
            // 
            // txbBorrowID
            // 
            this.txbBorrowID.Location = new System.Drawing.Point(146, 31);
            this.txbBorrowID.Name = "txbBorrowID";
            this.txbBorrowID.ReadOnly = true;
            this.txbBorrowID.Size = new System.Drawing.Size(244, 22);
            this.txbBorrowID.TabIndex = 9;
            // 
            // txbUserID
            // 
            this.txbUserID.Location = new System.Drawing.Point(146, 66);
            this.txbUserID.Name = "txbUserID";
            this.txbUserID.ReadOnly = true;
            this.txbUserID.Size = new System.Drawing.Size(244, 22);
            this.txbUserID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Trạng Thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Lượng Mượn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tầng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Kệ Số:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Mượn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Người Mượn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Mượn:";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(818, 110);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.ReadOnly = true;
            this.txbQuantity.Size = new System.Drawing.Size(122, 22);
            this.txbQuantity.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(815, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Số Lượng Sách Còn:";
            // 
            // FormViewBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 683);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormViewBorrow";
            this.Text = "FormViewBorrow";
            this.Load += new System.EventHandler(this.FormViewBorrow_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.TextBox txbShelfID;
        private System.Windows.Forms.TextBox txbFloorID;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.TextBox txbBorrowID;
        private System.Windows.Forms.TextBox txbUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label label9;
    }
}