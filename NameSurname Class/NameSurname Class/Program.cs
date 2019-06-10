using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameCl;

namespace NameSurname_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Human zmogus = new Human("Edgaras", "Goferis", new DateTime(1985,11,22));
            Console.WriteLine("{0} {1}", zmogus.Name, zmogus.Surname);
            Console.WriteLine("Gimimo data: {0}, Amžius: {1}", zmogus.DateOfBirth.ToShortDateString(), zmogus.GetAge());
            Console.ReadLine();
        }
    }
}
