using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace HMunozExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public decimal intParametromaximo = 3000;
        public decimal intParametroPorcentaje = decimal.Parse("0,05");
        public decimal cuota;
        public decimal interes;
        public decimal pago;

        public Registro(string strUsuario)
        {
            InitializeComponent();

            lblUsuario.Text = strUsuario;
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resumen(pago, cuota,txtNombre.Text , lblUsuario.Text));
        }
    
        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
       
            if (ValidarNumeroSegmento(txtPago.Text) && ValidarLetrasSegmento(txtNombre.Text))
            {
                pago = decimal.Parse(txtPago.Text); 
                cuota = intParametromaximo - pago;
                cuota = cuota / 3;
                interes = intParametromaximo * intParametroPorcentaje; 
                cuota = cuota + interes;

                txtCuota.Text = Math.Round(cuota, 2, MidpointRounding.ToEven).ToString();
           


            }

        }


        private void Limpiar()
        {
            txtCuota.Text = "";
            txtPago.Text = ""; 
        }
        private bool ValidarNumeroSegmento(string valor)
        {

            try
            {
                decimal dato = Convert.ToDecimal(valor);
                decimal valorMinimo = Convert.ToDecimal("0,1");


                if (dato < valorMinimo || dato >= intParametromaximo)
                {
                    DisplayAlert("Mensaje de Error", "El valor " + valor + "  No tiene rango de 0.1 a 2999.99 ", "Cerrar");
                    Limpiar();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                DisplayAlert("Mensaje de Error", "El valor " + valor + "No es un numero ", "Cerrar");
                Limpiar();
                return false;
            }




        }
        private bool ValidarLetrasSegmento(string valor)
        {

            bool retorno = false;

            try
            {
                 


                foreach (char c in valor.Trim())
                {
                    if (!char.IsLetter(c))
                    {
                        DisplayAlert("Mensaje de Error", "El valor " + valor + "  No es una letra , solo se permiten letras", "Cerrar");
                        Limpiar();
                        return  false;
                    }
                    else
                    {
                        retorno= true;
                    }
                }

                
            }
            catch
            {
                DisplayAlert("Mensaje de Error", "El valor " + valor + "No es un letra ", "Cerrar");
                Limpiar();
                retorno= false;
            }

            return retorno;


        }
    }
}