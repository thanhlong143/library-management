using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class FormLogin : Form
    {
        //public bool isLoggedin;
        DashBoard dashBoard;
        UserDashBoard userDashBoard;

        public FormLogin(DashBoard dashBoard)
        {
            this.dashBoard = dashBoard;
            InitializeComponent();
        }

        public FormLogin(UserDashBoard dashBoard)
        {
            this.userDashBoard = dashBoard;
            InitializeComponent();
        }

        public FormLogin()
        {
            InitializeComponent();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsValidPhone(txbPhone.Text) || !IsValidString(txbPhone.Text))
            {
                MessageBox.Show("Hãy Nhập Đúng Số Điện Thoại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPhone.Focus();
            }
            else
            {
                try
                {
                    string strLogin = "Select * from Users Where PhoneNumber = N'" + txbPhone.Text + "' AND Password = N'" + txbPassword.Text + "' AND type = 0";
                    string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                    SqlConnection sqlConnection = new SqlConnection(strConnectString);
                    sqlConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(strLogin, strConnectString);

                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        userDashBoard = new UserDashBoard(this);
                        this.Hide();
                        userDashBoard.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai Thông tin đăng nhập", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi" + ex.Message.ToString(), "Có lỗi");
                }
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (!IsValidPhone(txbPhone.Text) || !IsValidString(txbPhone.Text))
            {
                MessageBox.Show("Hãy Nhập Đúng Số Điện Thoại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPhone.Focus();
            }
            else
            {
                try
                {
                    string strLogin = "Select * from Users Where PhoneNumber = N'" + txbPhone.Text + "' AND Password = N'" + txbPassword.Text + "' AND type = 1";
                    string strConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                    SqlConnection sqlConnection = new SqlConnection(strConnectString);
                    sqlConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(strLogin, strConnectString);

                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        dashBoard = new DashBoard(this);
                        this.Hide();
                        dashBoard.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai Thông tin đăng nhập", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi" + ex.Message.ToString(), "Có lỗi");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserProfile register = new UserProfile(true);
            register.Show();
        }
    }
}
