using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace prvniHodina
{
    class Program
    {
        static void Main(string[] args)
        {
            Clovek Karel = new Clovek();
            Console.WriteLine("napis jmeno cloveka");
            Karel.Jmeno = Console.ReadLine();
            Console.WriteLine("napis prijmeni cloveka");
            Karel.Prijmeni = Console.ReadLine();
            Console.WriteLine("napis rodne cislo");
            Obcan Pepa = new Obcan(Karel, Console.ReadLine());
            Console.WriteLine("je to " + Pepa.Jmeno + " " + Pepa.Prijmeni + " " + Pepa.RodneCislo);
            Console.ReadLine();
        }
    }

    class Clovek
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }

        public Clovek()
        {
            Jmeno = "Nezname";
            Prijmeni = "Nezname";
        }

        public Clovek(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public override string ToString()
        {
            return "Jmeno cloveka x je" + Jmeno + " " + Prijmeni;
        }
    }

    class Obcan : Clovek
    {
        private string rodneCisloPrivate;
        public string RodneCislo {
            get { return rodneCisloPrivate; }
            set {  
                string pattern = @"\d{6}[\/]\d{4}";
                string input = value;
                Regex R = new Regex(pattern);
                if (R.IsMatch(value))
                {
                    rodneCisloPrivate = value;
                }
                else
                {
                    Console.WriteLine("chyba v zadani rc, zkus to znovu");
                }
            }
        }

        public Obcan()
        {
            RodneCislo = "000000/0000";
            Jmeno = "Nezname";
            Prijmeni = "Nezname";
        }

        public Obcan(Clovek karel, string rodneCislo) : base(karel.Jmeno, karel.Prijmeni)
        {
            RodneCislo = rodneCislo;
  
        }
    }
     
}
