
using MadameCoco.Tables;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MadameCoco.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UyePage : ContentPage
    {
        public UyePage()
        {
            InitializeComponent();
        }

        private async void Btnbackgir_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new KayıtPage());
        }



        private async void Backkayıt_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new KayıtPage());
        }

       
    }
}