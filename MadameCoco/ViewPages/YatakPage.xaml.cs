
using MadameCoco.Veri;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MadameCoco.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YatakPage : ContentPage
    {


        public YatakPage()
        {
            InitializeComponent();
            List<Urunler> yatakUruns = new List<Urunler>
            {
             new Urunler { Resim="kingsizeyorgan.jpg",Urun="Aloe Vera King Size Yorgan - Beyaz / Toprak",Fıyat="239,99" },
             new Urunler {Resim="audreywellsoft.jpg", Urun="Audrey Wellsoft Baskılı Çift Kişilik Battaniye - Turuncu",Fıyat="79,99"}
            };
            lst1.ItemsSource = yatakUruns;

        }

        private async void Back3_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

        private async void ImageButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new SepetPage());
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.DisplayAlert("Sepete Eklendi", "1 adet ürün sepetinize eklendi.", "Alışverişe Devam Et", "Sepete Git");
        }
    }
}