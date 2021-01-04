using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace Get
{
    public partial class Program 
    {

        static async System.Threading.Tasks.Task Main(string[] args)
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


                    Console.WriteLine
                    ("{0}", jo["url"].ToString());
                    //jo["title"].ToString(), jo["explanation"].ToString(), jo["copyright"].ToString()
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}