using ApiUkolv2.Views;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Analytics;
namespace ApiUkolv2
{

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ObrazkyPage());
        }

        protected override void OnStart()
        {
            AppCenter.Start("ios=7aaf386b-2d8a-4570-b778-3f3d86e04239;" +
                     "uwp={Your UWP App secret here};" +
                     "android={Your Android App secret here}",
                     typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
