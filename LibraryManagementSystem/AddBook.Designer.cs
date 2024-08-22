namespace LibraryManagementSystem
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cbFloorID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbShelfID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbCategoryName = new System.Windows.Forms.ComboBox();
            this.cbAuthorName = new System.Windows.Forms.ComboBox();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.dtpPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.txbDescriptions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Controls.Add(this.cbFloorID);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbShelfID);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.numericQuantity);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.cbCategoryName);
            this.panel2.Controls.Add(this.cbAuthorName);
            this.panel2.Controls.Add(this.txbBookName);
            this.panel2.Controls.Add(this.txbBookID);
            this.panel2.Controls.Add(this.dtpPublicationDate);
            this.panel2.Controls.Add(this.txbDescriptions);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 572);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(170, 331);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(279, 177);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbFloorID
            // 
            this.cbFloorID.FormattingEnabled = true;
            this.cbFloorID.Location = new System.Drawing.Point(351, 101);
            this.cbFloorID.Name = "cbFloorID";
            this.cbFloorID.Size = new System.Drawing.Size(98, 24);
            this.cbFloorID.TabIndex = 19;
            this.cbFloorID.Text = "Chọn Tầng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tầng:";
            // 
            // cbShelfID
            // 
            this.cbShelfID.FormattingEnabled = true;
            this.cbShelfID.Location = new System.Drawing.Point(170, 101);
            this.cbShelfID.Name = "cbShelfID";
            this.cbShelfID.Size = new System.Drawing.Size(98, 24);
            this.cbShelfID.TabIndex = 17;
            this.cbShelfID.Text = "Chọn kệ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kệ Số:";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(170, 289);
            this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(279, 22);
            this.numericQuantity.TabIndex = 15;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số Lượng:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(374, 533);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(170, 533);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbCategoryName
            // 
            this.cbCategoryName.FormattingEnabled = true;
            this.cbCategoryName.Location = new System.Drawing.Point(170, 183);
            this.cbCategoryName.Name = "cbCategoryName";
            this.cbCategoryName.Size = new System.Drawing.Size(279, 24);
            this.cbCategoryName.TabIndex = 11;
            this.cbCategoryName.Text = "Chọn Hoặc Thêm Danh Mục";
            // 
            // cbAuthorName
            // 
            this.cbAuthorName.FormattingEnabled = true;
            this.cbAuthorName.Location = new System.Drawing.Point(170, 144);
            this.cbAuthorName.Name = "cbAuthorName";
            this.cbAuthorName.Size = new System.Drawing.Size(279, 24);
            this.cbAuthorName.TabIndex = 10;
            this.cbAuthorName.Text = "Chọn Hoặc Thêm Tác Giả";
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(170, 57);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(279, 22);
            this.txbBookName.TabIndex = 9;
            // 
            // txbBookID
            // 
            this.txbBookID.Location = new System.Drawing.Point(170, 17);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.Size = new System.Drawing.Size(279, 22);
            this.txbBookID.TabIndex = 8;
            // 
            // dtpPublicationDate
            // 
            this.dtpPublicationDate.Location = new System.Drawing.Point(170, 213);
            this.dtpPublicationDate.Name = "dtpPublicationDate";
            this.dtpPublicationDate.Size = new System.Drawing.Size(279, 22);
            this.dtpPublicationDate.TabIndex = 7;
            // 
            // txbDescriptions
            // 
            this.txbDescriptions.Location = new System.Drawing.Point(170, 253);
            this.txbDescriptions.Name = "txbDescriptions";
            this.txbDescriptions.Size = new System.Drawing.Size(279, 22);
            this.txbDescriptions.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mô Tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày Xuất Bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Danh Mục:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Tác Giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sách:";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 596);
            this.Controls.Add(this.panel2);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategoryName;
        private System.Windows.Forms.ComboBox cbAuthorName;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.DateTimePicker dtpPublicationDate;
        private System.Windows.Forms.TextBox txbDescriptions;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbFloorID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbShelfID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}