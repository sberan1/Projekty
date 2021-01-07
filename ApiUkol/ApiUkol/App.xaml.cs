using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ApiUkol.Views;

namespace ApiUkol
{
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ObrazkyPage());
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
