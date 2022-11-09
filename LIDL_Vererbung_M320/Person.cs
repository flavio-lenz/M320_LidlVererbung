using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m320
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }

        public virtual void Esse()
        {
            Console.WriteLine("Ich als Person {0} {1} esse mit Messer und Gabel", Vorname, Name);
        }

        public abstract void Trage();
    }
}
