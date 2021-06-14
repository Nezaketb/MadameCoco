using MadameCoco.Data;
using MadameCoco.Models;
using MadameCoco.ViewModel;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MadameCoco.Helpers;


namespace MadameCoco.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductListPage : ContentPage
    {
        public int CatagoryID, SubCategoryID;
       
       
        public ProductListPage(int categoryID, int subCategoryID)
        {
            InitializeComponent();
            CatagoryID = categoryID;
            SubCategoryID = subCategoryID;
        }

        private async void Product_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ProductPage
                {
                    BindingContext = e.SelectedItem as Product
                });
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ProductListViewModel plv = new ProductListViewModel(CatagoryID, SubCategoryID);
            MyListView.ItemsSource = plv.Products;
        }
      
        }
}