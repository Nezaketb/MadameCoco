using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MadameCoco.ViewModel;
using MadameCoco.Models;
using System.Linq;

namespace MadameCoco.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Urun : ContentPage
    {

        public Urun()
        {
            InitializeComponent();
            BindingContext = new ProductListViewModel();
        }

        private async  void Back4_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _containter = BindingContext as ProductListViewModel;
            PickList.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                PickList.ItemsSource = _containter.Products;
            else
                PickList.ItemsSource = _containter.Products.Where(i => i.Renk.Contains(e.NewTextValue));

            PickList.EndRefresh();

        }
    }
}