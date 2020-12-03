using DocumentFormat.OpenXml.EMMA;
using HtmlAgilityPack;
using System;
using System.Linq;
using System.Net.Http;
using System.Xml;

namespace webStealer
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetHtmlAsync();
            Console.WriteLine(1/3);
            int k = 0;
            int j = k++;
            int i = j++;
            Console.WriteLine($"{j}, {k}, {i}");
            Console.ReadLine();
        }
        private static async void GetHtmlAsync()
        {
            var link = "https://bakalari.ssps.cz/Login?gethx=s1j8rqt3x";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(link);

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            //var tridy = htmlDoc.DocumentNode.Descendants("div")
            //     .Where(node=>node.GetAttributeValue("class", "")
            //     .Equals("el - tabs__nav is -top")).ToList();
            
            
            Console.WriteLine();
        }
    }

    class Bakaweb
    {
        public Bakaweb()
        {
            //private string hx = 
        }
    }
}
