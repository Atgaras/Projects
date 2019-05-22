using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Staciakampis
{
    class Program
    {
        public struct Staciakampis
        {
            public int Ilgis;
            public int Plotis;

            public Staciakampis(int ilgis, int plotis)
            {
                Ilgis = ilgis;
                Plotis = plotis;
            }
            public int SkaiciuotiPlota()
            {
                return Ilgis * Plotis;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite stačiakampio ilgį:");
            int ilgis = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite stačiakampio plotį:");
            int plotis = int.Parse(Console.ReadLine());

            Staciakampis pirmas = new Staciakampis(ilgis, plotis);
            Console.WriteLine("Stačiakampio plotas yra {0}.", pirmas.SkaiciuotiPlota());
            Console.ReadLine();
        }
    }
}
