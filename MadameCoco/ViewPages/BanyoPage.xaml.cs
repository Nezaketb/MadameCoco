using DocumentFormat.OpenXml.Spreadsheet;
using MadameCoco.Veri;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace MadameCoco.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BanyoPage : ContentPage
    {
        public BanyoPage()
        {
            InitializeComponent();
           
            List<Urunler> banyoUruns = new List<Urunler>
            {
                new Urunler {Urun="Roxane Yüz Havlusu - Beyaz - 50x80 cm", Fıyat="19,59" ,Resim="roxanehavlu.jpeg",Renk="Beyaz"},
                new Urunler {Urun="Verney Kroşeli El Havlusu - Beyaz - 30x46 cm", Fıyat="17,49" ,Resim="verneyhavlu.jpeg",Renk="Ekru"}
            };

            lst2.ItemsSource = banyoUruns;

        }

       

        private async void Back4_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

      

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //this.DisplayAlert("Sepete Eklendi", "1 adet ürün sepetinize eklendi.", "Alışverişe Devam Et", "Sepete Git");
            await Navigation.PushModalAsync(new SepetPage());
          
            
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SepetPage());

        }
    }
}