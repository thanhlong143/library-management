using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DTO
{
    public class Account
    {
        public Account() { }

        private int userID;
        private string username;
        private string password;
        private string address;
        private string phoneNumber;
        private string orderDetails;
        private int type;

        public int UserID { get => userID; set => userID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string OrderDetails { get => orderDetails; set => orderDetails = value; }
        public int Type { get => type; set => type = value; }
    }
}
