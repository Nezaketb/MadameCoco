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
    public partial class Odeme2 : ContentPage
    {
        public Odeme2()
        {
            InitializeComponent();
        }

        private async void  Backbtn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Odeme());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("TEBRİKLER", "SİPARİŞİNİZ ALINDI", "TAMAM");
        }
    }
}