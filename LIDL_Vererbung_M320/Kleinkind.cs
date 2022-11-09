using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m320
{
    class Kleinkind : Person
    {
        public int Alter { get; set; }

        public override void Esse()
        {
            base.Esse();
            Console.WriteLine("... Nein, als Kleinkind {0} {1} mit alter {2} esse natürlich von Hand...", Vorname, Name, Alter);
        }

        public override void Trage()
        {
            Console.WriteLine("Ich als Kleinkind {0} {1} trage gar nichts", Vorname, Name);
        }
    }
}
