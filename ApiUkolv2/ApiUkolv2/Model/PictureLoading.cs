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

namespace ApiUkolv2.Model
{
    public class PictureLoading
    {
        public ObservableCollection<Obrazky> ObrazkyList { get; set; }
        public PictureLoading()
        {
            ObrazkyList = new ObservableCollection<Obrazky>();
            

        }
        public async Task GetFromAPI(Task errorMessage)
        {
            HttpClient http = new HttpClient();

            for (int i = 0; i < 50; i++)
            {
                try
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
                        HdUrl = jo["url"].ToString(),
                        Author = jo["copyright"].ToString()
                    });
                }
                catch (NullReferenceException)
                {

                }
                catch (HttpRequestException)
                {
                    await errorMessage;
                }
                
            }

        }
    }
}
