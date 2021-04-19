
using MadameCoco.Tables;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MadameCoco.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UyePage : ContentPage
    {
        public UyePage()
        {
            InitializeComponent();
        }

        private async void Btnbackgir_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new KayıtPage());
        }



        private async void Backkayıt_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new KayıtPage());
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();
            var item = new RegUserTable()
            {
                Name = EntryAd.Text,
                Surname=EntrySoyad.Text,
                Email=EntryEmail.Text,
                Password=EntrySifre.Text

             };
            

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async ()  =>
            {
                var result = await this.DisplayAlert("Tebrikler","Kayıt olma işlemi başarılı","Anasayfaya git","Geri");
                if(result)
                {
                    await Shell.Current.GoToAsync("//HomePage");
                }
            }
                );
            
        }
    }
}