using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokinysBL;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Mokinys mokinys = new Mokinys(9, "Petras", true);
            Console.WriteLine(mokinys.Id);
            Console.WriteLine(mokinys.Vardas);

            mokinys.PazymiuSarasas.Add(10);
            mokinys.PazymiuSarasas.Add(9);
            mokinys.PazymiuSarasas.Add(2);
            mokinys.PazymiuSarasas.Add(10);
            mokinys.PazymiuSarasas.Add(10);

            foreach (var pazymys in mokinys.PazymiuSarasas)
            {
                Console.WriteLine("{0}", pazymys);
            }
            Console.WriteLine(mokinys.PazymiuVidurkis());
            Console.ReadLine();

            MokiniuRepozitorija repo = new MokiniuRepozitorija();
            List<Mokinys> mokiniai = repo.Retrieve();

            foreach (var student in mokiniai)
            {
                Console.WriteLine("ID={0}, Vardas = {1}, Olimpiadu Nugaletojas - {2}", student.Id, student.Vardas, student.OlimpiaduNugaletojas);
            }
            Console.ReadLine();

            Mokinys mokinys3 = repo.Retrieve(3);
            Console.WriteLine("ID={0}, Vardas = {1}, Olimpiadu Nugaletojas - {2}", mokinys3.Id, mokinys3.Vardas, mokinys3.OlimpiaduNugaletojas);
            Console.ReadLine();

            ReportGenerator reportGenerator = new ReportGenerator(new MokiniuRepozitorija());
            string ataskaita = reportGenerator.GeneruotiMokiniuAtaskaita();
            Console.WriteLine(reportGenerator);
            Console.ReadLine();
        }
    }
}