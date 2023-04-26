using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HMunozExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            //Habilitamo la navegacion 
            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
