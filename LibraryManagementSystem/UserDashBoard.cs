using LibraryManagementSystem.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class UserDashBoard : Form
    {
        Books currentBook;
        Borrow currentBorrow;
        FormLogin formLogin;
        private string phoneNumber;
        private int currentQuantity;
        private int bookQuantity;

        private int userID;

        public int UserID { get => userID; set => userID = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int CurrentQuantity { get => currentQuantity; set => currentQuantity = value; }
        public int BookQuantity { get => bookQuantity; set => bookQuantity = value; }

        public UserDashBoard()
        {
            InitializeComponent();
        }

        public UserDashBoard(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneNumber = formLogin.txbPhone.Text;
            UserProfile addNewUser = new UserProfile(this);
            addNewUser.ShowDialog();
        }

        private void TextSearch()
        {
            try
            {
                string strSearch = "'%" + txbSearch.Text + "%'";
                string strSelectAll = "SELECT BookID as N'Mã Sách', BookName as N'Tên Sách', ShelfID as N'Kệ Số', FloorID as N'Tầng', AuthorName as N'Tác Giả', CategoryName as N'Danh Mục', Date_publication as N'Ngày Xuất Bản', Descriptions as N'Mô Tả', Quantity as N'Số Lượng', image as N'Ảnh' FROM Books";
                string strSelectBName = strSelectAll + " where BookName like N" + strSearch;
                string strSelectBNameAuthor = strSelectAll + " where BookName like N" + strSearch + " AND AuthorName like N'%" + cbAuthorFilter.Text + "%'";
                string strSelectBNameCategory = strSelectAll + " where BookName like N" + strSearch + " AND CategoryName like N'%" + cbCategoryFilter.Text + "%'";
                string strSelectBNameAuthorAndCategory = strSelectAll + " where BookName like N" + strSearch + " AND AuthorName like N'%" + cbAuthorFilter.Text + "%'" + " AND CategoryName like N'%" + cbCategoryFilter.Text + "%'";


                // With Datetime
                string strSelectAllDate = "SELECT BookID as N'Mã Sách', BookName as N'Tên Sách', ShelfID as N'Kệ Số', FloorID as N'Tầng', AuthorName as N'Tác Giả', CategoryName as N'Danh Mục', Date_publication as N'Ngày Xuất Bản', Descriptions as N'Mô Tả', Quantity as N'Số Lượng', image as N'Ảnh' FROM Books where Date_publication between '" + dtpPublicationDateFrom.Value + "' AND '" + dtpPublicationDateTo.Value + "'";
                string strSelectBNameDate = strSelectAll + " where (BookName like N" + strSearch + ") AND (Date_publication between '" + dtpPublicationDateFrom.Value + "' AND '" + dtpPublicationDateTo.Value + "')";
                string strSelectBNameAuthorDate = strSelectAll + " where (BookName like N" + strSearch + " AND AuthorName like N'%" + cbAuthorFilter.Text + "%') AND (Date_publication between '" + dtpPublicationDateFrom.Value + "' AND '" + dtpPublicationDateTo.Value + "')";
                string strSelectBNameCategoryDate = strSelectAll + " where (BookName like N" + strSearch + " AND CategoryName like N'%" + cbCategoryFilter.Text + "%') AND (Date_publication between '" + dtpPublicationDateFrom.Value + "' AND '" + dtpPublicationDateTo.Value + "')";
                string strSelectBNameAuthorAndCategoryDate = strSelectAll + " where (BookName like N" + strSearch + " AND AuthorName like N'%" + cbAuthorFilter.Text + "%'" + " AND CategoryName like N'%" + cbCategoryFilter.Text + "%') AND (Date_publication between '" + dtpPublicationDateFrom.Value + "' AND '" + dtpPublicationDateTo.Value + "')";


                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand myCommand;
                SqlDataAdapter da;
                DataSet ds;

                if (dtpPublicationDateFrom.Enabled == true && dtpPublicationDateTo.Enabled == true)
                {
                    if (!string.IsNullOrWhiteSpace(txbSearch.Text) && string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectBNameDate, out myCommand, out da, out ds);
                    }
                    else if (!string.IsNullOrWhiteSpace(txbSearch.Text) && !string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectBNameAuthorDate, out myCommand, out da, out ds);
                    }
                    else if (!string.IsNullOrWhiteSpace(txbSearch.Text) && string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && !string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectBNameCategoryDate, out myCommand, out da, out ds);
                    }
                    else if (!string.IsNullOrWhiteSpace(txbSearch.Text) && !string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && !string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectBNameAuthorAndCategoryDate, out myCommand, out da, out ds);
                    }
                    else if (string.IsNullOrWhiteSpace(txbSearch.Text) && string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectAllDate, out myCommand, out da, out ds);
                    }
                }
                else if (dtpPublicationDateFrom.Enabled == false || dtpPublicationDateTo.Enabled == false)
                {
                    if (!string.IsNullOrWhiteSpace(txbSearch.Text) && string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectBName, out myCommand, out da, out ds);
                    }
                    else if (!string.IsNullOrWhiteSpace(txbSearch.Text) && !string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectBNameAuthor, out myCommand, out da, out ds);
                    }
                    else if (!string.IsNullOrWhiteSpace(txbSearch.Text) && string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && !string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectBNameCategory, out myCommand, out da, out ds);
                    }
                    else if (!string.IsNullOrWhiteSpace(txbSearch.Text) && !string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && !string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectBNameAuthorAndCategory, out myCommand, out da, out ds);
                    }
                    else if (string.IsNullOrWhiteSpace(txbSearch.Text) && string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectAll, out myCommand, out da, out ds);
                    }
                }

                myCommand = new SqlCommand(strSelectAll, sqlConnection);
                da = new SqlDataAdapter(myCommand);
                ds = new DataSet();
                da.Fill(ds, "Books");
                ds.WriteXml("Books.xml");
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void Search(string query, out SqlCommand myCommand, out SqlDataAdapter da, out DataSet ds)
        {
            string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
            SqlConnection sqlConnection = new SqlConnection(strConnectString);
            sqlConnection.Open();
            myCommand = new SqlCommand(query, sqlConnection);
            da = new SqlDataAdapter(myCommand);
            ds = new DataSet();
            da.Fill(ds, "Books");
            dgvBooks.DataSource = ds;
            dgvBooks.DataMember = "Books";
            sqlConnection.Close();
        }

        private void GetCurrentBook()
        {
            try
            {
                txbBookID.Text = currentBook.BookID.ToString();
                txbBookName.Text = currentBook.BookName?.ToString();
                txbShelfID.Text = currentBook.ShelfID.ToString();
                txbFloorID.Text = currentBook.FloorID.ToString();
                txbAuthorName.Text = currentBook.AuthorName?.ToString();
                txbCategoryName.Text = currentBook.CategoryName?.ToString();
                dtpPublicationDate.Text = currentBook.PublicationDate.ToString();
                txbQuantity.Text = currentBook.Quantity.ToString();
                numericQuantity.Value = 1;
                txbDetails.Text = currentBook.Descriptions?.ToString();
                string imagesFolder = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images\\";
                pictureBox.Image = Image.FromFile(imagesFolder + currentBook.Image?.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetCurrentRow(DataGridViewRow dr)
        {
            if (dr != null)
            {
                try
                {
                    currentBook = new Books();
                    currentBook.BookID = int.Parse(dr.Cells["Mã Sách"].Value?.ToString());
                    currentBook.BookName = dr.Cells["Tên Sách"].Value?.ToString();
                    currentBook.ShelfID = int.Parse(dr.Cells["Kệ Số"].Value?.ToString());
                    currentBook.FloorID = int.Parse(dr.Cells["Tầng"].Value?.ToString());
                    currentBook.AuthorName = dr.Cells["Tác Giả"].Value?.ToString();
                    currentBook.CategoryName = dr.Cells["Danh Mục"].Value?.ToString();
                    currentBook.PublicationDate = Convert.ToDateTime(dr.Cells["Ngày Xuất Bản"].Value);
                    currentBook.Descriptions = dr.Cells["Mô Tả"].Value?.ToString();
                    currentBook.Quantity = int.Parse(dr.Cells["Số Lượng"].Value?.ToString());
                    CurrentQuantity = currentBook.Quantity;
                    currentBook.Image = dr.Cells["Ảnh"].Value?.ToString();
                    Text = "Mã Sách " + currentBook.BookID.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvBooks.Rows[e.RowIndex];
                GetCurrentRow(dr);
                GetCurrentBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBooks_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvBooks.Rows[e.RowIndex];
            GetCurrentRow(dr);
        }

        
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbSearch.Text))
            {
                btnLoadAll_Click(sender, e);
            }
            else
            {
                TextSearch();
            }
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
            cbAuthorFilter.Text = "";
            cbCategoryFilter.Text = "";
            ckbDatePublication.Checked = false;

            try
            {
                string strSearch = "'%" + txbSearch.Text + "%'";
                string strSelectAll = "SELECT BookID as N'Mã Sách', BookName as N'Tên Sách', ShelfID as N'Kệ Số', FloorID as N'Tầng', AuthorName as N'Tác Giả', CategoryName as N'Danh Mục', Date_publication as N'Ngày Xuất Bản', Descriptions as N'Mô Tả', Quantity as N'Số Lượng', image as N'Ảnh' FROM Books";

                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand myCommand;
                SqlDataAdapter da;
                DataSet ds;

                Search(strSelectAll, out myCommand, out da, out ds);

                myCommand = new SqlCommand(strSelectAll, sqlConnection);
                da = new SqlDataAdapter(myCommand);
                ds = new DataSet();
                da.Fill(ds, "Books");
                ds.WriteXml("Books.xml");
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void UserDashBoard_Load(object sender, EventArgs e)
        {
            PhoneNumber = formLogin.txbPhone.Text;
            GetUserID();
            LoadAuthor();
            LoadCategory();
            LoadLoan();
            LoadBorrow();
            btnLoadAll_Click(sender, e);
            dtpPublicationDateFrom.Enabled = false;
            dtpPublicationDateTo.Enabled = false;
            timer.Start();
        }

        void LoadAuthor()
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                string command = "Select AuthorName from Authors";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(command, conn);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = command;
                sqlCommand.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    cbAuthorFilter.Items.Add(row["AuthorName"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        void LoadCategory()
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                string command = "Select CategoryName from Categories";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(command, conn);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = command;
                sqlCommand.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    cbCategoryFilter.Items.Add(row["CategoryName"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        void LoadLoan()
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                DataTable dt = new DataTable();
                string strCommand = "USP_v_Loan";
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand myCommand = new SqlCommand(strCommand, sqlConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                da.Fill(dt);
                bindingSource.DataSource = dt;
                dgvLoan.DataSource = bindingSource;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        void LoadBorrow()
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                DataTable dt = new DataTable();
                string strCommand = "USP_v_Borrow";
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand myCommand = new SqlCommand(strCommand, sqlConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                da.Fill(dt);
                bindingSource.DataSource = dt;
                dgvBorrow.DataSource = bindingSource;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            AddBorrow();
            TextSearch();
        }

        private void btnBorrowCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác Nhận Xóa Đơn Mượn " + txbBorrowAmount.Text.ToString() + " Sách " + currentBook.BookName + "?", "Xác Nhận Xóa Mượn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string command = "DeleteBorrow";
                    string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                    SqlConnection sqlConnection = new SqlConnection(strConnectString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@BorrowID", txbBorrowID.Text?.ToString());
                    int row_affected = sqlCommand.ExecuteNonQuery();
                    if (row_affected > 0)
                    {
                        MessageBox.Show("Đã Xóa Mã Mượn " + sqlCommand.Parameters["@BorrowID"].Value.ToString());
                    }
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
                }
                txbBorrowID.Clear();
                txbBorrowBookID.Clear();
                txbBorrowAmount.Clear();
                txbBorrowFloorID.Clear();
                txbBorrowShelfID.Clear();
                dtpBorrowDate.Value = DateTime.Now;
                txbBorrowStatus.Clear();
                txbBorrowQuantity.Clear();
            }
        }

        private void dgvBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvBorrow.Rows[e.RowIndex];
                GetCurrentBorrowRow(dr);
                GetCurrentBorrow();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void dgvBorrow_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvBorrow.Rows[e.RowIndex];
            GetCurrentBorrowRow(dr);
        }

        private void GetCurrentBorrow()
        {
            try
            {
                txbBorrowID.Text = currentBorrow.BorrowID.ToString();
                //txbUserID.Text = currentBorrow.UserID.ToString();
                txbBorrowBookID.Text = currentBorrow.BookID.ToString();
                txbBorrowAmount.Text = currentBorrow.Amount.ToString();
                txbBorrowFloorID.Text = currentBook.FloorID.ToString();
                txbBorrowShelfID.Text = currentBook.ShelfID.ToString();
                dtpBorrowDate.Text = currentBorrow.BorrowDate.ToString();
                txbBorrowStatus.Text = currentBorrow.Status?.ToString();
                txbBorrowQuantity.Text = CurrentQuantity.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetCurrentBorrowRow(DataGridViewRow dr)
        {
            if (dr != null)
            {
                try
                {
                    currentBorrow = new Borrow();
                    //currentUser = new Account();
                    currentBook = new Books();

                    currentBorrow.BorrowID = int.Parse(dr.Cells["Mã Mượn"].Value?.ToString());
                    //currentBorrow.UserID = int.Parse(dr.Cells["Mã Người Mượn"].Value?.ToString());
                    /*currentUser.Username = dr.Cells["Tên Người Mượn"].Value?.ToString();
                    currentUser.Address = dr.Cells["Địa Chỉ"].Value?.ToString();
                    currentUser.PhoneNumber = dr.Cells["Số Điện Thoại"].Value?.ToString();*/
                    currentBorrow.BookID = int.Parse(dr.Cells["Mã Sách"].Value?.ToString());
                    currentBook.BookName = dr.Cells["Tên Sách"].Value?.ToString();
                    currentBook.ShelfID = int.Parse(dr.Cells["Kệ Số"].Value?.ToString());
                    currentBook.FloorID = int.Parse(dr.Cells["Tầng"].Value?.ToString());
                    currentBorrow.BorrowDate = Convert.ToDateTime(dr.Cells["Ngày Mượn"].Value);
                    currentBorrow.Amount = int.Parse(dr.Cells["Số Lượng Mượn"].Value?.ToString());
                    currentBook.Quantity = int.Parse(dr.Cells["Số Lượng Sách Còn"].Value?.ToString());
                    CurrentQuantity = int.Parse(dr.Cells["Số Lượng Sách Còn"].Value?.ToString());
                    currentBorrow.Status = dr.Cells["Trạng Thái"].Value?.ToString();
                    Text = currentBorrow.BorrowID.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetUserID()
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from Users where PhoneNumber = " + PhoneNumber, sqlConnection);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    UserID = Convert.ToInt32(dr.GetValue(0).ToString());
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void GetBookQuantity()
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select Quantity from Books where BookID = " + currentBook.BookID.ToString(), sqlConnection);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    BookQuantity = Convert.ToInt32(dr.GetValue(0).ToString());
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        void AddBorrow()
        {
            GetUserID();
            GetBookQuantity();

            try
            {
                if (CurrentQuantity <= 0 || BookQuantity <= 0)
                {
                    MessageBox.Show("Đã Hết Sách Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (numericQuantity.Value > CurrentQuantity)
                {
                    MessageBox.Show("Không Đủ Số Lượng Sách Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (numericQuantity.Value <= 0)
                    {
                        MessageBox.Show("Hãy Chọn Số Lượng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Xác Nhận Mượn " + numericQuantity.Value.ToString() + " Sách " + txbBookName.Text + "?", "Xác Nhận Mượn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            string command = "AddBorrow";
                            string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                            SqlConnection sqlConnection = new SqlConnection(strConnectString);
                            sqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.Parameters.AddWithValue("@BookID", txbBookID.Text?.ToString());
                            sqlCommand.Parameters.AddWithValue("@UserID", UserID);
                            sqlCommand.Parameters.AddWithValue("@Amount", numericQuantity.Value);
                            sqlCommand.Parameters.Add(new SqlParameter("@BorrowID", SqlDbType.Int));
                            sqlCommand.Parameters["@BorrowID"].Direction = ParameterDirection.Output;
                            int row_affected = sqlCommand.ExecuteNonQuery();
                            if (row_affected > 0)
                            {
                                MessageBox.Show("Đã Thêm Mã Mượn " + sqlCommand.Parameters["@BorrowID"].Value.ToString() + " Vào Hàng Đợi!");
                            }
                            sqlConnection.Close();
                        }
                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LoadLoan();
            LoadBorrow();
            timer.Start();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                //formLogin = new FormLogin(this);
                //formLogin.Show();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportBookError reportBookError = new ReportBookError(this);
            reportBookError.Show();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Tài Khoản " + PhoneNumber.ToString() + " này không?", "Xóa Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DeleteUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void DeleteUser()
        {
            GetUserID();

            try
            {
                string strCommand = "DeleteUser";
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand myCommand = new SqlCommand(strCommand, sqlConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@UserID", UserID);
                int row_affected = myCommand.ExecuteNonQuery();
                if (row_affected > 0)
                {
                    MessageBox.Show("Tài Khoản " + PhoneNumber.ToString() + " Đã được xóa!");
                    this.Close();
                    formLogin = new FormLogin(this);
                    formLogin.Show();
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void cbAuthorFilter_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cbCategoryFilter_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            try
            {
                string strAuthorFilter = cbAuthorFilter.Text;
                string strCategoryFilter = cbCategoryFilter.Text;

                string strSelectAuthor = "SELECT BookID as N'Mã Sách', BookName as N'Tên Sách', ShelfID as N'Kệ Số', FloorID as N'Tầng', AuthorName as N'Tác Giả', CategoryName as N'Danh Mục', Date_publication as N'Ngày Xuất Bản', Descriptions as N'Mô Tả', Quantity as N'Số Lượng', image as N'Ảnh' FROM Books where AuthorName like N'%" + strAuthorFilter + "%'";

                string strSelectCategory = "SELECT BookID as N'Mã Sách', BookName as N'Tên Sách', ShelfID as N'Kệ Số', FloorID as N'Tầng', AuthorName as N'Tác Giả', CategoryName as N'Danh Mục', Date_publication as N'Ngày Xuất Bản', Descriptions as N'Mô Tả', Quantity as N'Số Lượng', image as N'Ảnh' FROM Books where CategoryName like N'%" + strCategoryFilter + "%'";

                string strSelectBoth = "SELECT BookID as N'Mã Sách', BookName as N'Tên Sách', ShelfID as N'Kệ Số', FloorID as N'Tầng', AuthorName as N'Tác Giả', CategoryName as N'Danh Mục', Date_publication as N'Ngày Xuất Bản', Descriptions as N'Mô Tả', Quantity as N'Số Lượng', image as N'Ảnh' FROM Books where AuthorName like N'%" + strAuthorFilter + "%' And CategoryName like N'%" + strCategoryFilter + "%'";

                //WithDate
                string strSelectAuthorDate = "SELECT BookID as N'Mã Sách', BookName as N'Tên Sách', ShelfID as N'Kệ Số', FloorID as N'Tầng', AuthorName as N'Tác Giả', CategoryName as N'Danh Mục', Date_publication as N'Ngày Xuất Bản', Descriptions as N'Mô Tả', Quantity as N'Số Lượng', image as N'Ảnh' FROM Books where (AuthorName like N'%" + strAuthorFilter + "%') AND (Date_publication between '" + dtpPublicationDateFrom.Value + "' AND '" + dtpPublicationDateTo.Value + "')";

                string strSelectCategoryDate = "SELECT BookID as N'Mã Sách', BookName as N'Tên Sách', ShelfID as N'Kệ Số', FloorID as N'Tầng', AuthorName as N'Tác Giả', CategoryName as N'Danh Mục', Date_publication as N'Ngày Xuất Bản', Descriptions as N'Mô Tả', Quantity as N'Số Lượng', image as N'Ảnh' FROM Books where (CategoryName like N'%" + strCategoryFilter + "%') AND (Date_publication between '" + dtpPublicationDateFrom.Value + "' AND '" + dtpPublicationDateTo.Value + "')";

                string strSelectBothDate = "SELECT BookID as N'Mã Sách', BookName as N'Tên Sách', ShelfID as N'Kệ Số', FloorID as N'Tầng', AuthorName as N'Tác Giả', CategoryName as N'Danh Mục', Date_publication as N'Ngày Xuất Bản', Descriptions as N'Mô Tả', Quantity as N'Số Lượng', image as N'Ảnh' FROM Books where (AuthorName like N'%" + strAuthorFilter + "%' And CategoryName like N'%" + strCategoryFilter + "%') And (Date_publication between '" + dtpPublicationDateFrom.Value + "' AND '" + dtpPublicationDateTo.Value + "')"; ;

                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand myCommand;
                SqlDataAdapter da;
                DataSet ds;
                if (dtpPublicationDateFrom.Enabled == false && dtpPublicationDateTo.Enabled == false)
                {
                    if (!string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectAuthor, out myCommand, out da, out ds);
                    }
                    else if (string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && !string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectCategory, out myCommand, out da, out ds);
                    }
                    else if (!string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && !string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectBoth, out myCommand, out da, out ds);
                    }
                    else
                    {
                        TextSearch();
                    }
                }
                else if (dtpPublicationDateFrom.Enabled == true && dtpPublicationDateTo.Enabled == true)
                {
                    if (!string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectAuthorDate, out myCommand, out da, out ds);
                    }
                    else if (string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && !string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectCategoryDate, out myCommand, out da, out ds);
                    }
                    else if (!string.IsNullOrWhiteSpace(cbAuthorFilter.Text) && !string.IsNullOrWhiteSpace(cbCategoryFilter.Text))
                    {
                        Search(strSelectBothDate, out myCommand, out da, out ds);
                    }
                    else
                    {
                        TextSearch();
                    }
                }

                sqlConnection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void cbSort_TextChanged(object sender, EventArgs e)
        {
            if (cbAZ.Text == "A - Z")
            {
                if (cbSort.Text == "Tên Sách")
                {
                    dgvBooks.Sort(dgvBooks.Columns[1], ListSortDirection.Ascending);
                }
                else if (cbSort.Text == "Tác Giả")
                {
                    dgvBooks.Sort(dgvBooks.Columns[4], ListSortDirection.Ascending);
                }
                else if (cbSort.Text == "Danh Mục")
                {
                    dgvBooks.Sort(dgvBooks.Columns[5], ListSortDirection.Ascending);
                }
                else if (cbSort.Text == "Ngày Xuất Bản")
                {
                    dgvBooks.Sort(dgvBooks.Columns[6], ListSortDirection.Ascending);
                }
                else if (cbSort.Text == "Số Lượng")
                {
                    dgvBooks.Sort(dgvBooks.Columns[8], ListSortDirection.Ascending);
                }
            }
            else if (cbAZ.Text == "Z - A")
            {
                if (cbSort.Text == "Tên Sách")
                {
                    dgvBooks.Sort(dgvBooks.Columns[1], ListSortDirection.Descending);
                }
                else if (cbSort.Text == "Tác Giả")
                {
                    dgvBooks.Sort(dgvBooks.Columns[4], ListSortDirection.Descending);
                }
                else if (cbSort.Text == "Danh Mục")
                {
                    dgvBooks.Sort(dgvBooks.Columns[5], ListSortDirection.Descending);
                }
                else if (cbSort.Text == "Ngày Xuất Bản")
                {
                    dgvBooks.Sort(dgvBooks.Columns[6], ListSortDirection.Descending);
                }
                else if (cbSort.Text == "Số Lượng")
                {
                    dgvBooks.Sort(dgvBooks.Columns[8], ListSortDirection.Descending);
                }
            }
        }

        private void cbAZ_TextChanged(object sender, EventArgs e)
        {
            cbSort_TextChanged(sender, e);
        }

        private void dtpPublicationDateFrom_ValueChanged(object sender, EventArgs e)
        {
            TextSearch();
            Filter();
        }

        private void dtpPublicationDateTo_ValueChanged(object sender, EventArgs e)
        {
            TextSearch();
            Filter();
        }

        private void ckbDatePublication_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDatePublication.Checked)
            {
                dtpPublicationDateFrom.Enabled = true;
                dtpPublicationDateTo.Enabled = true;
                TextSearch();
            }
            else
            {
                dtpPublicationDateFrom.Enabled = false;
                dtpPublicationDateTo.Enabled = false;
                TextSearch();
            }
        }
    }
}
