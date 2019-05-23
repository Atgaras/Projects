using System;

namespace Bill
{
    public struct Saskaita
    {
        private string _gavejas;
        private string _siuntejas;
        private string _moketiViso;
        
        public string Gavejas
        {
            get
            {
                return _gavejas;
            }
            private set
            {
                _gavejas = value;
            }
        }
        public string Siuntejas
        {
            get
            {
                return _siuntejas;
            }
            private set
            {
                _siuntejas = value;
            }
        }
        public string MoketiViso
        {
            get
            {
                return _moketiViso;
            }
            private set
            {
                _moketiViso = value;
            }
        }
        public string SaskaitosNr
        {
            get
            {
                return string.Format("NR_{0}_{1}_{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
           
        }
        public Saskaita(string gavejas, string siuntejas, string moketiViso)
        {
            _gavejas = gavejas;
            _siuntejas = siuntejas;
            _moketiViso = moketiViso;
        }

    }
}
