using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;
using InterFormu.Droid;
using SQLite;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


[assembly: Dependency(typeof(SQLite_Droid))]
namespace InterFormu.Droid
{
   public class SQLite_Droid : ISQLite
    {
        public string GetLocalFilePath(string filename)

        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            return Path.Combine(path, filename);

        }
    }
}