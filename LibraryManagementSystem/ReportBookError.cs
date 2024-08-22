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
    public partial class ReportBookError : Form
    {
        //public Reporting currentReport;
        UserDashBoard userDashBoard;

        public ReportBookError(UserDashBoard userDashBoard)
        {
            this.userDashBoard = userDashBoard;
            InitializeComponent();
        }

        public ReportBookError()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendReport();
        }

        private void SendReport()
        {
            if (string.IsNullOrWhiteSpace(txbUserID.Text) || string.IsNullOrWhiteSpace(txbBookID.Text) || string.IsNullOrWhiteSpace(txbErrorDescription.Text))
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
                    string command = "SendReport";
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@UserID", txbUserID.Text?.ToString());
                    sqlCommand.Parameters.AddWithValue("@BookID", txbBookID.Text?.ToString());
                    sqlCommand.Parameters.AddWithValue("@IssueDecriptions", txbErrorDescription.Text?.ToString());
                    sqlCommand.Parameters.Add(new SqlParameter("@ReportID", SqlDbType.Int));
                    sqlCommand.Parameters["@ReportID"].Direction = ParameterDirection.Output;
                    int row_affected = sqlCommand.ExecuteNonQuery();
                    if (row_affected > 0)
                    {
                        MessageBox.Show("Đã Gửi Báo Cáo " + sqlCommand.Parameters["@ReportID"].Value.ToString());
                    }
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi" + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int userID;

        public int UserID { get => userID; set => userID = value; }

        private void ReportBookError_Load(object sender, EventArgs e)
        {
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
                    txbUserID.Text = dr.GetValue(0).ToString();
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex.Message.ToString(), "Có lỗi");
            }

            txbBookID.Text = userDashBoard.txbBookID.Text;
            txbErrorDescription.Text = "";
            txbBookID.Enabled = false;
            txbUserID.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ không được lưu!", "Bạn chắc chắn muốn thoát?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
