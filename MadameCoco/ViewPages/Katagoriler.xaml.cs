using MadameCoco.Models;
using MadameCoco.ViewModel;
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
    public partial class Katagoriler : ContentPage
    {
        public Katagoriler()
        {
            InitializeComponent();
        }

        private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem != null)
            {
                Catagory catgo = new Catagory();
                catgo = e.SelectedItem as Catagory;
                if (catgo.CatagoryName == "Banyo")
                {
                    CatagoryViewModel ctg = new CatagoryViewModel();
                    ctg.SubCats(1);
                    MyListView.ItemsSource = ctg.Catagory;
                    OnPropertyChanged();
                }
                else if (catgo.CatagoryName == "Mutfak")
                {
                    CatagoryViewModel ctg = new CatagoryViewModel();
                    ctg.SubCats(2);
                    MyListView.ItemsSource = ctg.Catagory;
                    OnPropertyChanged();
                }
                else if (catgo.CatagoryName == "Yatak")
                {
                    CatagoryViewModel ctg = new CatagoryViewModel();
                    ctg.SubCats(3);
                    MyListView.ItemsSource = ctg.Catagory;
                    OnPropertyChanged();
                }
                //////////
               
                else if (catgo.CatagoryName == "Banyo Aksesuarları")
                {
                    Navigation.PushAsync(new ProductListPage(1,1));
                }
                else if (catgo.CatagoryName == "Havlu")
                {
                    Navigation.PushAsync(new ProductListPage(1,2));
                }
                else if (catgo.CatagoryName == "Banyo Yer Aksesuarları")
                {
                    Navigation.PushAsync(new ProductListPage(1,3));
                }
                else if (catgo.CatagoryName == "Pişirme")
                {
                    Navigation.PushAsync(new ProductListPage(2,1));
                }
                else if (catgo.CatagoryName == "Saklama")
                {
                    Navigation.PushAsync(new ProductListPage(2,2));
                }
                else if (catgo.CatagoryName == "MutfakTekstili")
                {
                    Navigation.PushAsync(new ProductListPage(2,3));
                }
                else if (catgo.CatagoryName == "Nevresim")
                {
                    Navigation.PushAsync(new ProductListPage(3,1));
                }
                else if (catgo.CatagoryName == "Alez-Hurç")
                {
                    Navigation.PushAsync(new ProductListPage(3, 2));
                }
                else if (catgo.CatagoryName == "Pike")
                {
                    Navigation.PushAsync(new ProductListPage(3,3));
                }
            }
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();
            CatagoryViewModel ctg = new CatagoryViewModel();
            MyListView.ItemsSource = ctg.Catagory;
        }
    }
}