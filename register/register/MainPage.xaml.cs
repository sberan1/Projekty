using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Text.RegularExpressions;

namespace register
{
    public class NameRecord
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        private NameRecord personData;

        public MainPage()
        {
            InitializeComponent();
            personData = new NameRecord();
            BindingContext = personData;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            string regX = @"^ # start of line
(?=(?:.*[A-Z]){1,}) # 2 upper case letters
(?=(?:.*[a-z]){1,}) # 2 lower case letters
(?=(?:.*\d){1,}) # 2 digits
(?=(?:.*[!@#$%^&*()\-_=+{};:,<.>]){1,}) # 2 special characters
([A-Za-z0-9!@#$%^&*()\-_=+{};:,<.>]{8,20}) # length 12-20, only above char classes (disallow spaces)
$ # end of line
";
            Regex rg = new Regex(regX);

            if (rg.IsMatch(uPassword.Text))
            {
                Application.Current.MainPage.Navigation.PushAsync(new Pozdrav(personData));
            }
            else
            {
                DisplayAlert("Error", "Heslo musi obsahovat specialni znak, Velke pismeno a Cislo", "OK");
            }
        }
    }
}
