using System;

namespace NewPirkinys
{
    public struct Pirkinys
    {
        private string _prekesPavadinimas;
        private decimal _kiekis;
        private decimal _kainaVieneto;

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
        public decimal Kiekis
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
        public decimal KainaVieneto
        {
            get
            {
                return _kainaVieneto;
            }
            private set
            {
                _kainaVieneto = value;
            }
        }
        public decimal KainaViso
        {
            get
            {
                return _kainaVieneto*_kiekis;
                    
                    //("Kaina viso: {0} €", _kainaVieneto*_kiekis);
            }

        }
        public Pirkinys (string prekesPavadinimas, decimal kiekis, decimal kainaVieneto)
        {
            _prekesPavadinimas = prekesPavadinimas;
            _kiekis = kiekis;
            _kainaVieneto = kainaVieneto;
        }
    }
 
}
