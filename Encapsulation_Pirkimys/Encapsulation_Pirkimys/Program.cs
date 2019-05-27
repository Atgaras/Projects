using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewPirkinys;

namespace Encapsulation_Pirkinys
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirkinys pirk1;
            pirk1 = new Pirkinys("Dviratis", "1", "500");
            Console.WriteLine("Gavėjas: {0}", pirk1.PrekesPavadinimas);
            Console.WriteLine("Siuntėjas: {0}", pirk1.Kiekis);
            Console.WriteLine("Mokėti viso: {0}", pirk1.KainaVieneto);
            Console.WriteLine("Kaina viso: {0}", pirk1.KainaViso);

            Console.ReadLine();
        }
    }
}
