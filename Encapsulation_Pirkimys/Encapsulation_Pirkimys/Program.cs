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
            List<Pirkinys> prekiuSarasas = new List<Pirkinys>();
            Pirkinys pirk1 = new Pirkinys("Dviratis", 2, 500);
            prekiuSarasas.Add(pirk1);
            Pirkinys pirk2 = new Pirkinys("Triratis", 5, 150);
            prekiuSarasas.Add(pirk2);
            Pirkinys pirk3 = new Pirkinys("Vienaratis", 3, 147);
            prekiuSarasas.Add(pirk3);
            bool vartotojasPasirinkoIseiti = false;

            while (vartotojasPasirinkoIseiti == false)
            {
                Console.WriteLine("Ką norite atlikti: [1] Pridėti prekę, [2] Parodyti visą sąrašą");
                int veiksmas = int.Parse(Console.ReadLine());
                if (veiksmas == 1)
                {
                    string tempPavadinimas;
                    decimal tempKiekis = 0;
                    decimal tempVienetoKaina = 0;
                    Console.WriteLine("Įveskite prekės pavadinimą:");
                    tempPavadinimas = Console.ReadLine();
                    Console.WriteLine("Įveskite prekių kiekį:");
                    tempKiekis = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Įveskite prekės vieneto kainą:");
                    tempVienetoKaina = decimal.Parse(Console.ReadLine());
                    Pirkinys naujaPreke = new Pirkinys(tempPavadinimas, tempKiekis, tempVienetoKaina);
                    prekiuSarasas.Add(naujaPreke);
                }
                else if (veiksmas == 2)
                {
                    decimal suma = 0;
                    for (int i = 0; i < prekiuSarasas.Count; i++)
                    {
                        Console.WriteLine("{0}, {1}, {2}, {3}", prekiuSarasas[i].PrekesPavadinimas, prekiuSarasas[i].Kiekis, prekiuSarasas[i].KainaVieneto, prekiuSarasas[i].KainaViso);
                        suma = suma + prekiuSarasas[i].KainaViso;
                    }
                    Console.WriteLine("Bandra visų prekių suma: {0}€", suma);
                }
                else
                {
                    Console.WriteLine("Neatpažintas veiksmas");
                }
                Console.WriteLine("[1] Tęsti darbą, [2] Išeiti");
                int vartotojoPasirinkimas = int.Parse(Console.ReadLine());
           

                if (vartotojoPasirinkimas==2)
                {
                    vartotojasPasirinkoIseiti = true;
                }
            
            }
            Console.ReadLine();
        }
    }
}
