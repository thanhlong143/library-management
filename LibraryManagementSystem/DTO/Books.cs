using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DTO
{
    public class Books
    {
        public Books() { }

        private int bookID;
        private string bookName;
        private int shelfID;
        private int floorID;
        private string authorName;
        private string categoryName;
        private DateTime publicationDate;
        private string descriptions;
        private int quantity;
        private string image;

        public int BookID { get => bookID; set => bookID = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public DateTime PublicationDate { get => publicationDate; set => publicationDate = value; }
        public string Descriptions { get => descriptions; set => descriptions = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Image { get => image; set => image = value; }
        public int ShelfID { get => shelfID; set => shelfID = value; }
        public int FloorID { get => floorID; set => floorID = value; }
    }
}
