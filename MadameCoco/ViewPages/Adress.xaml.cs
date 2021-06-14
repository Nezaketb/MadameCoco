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
    public partial class Adress : ContentPage
    {
        public Adress()
        {
            InitializeComponent();
        }

        private async void BackOdeme_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SepetPage());

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Odeme());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Odeme());

        }
    }
}