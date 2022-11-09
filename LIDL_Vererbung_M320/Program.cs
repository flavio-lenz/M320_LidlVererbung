namespace m320
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person() { Vorname = "Hans", Name = "Meier" };
            Kunde kunde1 = new Kunde() { Vorname = "Fritz", Name = "Mueller", Umsatz = 1000.0 };
            Lagerist lagerist1 = new Lagerist() { Vorname = "Joe", Name = "Manser", Groesse = 180 };
            Kleinkind kleinkind1 = new Kleinkind() { Vorname = "Kiddy", Name = "Kid", Alter = 3 };

            //person1.Esse();
            kunde1.Esse();
            kunde1.Kaufe();
            kunde1.Trage();
            lagerist1.Esse();
            lagerist1.LagereEin();
            lagerist1.Trage();
            kleinkind1.Esse();
            kleinkind1.Trage();
        }
    }
}