using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktorius
{
    class Program
    {
        public struct Employee
        {
            public string Vardas;
            public int Id;

            public Employee(string vardas, int id)
            {
                Vardas = vardas;
                Id = id;
            }
        }
        static void Main(string[] args)
        {
            Employee darbuotojas = new Employee("vardas1", 1);
            Console.WriteLine(darbuotojas.Vardas);
            Console.WriteLine(darbuotojas.Id);


            Console.ReadLine();
        }
    }
}
