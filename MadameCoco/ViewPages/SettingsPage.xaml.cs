using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MadameCoco.Helpers;

namespace MadameCoco.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void ButtonCart_Clicked(object sender, EventArgs e)
        {
            var cct = new CreateCartTable();
            if (cct.CreateTable())
                DisplayAlert("Success", "Cart Table Created", "Ok");
            else
                DisplayAlert("Error", "Error while creating table", "Ok");
        }

        //private void ButtonCart_Clicked(object sender, EventArgs e)
        //{
        //  var cct = new CreateCartTable();
        //if (cct.CreateTable())
        //  DisplayAlert("SUCCES", "Cart Table Created", "OK");
        //else
        //    DisplayAlert("ERROR", "Error while creating table", "OK");

        //  }


    }
}