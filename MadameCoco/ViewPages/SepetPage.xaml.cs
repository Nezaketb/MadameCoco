using MadameCoco.ViewModel;
using System;
using MadameCoco.Models;
using MadameCoco.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;

namespace MadameCoco.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SepetPage : ContentPage
    {
        public SepetPage()
        {
            InitializeComponent();
        }

        private async void Bckbtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ShopCartViewModel scv = new ShopCartViewModel();
            MyListView.ItemsSource = scv.CartItems;
        }
        private void SepetSil(object sender, EventArgs e)
        {
            CartItemService cis = new CartItemService();
            cis.RemoveItemsFromCart();
            ShopCartViewModel scv = new ShopCartViewModel();
            scv.CartItems.Clear();
            Navigation.PushAsync(new SepetPage());
        }

        private async void HemenAl(object sender, EventArgs e)
        {
             await Navigation.PushModalAsync(new Odeme());
        }
    }
    }
