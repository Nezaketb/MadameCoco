using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using MadameCoco.ViewPages;

namespace MadameCoco.Tables
{
    public class LoginViewModel:BaseViewModel
    {
        public string _Usermail;
        public string Email
        {
            set
            {
                this._Usermail = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Usermail;
            }
        }
        public string _Password;
        public string  Password

        {
            set
            {
                this._Password = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Password;
            }
        }

        public string _Name;
        public string Name

        {
            set
            {
                this._Name = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Name;
            }
        }

        public string _Surname;
        public string Surname

        {
            set
            {
                this._Surname = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Surname;
            }
        }

        public bool _IsBusy;
        public bool IsBusy

        {
            set
            {
                this._IsBusy = value;
                OnPropertyChanged();
            }
            get
            {
                return this._IsBusy;
            }
        }

        public bool _Result;
        public bool Result

        {
            set
            {
                this._Result = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Result;
            }
        }

        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }



        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());

        }
        private async Task LoginCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserServices();
                Result = await userService.LoginUser(Email, Password);
                if (Result)
                {
                    Preferences.Set("Email", Email);
                    await Shell.Current.GoToAsync("//HomePage");
                }
                else
                    await Application.Current.MainPage.DisplayAlert("HATA", "GEÇERSİZ MAİL VEYA ŞİFRE", "OK");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("ERROR", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task RegisterCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserServices();
                Result = await userService.RegisterUser(Email,Password,Name,Surname);
                if(Result)
                {
                    await Application.Current.MainPage.DisplayAlert("BAŞARILI", "KAYIT YAPILDI", "TAMAM");
                }
                else
                    await Application.Current.MainPage.DisplayAlert("HATALI", "KAYIT YAPILAMADI", "TAMAM");

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("ERROR", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}
