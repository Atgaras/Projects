using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bill;

namespace Encap_Saskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Saskaita sask1;
            sask1 = new Saskaita("Edgaras", "Lpaštas", "123");
            Console.WriteLine("Gavėjas: {0}", sask1.Gavejas);
            Console.WriteLine("Siuntėjas: {0}", sask1.Siuntejas);
            Console.WriteLine("Mokėti viso: {0}", sask1.MoketiViso);
            Console.WriteLine("Sąskaitos Nr: {0}", sask1.SaskaitosNr);

            Console.ReadLine();
        }
    }
}
