using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DTO
{
    public class Reporting
    {
        public Reporting() { }

        private int reportID;
        private int userID;
        private int bookID;
        private string issueDecriptions;
        private string bookName;
        private string status;

        public int UserID { get => userID; set => userID = value; }
        public int BookID { get => bookID; set => bookID = value; }
        public string IssueDecriptions { get => issueDecriptions; set => issueDecriptions = value; }
        public int ReportID { get => reportID; set => reportID = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string Status { get => status; set => status = value; }
    }
}
