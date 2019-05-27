using System;

namespace Prekes
{
    public class Preke
    {   
        private string _prekesPavadinimas;
        private string _kiekis;
        private string _kaina;

        public string PrekesPavadinimas
        {
            get
            {
                return _prekesPavadinimas;
            }
            private set
            {
                _prekesPavadinimas = value;
            }
        }
        public string Kiekis
        {
            get
            {
                return _kiekis;
            }
            private set
            {
                _kiekis = value;
            }
        }
        public string MoketiViso
        {
            get
            {
                return _kaina;
            }
            private set
            {
                _kaina = value;
            }
        }
 
        public Preke(string prekesPavadinimas, string kiekis, string kaina)
        {
            _prekesPavadinimas = prekesPavadinimas;
            _kiekis = kiekis;
            _kaina = kaina;
        }
    }
}