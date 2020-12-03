using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace register
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pozdrav : ContentPage
    {
        public Pozdrav()
        {
            InitializeComponent();
        }
        public Pozdrav(NameRecord personData)
        {
            InitializeComponent();
            BindingContext = personData;
        }
    }
}