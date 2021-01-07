using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ApiUkol.Model;

namespace ApiUkol.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObrazkyPage : ContentPage
    {
        PictureLoading obrazky = new PictureLoading();
        public ObrazkyPage()
        {
            InitializeComponent();
            _ = obrazky.GetFromAPI();
            BindingContext = obrazky;
        }
        async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Page p = new jednotlive_Obrazky((BindingContext as PictureLoading).ObrazkyList);
            NavigationPage np = new NavigationPage(p);
            await Application.Current.MainPage.Navigation.PushAsync(np);
        }
    }
}