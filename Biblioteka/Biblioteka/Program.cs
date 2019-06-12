using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotekosKnyga;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "1985", 5, "Edgaras", new DateTime(2015,06,12));
            if (book1.IsDelay() == true)
            {
                Console.WriteLine("Knyga {0}, skaitytojas {1},", book1.BookName, book1.UserName);
                Console.WriteLine("Paėmimo data {0}", book1.DateWhenPicked.ToShortDateString());
            }
            else
            {
                Console.WriteLine("Knygos nevėluoja");
            }
            Console.ReadLine();
        }
    }
}
