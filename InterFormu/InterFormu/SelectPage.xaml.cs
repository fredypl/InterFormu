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
    public partial class SelectPage : ContentPage
    {
        public ObservableCollection<FormuDatos> Items { get; set; }
        SQLiteConnection database;
        public SelectPage(object selectedItem)
        {
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("DatsFor.db");
            var dato = selectedItem as FormuDatos;
            BindingContext = dato;
            database = new SQLiteConnection(db);
            string[] semestre = {"1", "2", "3","4","5","6","7","8","9","10","11","12"};
            Picker_Semestre.ItemsSource = semestre;
            Picker_Semestre.SelectedItem = dato.Dato7;
            string[] carrera = { "Ing.Sistemas Computacionales", "Ing.Civil","Ing.Industrial", "Ing.Mecatronica", "Lic.Administracion", "Lic.Biologia", "Lic.Gastronomia",};
            Picker_Carrera.ItemsSource = carrera;
            Picker_Carrera.SelectedItem = dato.Dato6;

        }

        private void Button_Actualizar_Clicked(object sender, EventArgs e)
        {
            var datos = new FormuDatos
            {
                Id = Convert.ToInt32(Entry_Id.Text),
                Dato1 = Entry_Nombre.Text,
                Dato2 = Entry_Apellido_Paterno.Text,
                Dato3 = Entry_Apellido_Materno.Text,
                Dato4 = Entry_Direccion.Text,
                Dato5 = Convert.ToInt64(Entry_Telefono.Text),
                Dato6 = Convert.ToString(Picker_Carrera.SelectedItem),
                Dato7 = Convert.ToString(Picker_Semestre.SelectedItem),
                Dato8 = Convert.ToInt32(Entry_Matricula.Text),
                Dato9 = Entry_Correo.Text,
                Dato10 = Entry_GitHub.Text
            };
            database.Update(datos);
            Navigation.PushAsync(new DataPage());
        }

        private void Button_Eliminar_Clicked(object sender, EventArgs e)
        {
            var datos = new FormuDatos
            {
                Id = Convert.ToInt32(Entry_Id.Text),
                Dato1 = Entry_Nombre.Text,
                Dato2 = Entry_Apellido_Paterno.Text,
                Dato3 = Entry_Apellido_Materno.Text,
                Dato4 = Entry_Direccion.Text,
                Dato5 = Convert.ToInt64(Entry_Telefono.Text),
                Dato6 = Convert.ToString(Picker_Semestre.SelectedItem),
                Dato7 = Convert.ToString(Picker_Semestre.SelectedItem),
                Dato8 = Convert.ToInt32(Entry_Matricula.Text),
                Dato9 = Entry_Correo.Text,
                Dato10 = Entry_GitHub.Text
            };
                 database.Delete(datos);
                 Navigation.PushAsync(new DataPage());
        }
    }
}