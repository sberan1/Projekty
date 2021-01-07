using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;


namespace ApiUkol.Model
{
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
