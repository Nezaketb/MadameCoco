using MadameCoco.Veri;
using System;
using System.Collections.Generic;
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
                new Urunler {Urun="Roxane Yüz Havlusu - Beyaz - 50x80 cm", Fıyat="19,59" ,Resim="roxanehavlu.jpeg"},
                new Urunler {Urun="Verney Kroşeli El Havlusu - Beyaz - 30x46 cm", Fıyat="17,49" ,Resim="verneyhavlu.jpeg"}
            };
            lst2.ItemsSource = banyoUruns;
            
        }

        private async void Back4_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SepetPage());
        }
    }
}