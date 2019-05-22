using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Saugykla_Zmogus
{
    class Program
    {
        public struct Zmogus
        {
            public string Vardas;
            public string Pavarde;
            public DateTime GimimoData;

            public Zmogus(string vardas, string pavarde, DateTime gimimoData)
            {
                Vardas = vardas;
                Pavarde = pavarde;
                GimimoData = gimimoData;
            }
        }
        static void Main(string[] args)
        {
            List < Zmogus > listas = new List<Zmogus>();
            Console.WriteLine("Įveskite savo vardą:");
            Zmogus zm1 = new Zmogus();
            zm1.Vardas = Console.ReadLine();
            Console.WriteLine("Įveskite savo pavardę:");
            Zmogus zm01 = new Zmogus();
            zm01.Pavarde = Console.ReadLine();
            Console.WriteLine("Įveskite savo amžių:");
            Zmogus zm001 = new Zmogus();
            zm001.GimimoData = DateTime(Console.ReadLine());
            
            listas.Add(zm1);
            Console.ReadLine();
        }
    }
}
