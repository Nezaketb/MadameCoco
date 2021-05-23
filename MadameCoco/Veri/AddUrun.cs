using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MadameCoco.Veri;
using Xamarin.Forms;



namespace MadameCoco.Veri
{
    class AddUrun
    {
        FirebaseClient client;
        public List<Urunler> Urunlers { get; set; }

        public AddUrun()
        {
            client = new FirebaseClient("https://tradingapp-d9029-default-rtdb.firebaseio.com/");
            Urunlers = new List<Urunler>()
            {
                new Urunler
                {
                    Resim="kingsizeyorgan.jpg",
                    Urun="Aloe Vera King Size Yorgan - Beyaz / Toprak",
                    Fıyat="239,99",
                    Renk="Beyaz",
                    CatagoryName="Yatak"
                },
                new Urunler
                {
                       Resim="audreywellsoft.jpg",
                       Urun="Audrey Wellsoft Baskılı Çift Kişilik Battaniye - Turuncu",
                       Fıyat="79,99",
                       Renk="Turuncu",
                       CatagoryName="Yatak"
                 },
                 new Urunler 
                 {
                     Urun="Majori Silinebilir Masa Örtüsü - Indigo - 140 cm", 
                     Fıyat="24,99" ,
                     Resim="majorimasa.jpeg",
                     Renk="Mavi",
                     CatagoryName="Mutfak"
                 },
                new Urunler 
                {
                    Urun="Terre Seramik Tencere - 11 cm", 
                    Fıyat="24,99" ,
                    Resim="terreseramiktencere.jpeg",
                    Renk="Kahverengi",
                    CatagoryName="Mutfak"
                },
                new Urunler 
                {
                    Urun="Roxane Yüz Havlusu - Beyaz - 50x80 cm", 
                    Fıyat="19,59" ,
                    Resim="roxanehavlu.jpeg",
                    Renk="Beyaz",
                    CatagoryName="Banyo"
                },
                new Urunler 
                {
                    Urun="Verney Kroşeli El Havlusu - Beyaz - 30x46 cm", 
                    Fıyat="17,49" ,Resim="verneyhavlu.jpeg",
                    Renk="Ekru",
                    CatagoryName="Banyo"

                }

            };
        
        }
        public async Task AddUrunAsync()
        {
            try
            {
                foreach (var Urunlers in Urunlers )
                {
                    await client.Child("Urunler").PostAsync(new Urunler()
                    {
                        Fıyat = Urunlers.Fıyat,
                        Renk=Urunlers.Renk,
                        Resim=Urunlers.Resim,
                        Urun=Urunlers.Urun,
                        CatagoryName=Urunlers.CatagoryName
                        

                    }

                        ) ;
                }
            }
            catch (Exception ex)
            {
                 
                 await Application.Current.MainPage.DisplayAlert("ERROR", ex.Message, "OK");
            }
        }
        

    }
}
