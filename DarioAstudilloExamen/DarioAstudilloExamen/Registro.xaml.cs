using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DarioAstudilloExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string nombreUsuario = " "; 
        public Registro(string persona)
        {
            InitializeComponent();
            string txtNombre = persona;
            this.nombreUsuario = persona;

        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(txtmMonto.Text);
          
            string persona1 = txtNombre.Text;
            double resto;
            double total;
            double costoCurso=1800;
            
            
            if (monto<=costoCurso)
            {
                resto = costoCurso - monto;
                resto = resto / 3;
                total = costoCurso + 3 * (resto + ((costoCurso * 5) / 100));


                await Navigation.PushAsync(new Resumen(persona1,total,this.nombreUsuario));
            }
            else
            {
                DisplayAlert("Cuota  mayor  a ", Convert.ToString(costoCurso), "ingresar Nuevamente");

            }

           
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string persona1 = txtNombre.Text;
            DisplayAlert("Elemento Guardado con exito  ",persona1, "OK");
        }
    }
}