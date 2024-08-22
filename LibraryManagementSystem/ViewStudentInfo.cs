using LibraryManagementSystem.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace LibraryManagementSystem
{
    public partial class ViewStudentInfo : Form
    {
        Account currentUser;

        public ViewStudentInfo()
        {
            InitializeComponent();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            string strSelectAll = "SELECT UserID as N'Mã Sinh Viên', UserName as N'Tên Sinh Viên', Address as N'Địa Chỉ', PhoneNumber as N'Số Điện Thoại', Orderdetails N'Thông Tin Mượn', Password N'Mật Khẩu' FROM Users";
            string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
            SqlConnection sqlConnection = new SqlConnection(strConnectString);
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand(strSelectAll, sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            dgvUsers.DataSource = ds;
            dgvUsers.DataMember = "Users";
            ds.WriteXml("Users.xml");
            sqlConnection.Dispose();
        }

        private void TextSearch()
        {
            try
            {
                string strSearch = txbSearch.Text;
                string strSearchID = txbSearchID.Text;

                string strSelectAll = "SELECT UserID as N'Mã Sinh Viên', UserName as N'Tên Sinh Viên', Address as N'Địa Chỉ', PhoneNumber as N'Số Điện Thoại', Orderdetails as N'Thông Tin Mượn', Password as N'Mật Khẩu' FROM Users";
                
                string strSelectID = strSelectAll + " where UserID = " + strSearchID;
                string strSelect = strSelectAll + " where UserName like N'%" + strSearch + "%' OR PhoneNumber like '%" + strSearch + "%' OR OrderDetails like N'%" + strSearch + "%'";
                string strSelectBoth = strSelectAll + " where UserID = " + strSearchID + " AND (UserName like N'%" + strSearch + "%' OR PhoneNumber like '%" + strSearch + "%' OR OrderDetails like N'%" + strSearch + "%')";


                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand myCommand;
                SqlDataAdapter da;
                DataSet ds;
                if (!string.IsNullOrWhiteSpace(txbSearch.Text) && !string.IsNullOrWhiteSpace(txbSearchID.Text))
                {
                    Search(strSelectBoth, out myCommand, out da, out ds);
                }
                else if (string.IsNullOrWhiteSpace(txbSearch.Text) && string.IsNullOrWhiteSpace(txbSearchID.Text))
                {
                    Search(strSelectAll, out myCommand, out da, out ds);
                }
                else if (!string.IsNullOrWhiteSpace(txbSearch.Text) && string.IsNullOrWhiteSpace(txbSearchID.Text))
                {
                    Search(strSelect, out myCommand, out da, out ds);
                }
                else if (string.IsNullOrWhiteSpace(txbSearch.Text) && !string.IsNullOrWhiteSpace(txbSearchID.Text))
                {
                    Search(strSelectID, out myCommand, out da, out ds);
                }

                myCommand = new SqlCommand(strSelectAll, sqlConnection);
                da = new SqlDataAdapter(myCommand);
                ds = new DataSet();
                da.Fill(ds, "Users");
                ds.WriteXml("Users.xml");
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
            sqlConnection.Open();
            myCommand = new SqlCommand(query, sqlConnection);
            da = new SqlDataAdapter(myCommand);
            ds = new DataSet();
            da.Fill(ds, "Users");
            dgvUsers.DataSource = ds;
            dgvUsers.DataMember = "Users";
            sqlConnection.Close();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvUsers.Rows[e.RowIndex];
                GetCurrentRow(dr);
                GetCurrentUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvUsers.Rows[e.RowIndex];
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
                    currentUser = new Account();
                    currentUser.UserID = int.Parse(dr.Cells["Mã Sinh Viên"].Value?.ToString());
                    currentUser.Username = dr.Cells["Tên Sinh Viên"].Value?.ToString();
                    currentUser.Address = dr.Cells["Địa Chỉ"].Value?.ToString();
                    currentUser.PhoneNumber = dr.Cells["Số Điện Thoại"].Value?.ToString();
                    currentUser.OrderDetails = dr.Cells["Thông Tin Mượn"].Value?.ToString();
                    currentUser.Password = dr.Cells["Mật Khẩu"].Value?.ToString();
                    Text = currentUser.UserID.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetCurrentUser()
        {
            try
            {
                txbUserID.Text = currentUser.UserID.ToString();
                txbUsername.Text = currentUser.Username?.ToString();
                txbAddress.Text = currentUser.Address?.ToString();
                txbPhone.Text = currentUser.PhoneNumber?.ToString();
                txbOrderDetails.Text = currentUser.OrderDetails?.ToString();
                txbPassword.Text = currentUser.Password?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserProfile addBook = new UserProfile(1);
            addBook.currentUser = new Account();
            addBook.currentUser = currentUser;
            addBook.ShowDialog();
            btnLoadAll_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ không được lưu!", "Bạn chắc chắn muốn thoát?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentUser != null)
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa User này không?" + currentUser.UserID, "Xóa User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DeleteUser();
                        btnLoadAll_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void DeleteUser()
        {
            try
            {
                string strCommand = "DeleteUser";
                string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                SqlConnection sqlConnection = new SqlConnection(strConnectString);
                sqlConnection.Open();
                SqlCommand myCommand = new SqlCommand(strCommand, sqlConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@UserID", currentUser.UserID);
                int row_affected = myCommand.ExecuteNonQuery();
                if (row_affected > 0)
                {
                    MessageBox.Show(currentUser.UserID.ToString() + " Đã được xóa!");
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null) 
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void ViewStudentInfo_Load(object sender, EventArgs e)
        {
            btnLoadAll_Click(sender, e);
        }

        private void txbSearchID_TextChanged(object sender, EventArgs e)
        {
            TextSearch();
        }
    }
}
