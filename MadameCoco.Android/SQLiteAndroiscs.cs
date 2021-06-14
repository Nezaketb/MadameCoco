using SQLite;
using MadameCoco.Data;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(MadameCoco.Droid.SQLiteAndroiscs))]
namespace MadameCoco.Droid
{
    public class SQLiteAndroiscs:ISQLite

    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;
        }
    }
}