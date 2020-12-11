using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oof
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zvire kalousUsaty = new Zvire(2, "svine", false);
            //Pes Karel = new Pes("Zerik", true, "bernardyn");
            //Karel.Mluv();
            //Console.ReadLine();
        }
    }


    class Obrazce
    {
        int obsah;
        public virtual void Obvod(int stranaA, int stranaB)
        {      
           int Obvod = stranaA * 4;   
        }
        public virtual void Obsah(int stranaA, int stranaB)
        {
            int Obsah = stranaA * stranaA;
        }
        class Obdelnik : Obrazce
        {
            public int DelkaStranyA { get; set; }
            public int DelkaStranyB { get; set; }
            public override void Obsah(int stranaA, int stranaB)
            {

                int Obsah = stranaA * stranaB;
            }
            public override void Obvod(int stranaA, int stranaB)
            {
                int Obvod = (stranaA + stranaB) * 2;
            }

        }
        class Ctverec : Obrazce
        {
            
            public int DelkaStranyA { get; set; }
            public override void Obsah(int stranaA)
            {
                base.Obsah(stranaA);
            }
            public override void Obvod(int stranaA)
            {
                base.Obvod(stranaA);
            }
        }
        class Kruh : Obrazce
        {
            public int DelkaPolomeru { get; set; }
        }
    }

    //class Zvire
    //{
    //    public int PocetKoncetin { get; set; }
    //    public string Nazev { get; set; }
    //    public bool MaSrst { get; set; }


    //    public Zvire(int pocetKoncetin, string nazev, bool maSrst)
    //    {
    //        PocetKoncetin = pocetKoncetin;
    //        Nazev = nazev;
    //        MaSrst = maSrst;
    //    }

    //    public virtual void Mluv()
    //    {
    //        Console.WriteLine("Ahoj!");
    //    }
    //}

    //class Pes : Zvire
    //{
    //    public string Plemeno { get; set; }

    //    public Pes(string nazev, bool srst, string plemeno) : base(4, nazev, srst)
    //    {
    //        Plemeno = plemeno; 
    //    }

    //    public override void Mluv()
    //    {
    //        Console.WriteLine("whoof!");
    //    }
    //}
}
