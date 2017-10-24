using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using InterFormu.UWP;
using Windows.Storage;
using SQLite;

[assembly: Dependency(typeof(SQLite_UWP))]
namespace InterFormu.UWP
{
    public class SQLite_UWP : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {

            return Path.Combine(ApplicationData.Current.LocalCacheFolder.Path, filename);

        }
    }
}
