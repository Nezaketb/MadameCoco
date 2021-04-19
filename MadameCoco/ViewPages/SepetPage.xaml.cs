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
    public partial class SepetPage : ContentPage
    {
        public SepetPage()
        {
            InitializeComponent();
        }

       

        private async void Anasayfa_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

        private async void Bckbtn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
        }
    }
}