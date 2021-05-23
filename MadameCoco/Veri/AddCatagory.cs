using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using MadameCoco.Veri;
using Xamarin.Forms;

namespace MadameCoco.Veri
{
    class AddCatagory
    {
        public List<Catagory> Catagories { get; set; }
        FirebaseClient client;
        public AddCatagory()
        {
            client = new FirebaseClient("https://tradingapp-d9029-default-rtdb.firebaseio.com/");
            Catagories = new List<Catagory>
            {
                new Catagory()
                {
                    CatagoryName="Banyo"
                },
                new Catagory()
                {
                   CatagoryName="Mutfak"
                },
                new Catagory()
                {
                    CatagoryName="Yatak"
                }
            };
        }

        public async Task AddCatagoriesAsync()
        {
            try
            {
                foreach(var catagory in Catagories)
                {
                    await client.Child("Catagories").PostAsync(new Catagory()
                    {
                        CatagoryName = catagory.CatagoryName
                    }

                        );
                }
            }
            catch(Exception ex)
            {
                
                await Application.Current.MainPage.DisplayAlert("ERROR", ex.Message, "OK");
               
            }
        }
    }
}
