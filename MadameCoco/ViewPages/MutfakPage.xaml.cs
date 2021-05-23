
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
    public partial class MutfakPage : ContentPage
    {
        public MutfakPage()
        {
            InitializeComponent();
            List<Urunler> mutfakUruns = new List<Urunler>
            {
                new Urunler {Urun="Majori Silinebilir Masa Örtüsü - Indigo - 140 cm", Fıyat="24,99" ,Resim="majorimasa.jpeg"},
                new Urunler {Urun="Terre Seramik Tencere - 11 cm", Fıyat="24,99" ,Resim="terreseramiktencere.jpeg"}
            };
            lst3.ItemsSource = mutfakUruns;
        }
      

    

    private async void ImageButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new SepetPage());
        }

        private async void Back5_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.DisplayAlert("Sepete Eklendi", "1 adet ürün sepetinize eklendi.", "Alışverişe Devam Et", "Sepete Git");
        }
    }
}