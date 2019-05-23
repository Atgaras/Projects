using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStruct;

namespace Knygos
{
    class Program
    {
        static void Main(string[] args)
        {
            Book knyga;
            knyga = new Book("Pavadinimas", "123");
            Console.WriteLine(knyga.Name);
            Console.WriteLine(knyga.Id);
            Console.WriteLine(knyga.LocalId);

            Console.ReadLine();
        }
    }
}