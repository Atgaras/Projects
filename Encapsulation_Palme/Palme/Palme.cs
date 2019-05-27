using System;

namespace PalmeStruct
{
    public struct Palme
    {
        private string _amzius;
        private string _vaisiuKiekis;
        public string Amzius
        {
            get
            {
                return _amzius;
            }
            private set
            {
                _amzius = value;
            }
        }
        public string VaisiuKiekis
        {
            get
            {
                return _vaisiuKiekis;
            }
            private set
            {
                _vaisiuKiekis = value;
            }
        }
        public Palme(string amzius, string vaisiuKiekis)
        {
            _amzius = amzius;
            _vaisiuKiekis = vaisiuKiekis;
        }
       
    }
    
   
}
