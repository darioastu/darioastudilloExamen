using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DarioAstudilloExamen
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async  void btnIngreso_Clicked(object sender, EventArgs e)
        {

            string persona = txtUser.Text;
            string clave = txtPass.Text;

            if (persona != "estudiante2021" | clave != "uisrael2021")
            {
                await DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar");
                return;
            }
            await Navigation.PushAsync(new Registro(persona));
        }

    }
 }

