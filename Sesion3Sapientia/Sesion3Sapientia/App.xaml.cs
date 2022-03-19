using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sesion3Sapientia
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Page3();
            
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
