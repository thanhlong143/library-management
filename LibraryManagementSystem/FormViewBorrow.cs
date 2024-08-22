using LibraryManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class FormViewBorrow : Form
    {
        Borrow currentBorrow;
        Account currentUser;
        Books currentBook;
        private int currentQuantity;

        public int CurrentQuantity { get => currentQuantity; set => currentQuantity = value; }

        public FormViewBorrow()
        {
            InitializeComponent();
        }

        private void FormViewBorrow_Load(object sender, EventArgs e)
        {
            LoadBorrow();
        }

        void LoadBorrow()
        {
            try
            {
                string query = "Select * from v_Borrow";
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "v_Borrow");
                dgvBorrow.DataSource = ds;
                dgvBorrow.DataMember = "v_Borrow";
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void dgvBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvBorrow.Rows[e.RowIndex];
                GetCurrentRow(dr);
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
            GetCurrentRow(dr);
        }

        private void GetCurrentBorrow()
        {
            try
            {
                txbBorrowID.Text = currentBorrow.BorrowID.ToString();
                txbUserID.Text = currentBorrow.UserID.ToString();
                txbBookID.Text = currentBorrow.BookID.ToString();
                txbAmount.Text = currentBorrow.Amount.ToString();
                txbFloorID.Text = currentBook.FloorID.ToString();
                txbShelfID.Text = currentBook.ShelfID.ToString();
                dtpBorrowDate.Text = currentBorrow.BorrowDate.ToString();
                txbStatus.Text = currentBorrow.Status?.ToString();
                txbQuantity.Text = CurrentQuantity.ToString();
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
                    currentBorrow = new Borrow();
                    currentUser = new Account();
                    currentBook = new Books();

                    currentBorrow.BorrowID = int.Parse(dr.Cells["Mã Mượn"].Value?.ToString());
                    currentBorrow.UserID = int.Parse(dr.Cells["Mã Người Mượn"].Value?.ToString());
                    currentUser.Username = dr.Cells["Tên Người Mượn"].Value?.ToString();
                    currentUser.Address = dr.Cells["Địa Chỉ"].Value?.ToString();
                    currentUser.PhoneNumber = dr.Cells["Số Điện Thoại"].Value?.ToString();
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentQuantity <= 0)
                {
                    MessageBox.Show("Đã Hết Sách Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Convert.ToInt32(txbAmount.Text) > CurrentQuantity)
                {
                    MessageBox.Show("Không Đủ Số Lượng Sách Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (Convert.ToInt32(txbAmount.Text) <= 0)
                    {
                        MessageBox.Show("Hãy Chọn Số Lượng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Xác Nhận Mượn " + txbAmount.Text.ToString() + " Sách " + currentBook.BookName + "?", "Xác Nhận Mượn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            string command = "LoanAdd";
                            string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                            SqlConnection sqlConnection = new SqlConnection(strConnectString);
                            sqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.Parameters.AddWithValue("@BorrowID", txbBorrowID.Text?.ToString());
                            sqlCommand.Parameters.Add(new SqlParameter("@LoanID", SqlDbType.Int));
                            sqlCommand.Parameters["@LoanID"].Direction = ParameterDirection.Output;
                            int row_affected = sqlCommand.ExecuteNonQuery();
                            if (row_affected > 0)
                            {
                                MessageBox.Show("Hóa đơn đã được thêm với ID là " + sqlCommand.Parameters["@LoanID"].Value.ToString());
                            }
                            sqlConnection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadBorrow();
            txbAmount.Clear();
            txbBookID.Clear();
            txbBorrowID.Clear();
            txbFloorID.Clear();
            txbQuantity.Clear();
            txbShelfID.Clear();
            txbStatus.Clear();
            txbUserID.Clear();
        }
    }
}
