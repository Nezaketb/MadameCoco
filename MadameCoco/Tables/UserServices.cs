using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database.Query;

namespace MadameCoco.Tables
{
    public class UserServices
    {
        FirebaseClient client;
        public UserServices()
        {
            client = new FirebaseClient("https://tradingapp-d9029-default-rtdb.firebaseio.com/");
        }
        public async Task<bool> IsUserExists(string umail)
        {
            var user = (await client.Child("Users")
                .OnceAsync<RegUserTable>()).Where(u => u.Object.Email == umail).FirstOrDefault();
            return (user != null);
        }

        public async Task<bool> RegisterUser(string umail,string passwd,string name,string surname)
        {
            if(await IsUserExists(umail)==false)
            {
                await client.Child("Users")
                    .PostAsync(new RegUserTable()
                    {
                        Email = umail,
                        Password = passwd,
                        Name=name,
                        Surname=surname,
                    }
                    );
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<bool> LoginUser(string umail,string passwd)
        {
            var user = (await client.Child("Users")
                .OnceAsync<RegUserTable>()).Where(u => u.Object.Email == umail).Where(u => u.Object.Password == passwd).FirstOrDefault();
            return (user != null);
        }
    }
}
