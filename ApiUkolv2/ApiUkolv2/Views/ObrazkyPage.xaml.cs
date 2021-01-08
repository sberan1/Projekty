using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiUkolv2.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiUkolv2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObrazkyPage : ContentPage
    {
        PictureLoading obrazky = new PictureLoading();
        public ObrazkyPage()
        {
            _ = obrazky.GetFromAPI();
            BindingContext = obrazky;
        }
        void Item_Tapped_Handler(object sender, ItemTappedEventArgs e)
        {
            Page p = new ObrazekPage((BindingContext as PictureLoading).ObrazkyList);
            NavigationPage np = new NavigationPage(p);
            Application.Current.MainPage.Navigation.PushAsync(np);
        }
    }
}