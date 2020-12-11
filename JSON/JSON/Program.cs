using System;
using Newtonsoft.Json;

namespace JSON
{

    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person { Jmeno = "Anna", Prijmeni = "Novakova" };
            Person b = new Person { Jmeno = "Tomas", Prijmeni = "Novak" };
            Pair par = new Pair { p1 = a, p2 = b };

            var JsonPerson = JsonConvert.SerializeObject(a);
            var JsonPair = JsonConvert.SerializeObject(par);

            Console.WriteLine(JsonPerson);
            Console.WriteLine(JsonPair);

            Person c = JsonConvert.DeserializeObject<Person>(JsonPerson);

            Console.WriteLine(c);

        }
    }

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

    class Pair
    {
        [JsonProperty("mama")]
        public Person p1 { get; set; }
        [JsonProperty("tata")]
        public Person p2 { get; set; }
    }
}

