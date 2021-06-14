using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using MadameCoco.Tables;
using MadameCoco.Helpers;


namespace MadameCoco.Models
{
    [Table("CartItem")]
    public class CartItem
    {
        [AutoIncrement,PrimaryKey]
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string ProductImage { get; set; }
    }
}
