using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DTO
{
    public class Borrow
    {
        public Borrow() { }

        private int borrowID;
        private int bookID;
        private int userID;
        private DateTime borrowDate;
        private int amount;
        private string status;

        public int BorrowID { get => borrowID; set => borrowID = value; }
        public int BookID { get => bookID; set => bookID = value; }
        public int UserID { get => userID; set => userID = value; }
        public DateTime BorrowDate { get => borrowDate; set => borrowDate = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Status { get => status; set => status = value; }
    }
}
