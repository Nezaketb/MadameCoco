
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MadameCoco.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new SepetPage());
        }
    }
}