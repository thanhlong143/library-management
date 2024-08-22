using LibraryManagementSystem.DTO;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ErrorBookList : Form
    {
        Reporting currentReport;
        /*public*/ Books currentBook;

        public ErrorBookList()
        {
            InitializeComponent();
        }

        private void dgvBookError_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvBookError.Rows[e.RowIndex];
                GetCurrentRow(dr);
                GetCurrentEror();
                GetCurrentBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBookError_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvBookError.Rows[e.RowIndex];
            GetCurrentRow(dr);
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            TextSearch();
        }

        private void GetCurrentRow(DataGridViewRow dr)
        {
            if (dr != null)
            {
                try
                {
                    currentReport = new Reporting();
                    currentReport.ReportID = int.Parse(dr.Cells["Mã Báo Cáo"].Value?.ToString());
                    currentReport.UserID = int.Parse(dr.Cells["Mã Sinh Viên"].Value?.ToString());
                    currentReport.BookID = int.Parse(dr.Cells["Mã Sách"].Value?.ToString());
                    currentReport.BookName = dr.Cells["Tên Sách"].Value?.ToString();
                    currentReport.IssueDecriptions = dr.Cells["Mô Tả Lỗi"].Value?.ToString();
                    currentReport.Status = dr.Cells["Trạng Thái"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetCurrentEror()
        {
            try
            {
                txbBookID.Text = currentReport.BookID.ToString();
                txbStatus.Text = currentReport.Status?.ToString();
                txbError.Text = currentReport.IssueDecriptions?.ToString();
                if (txbStatus.Text == "Đã Sửa")
                {
                    btnFix.Enabled = false;
                }
                else
                {
                    btnFix.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextSearch()
        {
            try
            {
                string strSearch = "'%" + txbSearch.Text + "%'";
                string strSelectAll = "SELECT Reporting.ReportID as N'Mã Báo Cáo', Reporting.UserID as N'Mã Sinh Viên', Reporting.BookID as N'Mã Sách', Books.BookName as N'Tên Sách',\r\n\t\t   Reporting.IssueDecriptions as N'Mô Tả Lỗi', Reporting.status as N'Trạng Thái'\r\n\tFROM Reporting INNER JOIN\r\n    Books ON Reporting.BookID = Books.BookID INNER JOIN\r\n    Users ON Reporting.UserID = Users.UserID";
                string strSelect = strSelectAll + " Where IssueDecriptions like N" + strSearch + " OR Status = N" + strSearch;

                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand sqlCommand;
                SqlDataAdapter da;
                DataSet ds;
                if (!string.IsNullOrWhiteSpace(txbSearch.Text))
                {
                    Search(strSelect, out sqlCommand, out da, out ds);
                }
                else if (string.IsNullOrWhiteSpace(txbSearch.Text))
                {
                    Search(strSelectAll, out sqlCommand, out da, out ds);
                }

                sqlCommand = new SqlCommand(strSelectAll, sqlConnection);
                da = new SqlDataAdapter(sqlCommand);
                ds = new DataSet();
                da.Fill(ds, "Reporting");
                ds.WriteXml("Reporting.xml");
                sqlConnection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();

            try
            {
                string strSelectAll = "SELECT Reporting.ReportID as N'Mã Báo Cáo', Reporting.UserID as N'Mã Sinh Viên', Reporting.BookID as N'Mã Sách', Books.BookName as N'Tên Sách',\r\n\t\t   Reporting.IssueDecriptions as N'Mô Tả Lỗi', Reporting.status as N'Trạng Thái'\r\n\tFROM Reporting INNER JOIN\r\n    Books ON Reporting.BookID = Books.BookID INNER JOIN\r\n    Users ON Reporting.UserID = Users.UserID";

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
                da.Fill(ds, "Reporting");
                ds.WriteXml("Reporting.xml");
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
            da.Fill(ds, "Reporting");
            dgvBookError.DataSource = ds;
            dgvBookError.DataMember = "Reporting";
            sqlConnection.Close();
        }

        void LoadError()
        {
            try
            {
                string query = "Select * from V_Report";
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "V_Report");
                dgvBookError.DataSource = ds;
                dgvBookError.DataMember = "V_Report";
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void ErrorBookList_Load(object sender, EventArgs e)
        {
            LoadError();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook(false);
            addBook.currentBook = new Books();
            addBook.currentReport = new Reporting();
            addBook.currentBook = currentBook;
            addBook.currentReport = currentReport;
            addBook.ShowDialog();
            LoadError();
            txbBookID.Clear();
            txbError.Clear();
            txbStatus.Clear();
            if (addBook.currentReport.ReportID == 0)
            {
                btnFix.Enabled = false;
            }
        }

        private void GetCurrentBook()
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from Books where BookID = " + currentReport.BookID, sqlConnection);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    currentBook = new Books();
                    currentBook.BookID = currentReport.BookID;
                    currentBook.BookName = dr.GetValue(1).ToString();
                    currentBook.ShelfID = Convert.ToInt32(dr.GetValue(2).ToString());
                    currentBook.FloorID = Convert.ToInt32(dr.GetValue(3).ToString());
                    currentBook.AuthorName = dr.GetValue(4).ToString();
                    currentBook.CategoryName = dr.GetValue(5).ToString();
                    currentBook.PublicationDate = dr.GetDateTime(6);
                    currentBook.Descriptions = dr.GetValue(7).ToString();
                    currentBook.Quantity = Convert.ToInt32(dr.GetValue(8).ToString());
                    currentBook.Image = dr.GetValue(9).ToString();
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        /*private void DeleteReport()
        {
            try
            {
                string strCommand = "DeleteIssue";
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand myCommand = new SqlCommand(strCommand, sqlConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@ReportID", currentReporting.ReportID);
                int row_affected = myCommand.ExecuteNonQuery();
                if (row_affected > 0)
                {
                    MessageBox.Show(currentReporting.ReportID.ToString() + " Đã được xóa!");
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }*/

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn Đóng Form?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cbSort_TextChanged(object sender, EventArgs e)
        {
            if (cbAZ.Text == "A - Z")
            {
                if (cbSort.Text == "Tên Sách")
                {
                    dgvBookError.Sort(dgvBookError.Columns[3], ListSortDirection.Ascending);
                }
                else if (cbSort.Text == "Trạng Thái")
                {
                    dgvBookError.Sort(dgvBookError.Columns[5], ListSortDirection.Ascending);
                }
            }
            else if (cbAZ.Text == "Z - A")
            {
                if (cbSort.Text == "Tên Sách")
                {
                    dgvBookError.Sort(dgvBookError.Columns[3], ListSortDirection.Descending);
                }
                else if (cbSort.Text == "Trạng Thái")
                {
                    dgvBookError.Sort(dgvBookError.Columns[5], ListSortDirection.Descending);
                }
            }
        }

        private void cbAZ_TextChanged(object sender, EventArgs e)
        {
            cbSort_TextChanged(sender, e);
        }
    }
}
