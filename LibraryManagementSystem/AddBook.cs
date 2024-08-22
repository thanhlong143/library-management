using LibraryManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class AddBook : Form
    {
        public bool isAddNew = false;
        public Books currentBook;
        public Reporting currentReport;
        private string imageName = "book1.jpg";
        private string currentImage;

        public string ImageName { get => imageName; set => imageName = value; }
        public string CurrentImage { get => currentImage; set => currentImage = value; }

        public AddBook()
        {
            InitializeComponent();
        }

        public AddBook(bool isAddNew)
        {
            this.isAddNew = isAddNew;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAddNew)
            {
                AddNewBook();
            }
            else
            {
                UpdateBook();
            }
        }

        private void GetCurrentImage()
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from Books where BookID = " + txbBookID.Text, sqlConnection);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    CurrentImage = dr.GetValue(9).ToString();
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void AddNewBook()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbBookName.Text) || string.IsNullOrWhiteSpace(txbBookName.Text) || string.IsNullOrWhiteSpace(cbAuthorName.Text) || string.IsNullOrWhiteSpace(cbCategoryName.Text) || string.IsNullOrWhiteSpace(txbDescriptions.Text) || string.IsNullOrWhiteSpace(cbFloorID.Text) || string.IsNullOrWhiteSpace(cbShelfID.Text) || !int.TryParse(cbShelfID.Text, out int value) || !int.TryParse(cbFloorID.Text, out value) || cbCategoryName.Text == "Chọn Hoặc Thêm Danh Mục" || cbAuthorName.Text == "Chọn Hoặc Thêm Tác Giả")
                {
                    MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Bạn Chắc Chắn Muốn Thêm " + numericQuantity.Value.ToString() + " Sách " + txbBookName.Text + "?", "Thêm Sách?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                        string command = "BookAdd";
                        SqlConnection sqlConnection = new SqlConnection(connectionString);
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@BookName", txbBookName.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@ShelfID", cbShelfID.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@FloorID", cbFloorID.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@AuthorName", cbAuthorName.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@CategoryName", cbCategoryName.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@Date_publication", dtpPublicationDate.Value);
                        sqlCommand.Parameters.AddWithValue("@Descriptions", txbDescriptions.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@Quantity", numericQuantity.Value);
                        sqlCommand.Parameters.AddWithValue("@image", ImageName);
                        sqlCommand.Parameters.Add(new SqlParameter("@BookID", SqlDbType.Int));
                        sqlCommand.Parameters.Add(new SqlParameter("@AuthorID", SqlDbType.Int));
                        sqlCommand.Parameters.Add(new SqlParameter("@CategoryID", SqlDbType.Int));
                        sqlCommand.Parameters["@BookID"].Direction = ParameterDirection.Output;
                        sqlCommand.Parameters["@AuthorID"].Direction = ParameterDirection.Output;
                        sqlCommand.Parameters["@CategoryID"].Direction = ParameterDirection.Output;
                        int row_affected = sqlCommand.ExecuteNonQuery();
                        if (row_affected > 0)
                        {
                            MessageBox.Show("Đã Thêm Sách " + sqlCommand.Parameters["@BookName"].Value.ToString() + " với ID là " + sqlCommand.Parameters["@BookID"].Value.ToString());
                        }
                        sqlConnection.Close();

                        DialogResult dr = MessageBox.Show("Bạn có muốn thêm sách khác không?", "Thêm sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes) ResetText();
                        else Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBook()
        {
            GetCurrentImage();

            try
            {
                if (string.IsNullOrWhiteSpace(txbBookName.Text) || string.IsNullOrWhiteSpace(txbBookName.Text) || string.IsNullOrWhiteSpace(cbAuthorName.Text) || string.IsNullOrWhiteSpace(cbCategoryName.Text) || string.IsNullOrWhiteSpace(txbDescriptions.Text) || string.IsNullOrWhiteSpace(cbFloorID.Text) || string.IsNullOrWhiteSpace(cbShelfID.Text) || !int.TryParse(cbShelfID.Text, out int value) || !int.TryParse(cbFloorID.Text, out value))
                {
                    MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Bạn Chắc Chắn Muốn Sửa Sách " + txbBookName.Text + "?", "Sửa Sách?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                        string command = "UpdateBook";
                        SqlConnection sqlConnection = new SqlConnection(connectionString);
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@BookID", txbBookID.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@BookName", txbBookName.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@ShelfID", cbShelfID.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@FloorID", cbFloorID.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@AuthorName", cbAuthorName.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@CategoryName", cbCategoryName.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@Date_publication", dtpPublicationDate.Value);
                        sqlCommand.Parameters.AddWithValue("@Descriptions", txbDescriptions.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@Quantity", numericQuantity.Value);

                        if (ImageName == null || ImageName == "book1.jpg")
                        {
                            sqlCommand.Parameters.AddWithValue("@image", CurrentImage);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@image", ImageName);
                        }
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Đã Sửa Sách " + sqlCommand.Parameters["@BookName"].Value.ToString() + " với ID là " + sqlCommand.Parameters["@BookID"].Value.ToString());
                        sqlConnection.Close();

                        if (currentReport.ReportID != 0)
                        {
                            UpdateReport();
                        }
                        this.Close();

                        currentReport.ReportID = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateReport()
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                string command = "UpdateReport";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ReportID", currentReport.ReportID.ToString());
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            txbBookID.Enabled = false;
            txbBookID.Visible = false;

            if (isAddNew)
            {
                Text = "Thêm Sách";
            }
            else
            {
                Text = "Sửa Sách";
                txbBookID.Visible = true;
                if (currentBook != null)
                {
                    txbBookID.Text = currentBook.BookID.ToString();
                    txbBookName.Text = currentBook.BookName?.ToString();
                    cbShelfID.Text = currentBook.ShelfID.ToString();
                    cbFloorID.Text = currentBook.FloorID.ToString();
                    cbAuthorName.Text = currentBook.AuthorName?.ToString();
                    cbCategoryName.Text = currentBook.CategoryName?.ToString();
                    dtpPublicationDate.Value = currentBook.PublicationDate;
                    txbDescriptions.Text = currentBook.Descriptions?.ToString();
                    numericQuantity.Text = currentBook.Quantity.ToString();
                    pictureBox.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images\\" + currentBook.Image.ToString();
                }
            }

            LoadFloors();
            LoadShelves();
            LoadAuthorName();
            LoadCategoryName();
        }

        private void LoadFloors()
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                string command = "Select FloorID from Floors";
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
                    cbFloorID.Items.Add(row["FloorID"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void LoadShelves()
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                string command = "Select ShelfID from Shelves";
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
                    cbShelfID.Items.Add(row["ShelfID"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void LoadAuthorName()
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
                    cbAuthorName.Items.Add(row["AuthorName"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void LoadCategoryName()
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
                    cbCategoryName.Items.Add(row["CategoryName"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ không được lưu!", "Bạn chắc chắn muốn thoát?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceImage = dialog.FileName.ToString();
                    string imagesFolder = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images\\";

                    ImageName = Path.GetFileName(sourceImage);

                    try
                    {
                        File.Copy(dialog.FileName.ToString(), Path.Combine(imagesFolder, ImageName));
                    }
                    catch (IOException copyError)
                    {
                        Console.WriteLine(copyError.Message);
                    }

                    pictureBox.ImageLocation = imagesFolder + ImageName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có Lỗi " + ex.ToString(), "Có Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
