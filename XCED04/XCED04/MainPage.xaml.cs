using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XCED04.Model;

namespace XCED04
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<Alumno> RegistroAlumnos { get; set; }
        public MainPage()
        {
            InitializeComponent();
            RegistroAlumnos = new List<Alumno>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Alumno Alumn = new Alumno();
            Alumn.Nombre = ENombre.Text;
            Alumn.Apellido = EApellido.Text;
            Alumn.Edad = Convert.ToInt32(EEdad.Text);
            Alumn.Especialidad = EEspecialidad.Text;

            if ( string.IsNullOrEmpty(Alumn.Nombre)
                || string.IsNullOrWhiteSpace(Alumn.Apellido))
            {
                App.Current.MainPage.DisplayAlert("Error en formulario",
                    "El nombre y el apellido son obligatorios",
                    "ok");
                ENombre.PlaceholderColor = Color.Red;
                EApellido.PlaceholderColor = Color.Red;
                return;
            }

            if (Alumn.Edad < 16 || Alumn.Edad > 29)
            {
            App.Current.MainPage.DisplayAlert("Error", 
                "La edad debe ser entre 16 y 29", "ok");
                EEdad.PlaceholderColor = Color.Red;
                return;
            }

            if (Alumn.Especialidad == "XAMARIN" || 
                Alumn.Especialidad == "HTML" || Alumn.Especialidad == "MVC")
            {
                RegistroAlumnos.Add(Alumn);
                ListViewAlumnos.ItemsSource = null;
                ListViewAlumnos.ItemsSource = RegistroAlumnos;
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Error",
                 "error la  especialidad tiene que ser xamarin,HTML,MVC", "ok");
                EEdad.PlaceholderColor = Color.Red;
                return;
            }

          
        }
    }
}
