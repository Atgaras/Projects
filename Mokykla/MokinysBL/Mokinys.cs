using System;
using System.Collections.Generic;

namespace MokinysBL
{
    public class Mokinys
    {
        public int Id { get; private set; }
        public string Vardas { get; private set; }
        public bool OlimpiaduNugaletojas { get; set; }
        public List<int> PazymiuSarasas { get; set; }

        public Mokinys(int id, string vardas, bool olimpiaduNugaletojas)
        {
            Id = id;
            Vardas = vardas;
            OlimpiaduNugaletojas = olimpiaduNugaletojas;
            PazymiuSarasas = new List<int>();
        }

        public int PazymiuVidurkis()
        {
            int pazymiuVidurkis = 0;
            int pazymiuSuma = 0;
            if (PazymiuSarasas.Count == 0)
            {
                return 0;
            }

            foreach (var pazymys in PazymiuSarasas)
            {
                pazymiuSuma = pazymiuSuma + pazymys;
            }

            pazymiuVidurkis = pazymiuSuma / PazymiuSarasas.Count;

            return pazymiuVidurkis;

        }
    }
}
