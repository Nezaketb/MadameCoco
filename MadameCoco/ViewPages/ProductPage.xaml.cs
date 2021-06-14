using MadameCoco.Data;
using MadameCoco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MadameCoco.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private async void HemenAl_Clicked(object sender, EventArgs e)
        {
            AddToCart();
            await Navigation.PushAsync(new SepetPage
            {
                BindingContext = sender as Product
            });
        }

        private void SepeteEkle_Clicked(object sender, EventArgs e)
        {
            AddToCart();
            Navigation.PushAsync(new SepetPage());
        }
        async void Product_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SepetPage
            {
                BindingContext = sender as Product
            });
        }

        private void AddToCart()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            try
            {
                CartItem ci = new CartItem()
                {   
                    ProductName = urunAd.Text,
                    Price = Convert.ToInt32(urunFiyat.Text),
                    ProductImage = urunImage.ToString()
                };
                var item = cn.Table<CartItem>().ToList()
                    .FirstOrDefault();
                if (item == null)
                    cn.Insert(ci);
                else
                {
                    cn.Update(item);
                }
                cn.Commit();
                cn.Close();
                Application.Current.MainPage.DisplayAlert("Cart", "Selected Item Added to Cart", "OK");
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}