using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MadameCoco.Veri;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MadameCoco.Veri
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

     
        private async void AddCatagories_Clicked(object sender, EventArgs e)
        {
            var acd = new AddCatagory();
            await acd.AddCatagoriesAsync();
        }

        private async void AddUrun_Clicked(object sender, EventArgs e)
        {
            var afd = new AddUrun();
            await afd.AddUrunAsync();
        }
    }
}