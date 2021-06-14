using MadameCoco.Data;
using MadameCoco.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using MadameCoco.Tables;

namespace MadameCoco.Services
{
    public class CartItemService
    {
        public void RemoveItemsFromCart()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            cn.DeleteAll<CartItem>();
            cn.Commit();
            cn.Close();
        }
    }
}
