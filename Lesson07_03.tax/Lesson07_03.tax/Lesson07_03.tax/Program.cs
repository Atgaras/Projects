using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07_03.tax
{
    public class Program
    {
        public static decimal Tax(decimal pajamos)
        {
            if (pajamos < 0)
                return 0;

            decimal result = 0;
            if (pajamos <= 40000)
            {
                result = pajamos * 0.05m;
            }
            else if (pajamos > 40000 && pajamos <= 100000)
            {
                result = pajamos * 0.15m;
            }
            else
            {
                result = pajamos * 0.25m;
            }
            return result;
        }
        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }
    }
}
