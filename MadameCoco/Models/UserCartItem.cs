using System;
using System.Collections.Generic;
using System.Text;

namespace MadameCoco.Models
{
    public class UserCartItem
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}
