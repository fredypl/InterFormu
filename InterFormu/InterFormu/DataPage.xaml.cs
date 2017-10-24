using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterFormu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPage : ContentPage
    {
        public ObservableCollection<FormuDatos> Items { get; set; }
        SQLiteConnection database;
        public DataPage()
        {
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("DatsFor.db");
            database = new SQLiteConnection(db);
            database.CreateTable<FormuDatos>();
            var elemento = new FormuDatos();


            Items = new ObservableCollection<FormuDatos>(database.Table<FormuDatos>());
            BindingContext = this;
        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new SelectPage(e.SelectedItem as FormuDatos));
        }

        private void Insertar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Insert_Page());
        }

    }
}