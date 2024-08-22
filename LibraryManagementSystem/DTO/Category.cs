using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DTO
{
    internal class Category
    {
        public Category() { }
        private string name;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
