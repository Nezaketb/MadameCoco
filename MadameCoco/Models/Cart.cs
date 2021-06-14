using System;
using System.Collections.Generic;
using System.Text;
using MadameCoco.Tables;
using MadameCoco.Helpers;

namespace MadameCoco.Models
{
    public class Cart
    {
        public string UserName { get; set; }
        public int CartId { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
