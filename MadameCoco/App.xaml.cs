using MadameCoco.ViewPages;
using Xamarin.Forms;


namespace MadameCoco
{
    public partial class App : Application
    {

       
        public App()
        {
            InitializeComponent();

            MainPage = new ShellPage();
           // MainPage = new NavigationPage(new SettingsPage());
          
        }

       

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
