using LibraryManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class DashBoard : Form
    {
        Loan currentLoan;
        Borrow currentBorrow;
        Account currentUser;
        Books currentBook;
        TimeSpan timeSpan;
        int amountOfFine;

        FormLogin formLogin;

        public TimeSpan TimeSpan { get => timeSpan; set => timeSpan = value; }
        public int AmountOfFine { get => amountOfFine; set => amountOfFine = value; }

        public DashBoard()
        {
            InitializeComponent();
        }

        public DashBoard(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                //formLogin = new FormLogin(this);
                //formLogin.Show();
            }
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook(true);
            addBook.Show();
        }

        private void viewBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks();
            viewBooks.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfile addNewUser = new UserProfile(true);
            addNewUser.Show();
        }

        private void viewStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInfo viewStudentInfo = new ViewStudentInfo();
            viewStudentInfo.Show();
        }

        private void viewStudentBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            btnSearch_Click(sender, e);
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string strSearch = txbSearch.Text;

                string strSelectAll = "SELECT Loan.LoanID as N'Mã Hóa Đơn', Borrow.UserID as N'Mã Người Mượn', Users.UserName as N'Tên Người Mượn', Users.Address as N'Địa Chỉ', Users.PhoneNumber as N'Số Điện Thoại',\r\n\t\t   Books.BookName as N'Tên Sách', Books.ShelfID as N'Kệ Số', Books.FloorID as N'Tầng', Borrow.BorrowedDate as N'Ngày Mượn', Borrow.Amount as N'Số Lượng Mượn',\r\n\t\t   Loan.ConfirmDate as N'Ngày Được Mượn', Loan.Overdue as N'Hạn Trả', Loan.ReturnDate as N'Ngày Trả', Loan.AmountOfFine as N'Phạt', Loan.status as N'Trạng Thái'\r\n\tFROM Books INNER JOIN\r\n                  Borrow ON Books.BookID = Borrow.BookID INNER JOIN\r\n                  Loan ON Borrow.BorrowID = Loan.BorrowID INNER JOIN\r\n                  Users ON Borrow.UserID = Users.UserID";

                string strSelect = strSelectAll + " where Loan.LoanID like '%" + strSearch + "%' OR Loan.UserID like '%" + strSearch + "%' OR Users.UserName like N'%" + txbSearch.Text + "%' OR Users.Address like N'%" + txbSearch.Text + "%' OR Users.PhoneNumber like '%" + txbSearch.Text + "%' OR Books.BookName like N'%" + txbSearch.Text + "%'";
                
                
                
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand myCommand;
                SqlDataAdapter da;
                DataSet ds;
                if (!string.IsNullOrWhiteSpace(txbSearch.Text))
                {
                    Search(strSelect, out myCommand, out da, out ds);
                }
                else if (string.IsNullOrWhiteSpace(txbSearch.Text))
                {
                    Search(strSelectAll, out myCommand, out da, out ds);
                }

                myCommand = new SqlCommand(strSelectAll, sqlConnection);
                da = new SqlDataAdapter(myCommand);
                ds = new DataSet();
                da.Fill(ds, "Loan");
                ds.WriteXml("Loan.xml");
                sqlConnection.Dispose();
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
            myCommand = new SqlCommand(query, sqlConnection);
            da = new SqlDataAdapter(myCommand);
            ds = new DataSet();
            da.Fill(ds, "Loan");
            dgvLoan.DataSource = ds;
            dgvLoan.DataMember = "Loan";
            sqlConnection.Close();
        }

        private void dgvLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvLoan.Rows[e.RowIndex];
                GetCurrentRow(dr);
                GetCurrentLoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLoan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvLoan.Rows[e.RowIndex];
            GetCurrentRow(dr);
        }


        private void GetCurrentLoan()
        {
            try
            {

                txbAmountOfFine.Text = 0.ToString();
                txbLoanID.Text = currentLoan.LoanID.ToString();
                txbUsername.Text = currentUser.Username?.ToString();
                txbAddress.Text = currentUser.Address?.ToString();
                txbPhone.Text = currentUser.PhoneNumber?.ToString();
                txbBookName.Text = currentBook.BookName?.ToString();
                numericAmount.Text = currentBorrow.Amount.ToString();
                dtpBorrowedDate.Text = currentBorrow.BorrowDate.ToString();
                dtpOverdue.Text = currentLoan.Overdue.ToString();
                txbStatus.Text = currentLoan.Status?.ToString();

                dtpReturnedDate.Value = DateTime.Now;
                TimeSpan = dtpReturnedDate.Value - dtpOverdue.Value;
                AmountOfFine = Convert.ToInt32(10000 + 10000 * TimeSpan.Days * 0.1);

                if (dtpReturnedDate.Value > dtpOverdue.Value && txbStatus.Text == "Chưa Trả")
                {
                    txbAmountOfFine.Text = AmountOfFine.ToString();
                }
                else
                {
                    txbAmountOfFine.Text = currentLoan.AmountOfFine.ToString();
                }
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
                    currentLoan = new Loan();
                    currentBorrow = new Borrow();
                    currentUser = new Account();
                    currentBook = new Books();

                    currentLoan.LoanID = int.Parse(dr.Cells["Mã Hóa Đơn"].Value?.ToString());
                    currentBorrow.UserID = int.Parse(dr.Cells["Mã Người Mượn"].Value?.ToString());
                    currentUser.Username = dr.Cells["Tên Người Mượn"].Value?.ToString();
                    currentUser.Address = dr.Cells["Địa Chỉ"].Value?.ToString();
                    currentUser.PhoneNumber = dr.Cells["Số Điện Thoại"].Value?.ToString();
                    currentBook.BookName = dr.Cells["Tên Sách"].Value?.ToString();
                    currentBook.ShelfID = int.Parse(dr.Cells["Kệ Số"].Value?.ToString());
                    currentBook.FloorID = int.Parse(dr.Cells["Tầng"].Value?.ToString());
                    currentBorrow.BorrowDate = Convert.ToDateTime(dr.Cells["Ngày Mượn"].Value);
                    currentBorrow.Amount = int.Parse(dr.Cells["Số Lượng Mượn"].Value?.ToString());
                    currentLoan.ConfirmDate = Convert.ToDateTime(dr.Cells["Ngày Được Mượn"].Value);
                    currentLoan.Overdue = Convert.ToDateTime(dr.Cells["Hạn Trả"].Value);
                    currentLoan.ReturnedDate = Convert.ToDateTime(dr.Cells["Ngày Trả"].Value);
                    currentLoan.AmountOfFine = int.Parse(dr.Cells["Phạt"].Value?.ToString());
                    currentLoan.Status = dr.Cells["Trạng Thái"].Value?.ToString();

                    Text = currentLoan.LoanID.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbAZ_TextChanged(object sender, EventArgs e)
        {
            cbSort_TextChanged(sender, e);
        }

        private void cbSort_TextChanged(object sender, EventArgs e)
        {
            if (cbAZ.Text == "A - Z")
            {
                if (cbSort.Text == "Tên Sách")
                {
                    dgvLoan.Sort(dgvLoan.Columns[5], ListSortDirection.Ascending);
                }
                else if (cbSort.Text == "Tên Người Mượn")
                {
                    dgvLoan.Sort(dgvLoan.Columns[2], ListSortDirection.Ascending);
                }
                else if (cbSort.Text == "Số Lượng Mượn")
                {
                    dgvLoan.Sort(dgvLoan.Columns[9], ListSortDirection.Ascending);
                }
                else if (cbSort.Text == "Trạng Thái")
                {
                    dgvLoan.Sort(dgvLoan.Columns[14], ListSortDirection.Ascending);
                }
                else if (cbSort.Text == "Ngày Mượn")
                {
                    dgvLoan.Sort(dgvLoan.Columns[10], ListSortDirection.Ascending);
                }
                else if (cbSort.Text == "Phạt")
                {
                    dgvLoan.Sort(dgvLoan.Columns[13], ListSortDirection.Ascending);
                }
            }
            else if (cbAZ.Text == "Z - A")
            {
                if (cbSort.Text == "Tên Sách")
                {
                    dgvLoan.Sort(dgvLoan.Columns[5], ListSortDirection.Descending);
                }
                else if (cbSort.Text == "Tên Người Mượn")
                {
                    dgvLoan.Sort(dgvLoan.Columns[2], ListSortDirection.Descending);
                }
                else if (cbSort.Text == "Số Lượng Mượn")
                {
                    dgvLoan.Sort(dgvLoan.Columns[9], ListSortDirection.Descending);
                }
                else if (cbSort.Text == "Trạng Thái")
                {
                    dgvLoan.Sort(dgvLoan.Columns[14], ListSortDirection.Descending);
                }
                else if (cbSort.Text == "Ngày Mượn")
                {
                    dgvLoan.Sort(dgvLoan.Columns[10], ListSortDirection.Descending);
                }
                else if (cbSort.Text == "Phạt")
                {
                    dgvLoan.Sort(dgvLoan.Columns[13], ListSortDirection.Descending);
                }
            }
        }

        private void btnComfirmReturned_Click(object sender, EventArgs e)
        {
            if (txbStatus.Text == "Đã Trả")
            {
                MessageBox.Show("Mã Mượn " + txbLoanID.Text + " Đã Được Trả Trước Đó Rồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (currentLoan != null)
                    {
                        DialogResult dr = MessageBox.Show("Xác Nhận Trả Sách? " + currentLoan.LoanID, "Xác Nhận Trả", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            UpdateLoan();
                            btnSearch_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi " + ex.Message.ToString(), " Có lỗi");
                }
            }
            txbAddress.Clear();
            txbAmountOfFine.Clear();
            txbBookName.Clear();
            txbLoanID.Clear();
            txbPhone.Clear();
            txbSearch.Clear();
            txbStatus.Clear();
            txbUsername.Clear();
            numericAmount.Value = 0;
            dtpBorrowedDate.Value = DateTime.Now;
            dtpOverdue.Value = DateTime.Now;
            dtpReturnedDate.Value = DateTime.Now;
        }

        private void UpdateLoan()
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                string strCommand = "UpdateLoan";
                sqlConnection.Open();
                SqlCommand myCommand = new SqlCommand(strCommand, sqlConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@LoanID", currentLoan.LoanID);
                myCommand.Parameters.AddWithValue("@AmountOfFine", Convert.ToInt32(txbAmountOfFine.Text));
                int row_affected = myCommand.ExecuteNonQuery();
                if (row_affected > 0)
                {
                    MessageBox.Show("Mã Mượn " + currentLoan.LoanID.ToString() + " Đã được Trả!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), " Có lỗi");
            }
            
        }

        private void issuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ErrorBookList errorBookList = new ErrorBookList();
            errorBookList.Show();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewBorrow viewBorrow = new FormViewBorrow();
            viewBorrow.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbAddress.Clear();
            txbAmountOfFine.Clear();
            txbBookName.Clear();
            txbLoanID.Clear();
            txbPhone.Clear();
            txbSearch.Clear();
            txbStatus.Clear();
            txbUsername.Clear();
            numericAmount.Value = 0;
            dtpBorrowedDate.Value = DateTime.Now;
            dtpOverdue.Value = DateTime.Now;
            dtpReturnedDate.Value = DateTime.Now;
        }
    }
}
