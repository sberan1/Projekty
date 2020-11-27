using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HtmlAgilityPack;

namespace Xam1
{
    public class NameRecord
    {
        public string Osloveni { get; set; }
        public string Name { get; set; }
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
            Application.Current.MainPage.Navigation.PushAsync(new Pozdrav(personData));
        }

        //public void Parser()
        //{
        //    var html = @"http://ssps.cz";

        //    HtmlWeb web = new HtmlWeb();

        //    var htmlDoc = web.Load(html);

        //    var tridySelected = htmlDoc.DocumentNode.SelectNodes("/html/body/div[1]/main/section/div/div/div[1]/div/div/div[1]/div/div");

        //    Console.WriteLine(tridySelected);

        //}
    }
}
