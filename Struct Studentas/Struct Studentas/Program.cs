using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Studentas
{
    class Program
    {
        public struct Studentas
        {
            public int Id;
            public bool IskRezultatas;

            public Studentas(int id, bool iskRezultatas)
            {
                Id = id;
                IskRezultatas = iskRezultatas;
            }
        }
        static void Main(string[] args)
        {
            List<Studentas> sarasas= new List<Studentas>();
            Studentas stu1 = new Studentas;
            stu1.Id = 1;
            stu1.IskRezultatas = false;

            sarasas.Add(stu1);
        }
    }
}
