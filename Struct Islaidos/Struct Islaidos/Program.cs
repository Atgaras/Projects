using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Islaidos
{
    class Program
    {
        public struct Islaidos
        {
            double Maistas;
            double Buitis;
            double Mokesciai;
            double Laisvalaikis;
            double Saviugda;
            double Kita;

            public Islaidos(double maistas, double buitis, double mokesciai, double laisvalaikis, double saviugda, double kita)
            {
                Maistas = maistas;
                Buitis = buitis;
                Mokesciai = mokesciai;
                Laisvalaikis = laisvalaikis;
                Saviugda = saviugda;
                Kita = kita;

            }
            public int Suma()
            {
                return Maistas + Buitis + Mokesciai + Laisvalaikis + Saviugda + Kita;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
