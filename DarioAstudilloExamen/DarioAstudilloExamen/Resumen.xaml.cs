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
    public partial class Resumen : ContentPage
    {
        public Resumen(string persona, double total,string usuario)
        {
            InitializeComponent();

            txtnombreUsuario.Text = "Nombre usuario: "  +  persona;
            txtusuarioConectado.Text = "Usuario conectado: " + usuario;
            txtPagoFinal.Text = "El pago total: " + total.ToString();

           

        }
    }
}