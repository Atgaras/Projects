using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Biblioteka
{
    class Program
    {
        public struct BibliotekosKnyga
        {
            public string Id;
            public string Pavadinimas;
            public string SkaitVardas;
            public DateTime PaemimoData;

            public BibliotekosKnyga(string id, string pavadinimas, string skaitVardas, DateTime paemimoData)
            {
                Id = id;
                Pavadinimas = pavadinimas;
                SkaitVardas = skaitVardas;
                PaemimoData = paemimoData;
            }
        }
        static void Main(string[] args)
        {
            BibliotekosKnyga knyga1 = new BibliotekosKnyga("1", "1984", "Edgaras", new DateTime(2019,02,05));
            Console.WriteLine("ID: {0}", knyga1.Id);
            Console.WriteLine("Pavadinimas: {0}", knyga1.Pavadinimas);
            Console.WriteLine("Skaitytojo vardas: {0}", knyga1.SkaitVardas);
            Console.WriteLine("Knyga paimta prieš {0} dienas(-ų).", DateTime.Today-knyga1.PaemimoData);

            Console.ReadLine();
        }
    }
}
