using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HttpClientExample
{

    class Person
    {
        [JsonProperty("jmeno")]
        public string Jmeno { get; set; }
        [JsonProperty("prijmeni")]
        public string Prijmeni { get; set; }

        public override string ToString()
        {
            return $"{Jmeno},{Prijmeni}";
        }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            Person p = new Person { Jmeno = "Josef", Prijmeni = "Vyklar" };

            var JsonPerson = JsonConvert.SerializeObject(p);

            HttpClient htc = new HttpClient();
            HttpContent htcontent = new StringContent(JsonPerson, Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage response = await htc.PostAsync("https://ptsv2.com/t/2ffcy-1607690955/post", htcontent);
                Console.WriteLine(response);
            }
            catch (HttpRequestException)
            {
                ;
            }
        }
    }
}
