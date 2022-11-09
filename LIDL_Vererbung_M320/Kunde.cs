using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m320
{
    public class Kunde : Person
    {
        public double Umsatz { get; set; }

        public void Kaufe()
        {
            Console.WriteLine("Ich als Kunde {0} {1} kaufe bei Lidl", Vorname, Name);
        }

        public override void Trage()
        {
            Console.WriteLine("Ich als Kunde {0} {1} trage mit dem Einkaufswagen", Vorname, Name);
        }
    }
}
