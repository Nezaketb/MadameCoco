using System;

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

        private async void Backkayıtbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShellPage());
        }
    }
}