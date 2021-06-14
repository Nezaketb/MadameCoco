using MadameCoco.Tables;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MadameCoco.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KayıtPage : ContentPage
    {
        public KayıtPage()
        {
            InitializeComponent();






        }

        private void Btnback2_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//HomePage");

        }

        private async void Btnuye_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new UyePage());
        }

      
    }
}