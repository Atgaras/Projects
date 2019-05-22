using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Mokinys
{
    public struct Mokinys
    {
        public string Vardas;
        public string Pavarde;
        public DateTime Pradzia;
        public DateTime Pabaiga;

        public Mokinys( string vardas, string pavarde, DateTime pradzia, DateTime pabaiga)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Pradzia = pradzia;
            Pabaiga = pabaiga;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mokinys mokinys1 = new Mokinys("Edgaras", "Goferis", new DateTime(2019, 04, 27), new DateTime(2019, 07, 04));
            Console.WriteLine(mokinys1.Vardas);
            Console.WriteLine(mokinys1.Pavarde);
            Console.WriteLine(mokinys1.Pradzia.ToShortDateString());
            Console.WriteLine(mokinys1.Pabaiga.ToShortDateString());

            Console.ReadLine();
        }
    }
}
