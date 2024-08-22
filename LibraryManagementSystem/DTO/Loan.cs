using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DTO
{
    public class Loan
    {
        public Loan() { }

        private int loanID;
        private int borrowID;
        private DateTime confirmDate;
        private DateTime overdue;
        private DateTime returnedDate;
        private int amountOfFine;
        private string status;

        public int LoanID { get => loanID; set => loanID = value; }
        public int BorrowID { get => borrowID; set => borrowID = value; }
        public DateTime ConfirmDate { get => confirmDate; set => confirmDate = value; }
        public DateTime Overdue { get => overdue; set => overdue = value; }
        public DateTime ReturnedDate { get => returnedDate; set => returnedDate = value; }
        public int AmountOfFine { get => amountOfFine; set => amountOfFine = value; }
        public string Status { get => status; set => status = value; }
    }
}
