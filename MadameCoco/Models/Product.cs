using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MadameCoco.Models
{
    public class Product
    {
        [PrimaryKey,AutoIncrement]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        [PrimaryKey]
        public int CatagoryID { get; set; }
        public int SubCategoryID { get; set; }

        public int Price { get; set; }
        public string Renk { get; set; }

    }
}
