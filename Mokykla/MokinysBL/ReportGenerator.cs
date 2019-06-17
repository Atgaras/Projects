using System;
using System.Collections.Generic;
using System.Text;

namespace MokinysBL
{
    public class ReportGenerator
    {
        private static MokiniuRepozitorija _mokiniuRepozitorija;
        public ReportGenerator(MokiniuRepozitorija mokiniuRepozitorija)
        {
            _mokiniuRepozitorija = mokiniuRepozitorija;
        }

        public string GeneruotiMokiniuAtaskaita()
        {
            string result = "";
            List<Mokinys> visiMokiniai = _mokiniuRepozitorija.Retrieve();

            foreach (var vienasMokinys in visiMokiniai)
            {
                result += string.Format("{0}, {1}", vienasMokinys.Id, vienasMokinys.Vardas);
            }
            return result;
        }
    }
}