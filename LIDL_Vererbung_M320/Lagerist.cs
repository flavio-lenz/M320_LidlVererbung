using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m320
{
    public class Lagerist : Person
    {
        public int Groesse { get; set; }

        public void LagereEin()
        {
            Console.WriteLine("Ich als Lagerist {0} {1} lagere ein", Vorname, Name);
        }

        public override void Trage()
        {
            Console.WriteLine("Ich als Lagerist {0} {1} trage mit dem Stapler", Vorname, Name);
        }
    }
}
