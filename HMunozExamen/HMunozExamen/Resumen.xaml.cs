using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HMunozExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(decimal strpago, decimal steCuota, string srtNombre, string strUsuario)
        { InitializeComponent();
            decimal total;

            lblUsuario.Text = strUsuario;
            txtusuario.Text = strUsuario;
            txtTNombre.Text = srtNombre;
            total = steCuota * 3;
            total = total + strpago;
             
            txtTotal.Text = Math.Round(total,2, MidpointRounding.ToEven).ToString();
           
        }
    }
}