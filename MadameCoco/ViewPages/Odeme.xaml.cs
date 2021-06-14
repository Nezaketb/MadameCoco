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
    public partial class Odeme : ContentPage
    {
        public Odeme()
        {
            InitializeComponent();
        }

        private async void Backbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SepetPage());
        }

        private async void BtnKyt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Odeme2());

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Adress());
        }
    }
}