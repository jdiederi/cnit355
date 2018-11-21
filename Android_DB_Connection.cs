using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using SQLite;
using System.IO;
using Xamarin.Forms;
using FpV3.Droid;

[assembly: Dependency(typeof(Android_DB_Connection))]
namespace FpV3.Droid
{
    public class Android_DB_Connection : IDatabase
    {
        public Android_DB_Connection()
        {

        }

        public SQLiteConnection ConnectToDB()
        {
            var filename = "TestDB.db3";
            string folder = System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal); 
            var path = Path.Combine(folder, filename);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}