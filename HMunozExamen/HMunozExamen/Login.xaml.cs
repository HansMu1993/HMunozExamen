using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HMunozExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string datoUno = txtUsuario.Text;
            string datoDos = txtClave.Text;

            if (datoUno == "estudiante2023" && datoDos == "uisrael2023")
                Navigation.PushAsync(new Registro(datoUno));
            else
                DisplayAlert("ALerta", "Clave / contraseña Incorrecta ", "Cancelar");
        }
    }
}