using MadameCoco.Tables;
using SQLite;
using System;
using System.IO;
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

        private void Btnback2_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//HomePage");

        }

        private async void Btnuye_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new UyePage());
        }

        private void Btngiris_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<RegUserTable>().Where(u => u.Email.Equals(MailEntry.Text) && u.Password.Equals(SifreEntry.Text)).FirstOrDefault();
            if (myquery != null)
            {
                Shell.Current.GoToAsync("//HomePage");
            }
            else
            {
                Hatalıgiris.Text = "E-posta veya şifre hatalı";
            }



        }
    }
}