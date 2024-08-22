
using LibraryManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystem
{
    public partial class ViewBooks : Form
    {
        Books currentBook;
        Reporting currentReport;

        public ViewBooks()
        {
            InitializeComponent();
        }

        public void TextSearch()
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
                txbDescriptions.Text = currentBook.Descriptions?.ToString();
                numericQuantity.Text = currentBook.Quantity.ToString();
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
                    currentBook.Image = dr.Cells["Ảnh"].Value?.ToString();
                    Text = "Mã Sách " + currentBook.BookID.ToString();
                    currentReport = new Reporting();
                    currentReport.ReportID = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dvgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ không được lưu! ", "Bạn chắc chắn muốn thoát?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook(false);
            addBook.currentBook = new Books();
            addBook.currentBook = currentBook;
            addBook.currentReport = new Reporting();
            addBook.currentReport = currentReport;
            addBook.ShowDialog();
            btnLoadAll_Click(sender, e);
        }

        private void dvgBooks_RowEnter(object sender, DataGridViewCellEventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentBook != null)
                {
                    DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa sách " + currentBook.BookName + " này không?" , "Xóa Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DeleteBook();
                        btnLoadAll_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void DeleteBook()
        {
            try
            {
                string strCommand = "DeleteBook";
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand myCommand = new SqlCommand(strCommand, sqlConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@BookID", currentBook.BookID);
                int row_affected = myCommand.ExecuteNonQuery();
                if (row_affected > 0)
                {
                    MessageBox.Show("Sách " + currentBook.BookName.ToString() + " Đã được xóa!");
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            //TextSearch();
            LoadAuthor();
            LoadCategory();
            btnLoadAll_Click(sender, e);
            dtpPublicationDateFrom.Enabled = false;
            dtpPublicationDateTo.Enabled = false;
        }

        private void LoadAuthor()
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

        private void LoadCategory()
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

        private void cbAuthorFilter_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cbCategoryFilter_TextChanged(object sender, EventArgs e)
        {
            Filter();
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
    }
}
