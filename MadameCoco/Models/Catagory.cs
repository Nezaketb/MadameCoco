using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MadameCoco.Models
{
    public class Catagory
    {
        [PrimaryKey, AutoIncrement] 
        public int CatagoryID { get; set; }
        public string CatagoryName { get; set; }

    }
}
