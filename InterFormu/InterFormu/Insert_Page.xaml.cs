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
    public partial class Insert_Page : ContentPage
    {
        public ObservableCollection<FormuDatos> Items { get; set; }
        SQLiteConnection database;
        public Insert_Page()
        {
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("DatsFor.db");
            database = new SQLiteConnection(db);

        }


        private void Button_Insertar_Clicked(object sender, EventArgs e)
        {
            var datos = new FormuDatos
            {
                Id = Convert.ToInt32(Entry_Id.Text),
                Dato1 = Entry_Nombre.Text,
                Dato2 = Entry_Apellido_Paterno.Text,
                Dato3 = Entry_Apellido_Materno.Text,
                Dato4 = Entry_Direccion.Text,
                Dato5 = Convert.ToInt64(Entry_Telefono.Text),
                Dato6 = Entry_Carrera.Text,
                Dato7 = Entry_Semestre.Text,
                Dato8 = Convert.ToInt32(Entry_Matricula.Text),
                Dato9 = Entry_Correo.Text,
                Dato10 = Entry_GitHub.Text
            };
            database.Insert(datos);
            Navigation.PushAsync(new DataPage());
        }
    }
}