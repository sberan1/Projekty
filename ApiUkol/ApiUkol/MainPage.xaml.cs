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

namespace ApiUkol
{
    public partial class MainPage : ContentPage
    {
        
        public IList<Obrazky> ObrazkyList { get; private set; }
        public async Task GetFromAPI()
        {
            HttpClient http = new HttpClient();
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    DateTime now = DateTime.Now;
                    string url = "https://api.nasa.gov/planetary/apod?api_key=XFq4TltKnfiWzSEqSKNz5vky7f8XY4IPKXnzCjpz&date=" + now.AddDays(-i).ToString("yyyy-M-dd");
                    HttpResponseMessage response = await http.GetAsync(url, HttpCompletionOption.ResponseContentRead);
                    string res = await response.Content.ReadAsStringAsync();
                    JObject jo = JObject.Parse(res);


                    ObrazkyList.Add(new Obrazky
                    {
                        Title = jo["title"].ToString(),
                        Explanation = jo["explanation"].ToString(),
                        HdUrl = jo["hdurl"].ToString(),
                        Author = jo["copyright"].ToString()
                    });
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
            public MainPage()
        {
            GetFromAPI();
            InitializeComponent();
            


            BindingContext = this;
        }
    }
    public class Obrazky
    {
        public string Title { get; set; }
        public string Explanation { get; set; }
        public string HdUrl { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
