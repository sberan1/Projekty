using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Read("C:\\Users\\stepa\\Desktop\\watched folder\\dick.txt");
            Console.Read();
        }

        public static void Read(string cesta)
        {
            
            Dictionary<string, int> s = new Dictionary<string, int>();
            string l = File.ReadAllText(cesta);
           
                string[] words = l.Split(' ', '.', ',');
                foreach (string word in words)
                {
                    if (word.Length > 2 && word != " " && s.ContainsKey(word))
                        s[word] += 1;
                    else if (word.Length > 2 && word != " " && s.ContainsKey(word) == false)
                        s.Add(word, 1);

                    //StreamWriter sw = File.CreateText(cesta);
                    Console.WriteLine("Slovo             abs. četnost            rel. četnost");
                    Console.WriteLine("======================================================");
                    foreach (KeyValuePair<string, int> da in s)
                    {
                    Console.WriteLine("{0}               {1}                {2}", da.Key, da.Value, Convert.ToDouble(da.Value) / Convert.ToDouble(da.Key.Length));
                    }
                }
        }
    }
}

