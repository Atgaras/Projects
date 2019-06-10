using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AircraftRegistrationBL;

namespace AircraftRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            ReportGenerator reportGenerator = new ReportGenerator(new CompanyRepository(), new CountryRepository(), new AircraftRepository(), new AircraftModelRepository());
            List<ReportItem> ataskaita = reportGenerator.GenerateReportAircraftInEurope();
            foreach (var eilute in ataskaita)
            {
                Console.WriteLine(eilute.AircraftTailNumber);
                Console.WriteLine(eilute.CompanyCountryName);
            }
            Console.ReadLine();
        }

    }
}
