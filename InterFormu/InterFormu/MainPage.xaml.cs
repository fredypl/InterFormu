using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using InterFormu;
using SQLite;

namespace InterFormu
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<FormuDatos> Items { get; set; }
        SQLiteConnection database;
        public MainPage()
        {
            InitializeComponent();
            string db;            
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("DatsFor.db");
            database = new SQLiteConnection(db);
            database.CreateTable<FormuDatos>();
            var elemento = new FormuDatos()
            {
                Id = 1,
                Dato1 = "Sofia",
                Dato2 = "Juarez",
                Dato3 = "Flores",
                Dato4 = "San Lorenzo",
                Dato5 = 555678906,
                Dato6 = "Ing.Sistemas Computacionales",
                Dato7 = "Tercero",
                Dato8 = 13090354,
                Dato9 = "sofi.534@hotmail.com",
                Dato10 = "sofyajf"
            };
            Items = new ObservableCollection<FormuDatos>(database.Table<FormuDatos>());
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new DataPage()));
        }
    }
}
