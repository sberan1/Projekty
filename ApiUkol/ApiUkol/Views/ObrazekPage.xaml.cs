using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Collections.ObjectModel;

using Xamarin.Forms.Xaml;
using ApiUkol.Model;

namespace ApiUkol.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class jednotlive_Obrazky : ContentPage
    {
        public jednotlive_Obrazky()
        {
            InitializeComponent();

        }
        public jednotlive_Obrazky(ObservableCollection<Obrazky> obrKolekce)
        {
            InitializeComponent();
            BindingContext = obrKolekce;
        }
    }
}