using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Xam1.Models
{
    class People
    {
        public ObservableCollection<AMan> AllPeople { get; set; }

        public People()
        {
            AllPeople = new ObservableCollection<AMan>();
            AllPeople.Add(new AMan { FirstName="Jan", Age=7, Surname="Blatny"});
            AllPeople.Add(new AMan { FirstName = "Jirina", Age = 42, Surname = "Blatna" });
            AllPeople.Add(new AMan { FirstName = "Filip", Age = 35, Surname = "Novak" });
            AllPeople.Add(new AMan { FirstName = "Richard", Age = 23, Surname = "Kovar" });

        }
    }
}
