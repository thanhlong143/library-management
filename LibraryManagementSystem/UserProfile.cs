using LibraryManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class UserProfile : Form
    {
        private bool isAddNew = false;
        private int isEdit = 0;
        public Account currentUser;
        
        UserDashBoard userDashBoard;

        public UserProfile(UserDashBoard userDashBoard)
        {
            this.userDashBoard = userDashBoard;
            InitializeComponent();
        }

        public UserProfile()
        {
            InitializeComponent();
        }

        public UserProfile(bool isAddNew)
        {
            this.isAddNew = isAddNew;
            InitializeComponent();
        }

        public UserProfile(int isEdit)
        {
            this.isEdit = isEdit;
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAddNew)
            {
                AddNewUser();
                DialogResult dr = MessageBox.Show("Bạn có muốn thêm User khác không?", "Thêm User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes) ResetText();
                else Close();
            }
            else
            {
                UpdateUser();
                Close();
            }
        }

        public static bool IsValidPhone(string value)
        {
            string pattern = @"^-*[0-9,\.?\-?\(?\)?\ ]+$";
            return Regex.IsMatch(value, pattern);
        }

        public static bool IsValidString(string value)
        {
            string pattern = @"^[0-9]{10,10}$";
            return Regex.IsMatch(value, pattern);
        }

        private void AddNewUser()
        {
            if (!IsValidPhone(txbPhone.Text) || !IsValidString(txbPhone.Text))
            {
                MessageBox.Show("Hãy Nhập Đúng Số Điện Thoại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPhone.Focus();
            }
            else
            {
                if (txbUsername.Text != "" || txbAddress.Text != "" || txbPassword.Text != "")
                {
                    try
                    {
                        string command = "USP_Register";
                        string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                        SqlConnection sqlConnection = new SqlConnection(strConnectString);
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@Username", txbUsername.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@Address", txbAddress.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@PhoneNumber", txbPhone.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@Password", txbPassword.Text?.ToString());
                        sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int));
                        sqlCommand.Parameters["@UserID"].Direction = ParameterDirection.Output;
                        int row_affected = sqlCommand.ExecuteNonQuery();
                        if (row_affected > 0)
                        {
                            MessageBox.Show("User đã được thêm với ID là " + sqlCommand.Parameters["@UserID"].Value.ToString());
                        }
                        sqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi" + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateUser()
        {
            if (!IsValidPhone(txbPhone.Text) || !IsValidString(txbPhone.Text))
            {
                MessageBox.Show("Hãy Nhập Đúng Số Điện Thoại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPhone.Focus();
            }
            else
            {
                if (txbUsername.Text != "" || txbAddress.Text != "" || txbPassword.Text != "")
                {
                    try
                    {
                        string strCommand = "USP_UpdateUser";
                        string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                        SqlConnection sqlConnection = new SqlConnection(strConnectString);
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(strCommand, sqlConnection);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UserID", txbUserID.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@Username", txbUsername.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@Address", txbAddress.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@PhoneNumber", txbPhone.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@Password", txbPassword.Text?.ToString());
                        sqlCommand.Parameters.AddWithValue("@OrderDetails", txbOrderDetails.Text?.ToString());
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Đã sửa " + sqlCommand.Parameters["@UserID"].Value?.ToString());
                        sqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đóng form không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            txbUserID.Enabled = false;

            if (isAddNew == true)
            {
                txbUserID.Visible = false;
                lbUserID.Visible = false;
                Text = "Thêm User";
            }
            else if (isEdit == 1)
            {
                txbUserID.Visible = true;
                lbUserID.Visible = true;
                Text = "Sửa User";
                if (currentUser != null)
                {
                    txbPhone.Enabled = true;
                    txbOrderDetails.Enabled = false;
                    txbUserID.Text = currentUser.UserID.ToString();
                    txbUsername.Text = currentUser.Username?.ToString();
                    txbAddress.Text = currentUser.Address?.ToString();
                    txbPhone.Text = currentUser.PhoneNumber?.ToString();
                    txbOrderDetails.Text = currentUser.OrderDetails?.ToString();
                    txbPassword.Text = currentUser.Password?.ToString();
                }
            }
            else
            {
                Text = "Sửa Profile";
                try
                {
                    string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                    SqlConnection sqlConnection = new SqlConnection(strConnectString);
                    sqlConnection.Open();
                    string data = userDashBoard.PhoneNumber;
                    SqlCommand sqlCommand = new SqlCommand("Select * from Users where PhoneNumber = " + data, sqlConnection);
                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        txbPhone.Enabled = false;
                        txbUserID.Text = dr.GetValue(0).ToString();
                        txbUsername.Text = dr.GetValue(1).ToString();
                        txbAddress.Text = dr.GetValue(2).ToString();
                        txbPhone.Text = userDashBoard.PhoneNumber.ToString();
                        txbOrderDetails.Text = dr.GetValue(4).ToString();
                        txbPassword.Text = dr.GetValue(5).ToString();
                    }
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi" + ex.Message.ToString(), "Có lỗi");
                }
            }
        }
    }
}
