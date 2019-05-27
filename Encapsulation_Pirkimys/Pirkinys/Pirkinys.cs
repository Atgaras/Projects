using System;

namespace NewPirkinys
{
    public struct Pirkinys
    {
        private string _prekesPavadinimas;
        private string _kiekis;
        private string _kainaVieneto;

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
        public string KainaVieneto
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
        public string KainaViso
        {
            get
            {
                return string.Format(_kainaVieneto);
                    
                    //("Kaina viso: {0} €", _kainaVieneto*_kiekis);
            }

        }
        public Pirkinys (string prekesPavainimas, string kiekis, string kainaVieneto)
        {
            _prekesPavadinimas = prekesPavainimas;
            _kiekis = kiekis;
            _kainaVieneto = kainaVieneto;
        }
    }
 
}
