using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace Xam1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Debug.WriteLine($"Jsem v OnStart v {DateTime.Now}", "APPevent");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine($"Jsem v OnSleep v {DateTime.Now}", "APPevent");

        }

        protected override void OnResume()
        {
            Debug.WriteLine($"Jsem v OnResume v {DateTime.Now}", "APPevent");

        }
    }
}
