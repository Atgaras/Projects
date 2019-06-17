using System;
using System.Collections.Generic;
using System.Text;
using MokinysBL;

namespace MokinysBL
{
    public class MokiniuRepozitorija
    {
        private List<Mokinys> mokiniai = new List<Mokinys>();
        public MokiniuRepozitorija()
        {
            mokiniai.Add(new Mokinys(1, "Jonas", false));
            mokiniai.Add(new Mokinys(2, "Petras", true));
            mokiniai.Add(new Mokinys(3, "Antanas", false));
            mokiniai.Add(new Mokinys(4, "Mykolas", false));
        }
        public List<Mokinys> Retrieve()
        {
            return mokiniai;
        }
        public Mokinys Retrieve(int id)
        {
            foreach (var mokinys in mokiniai)
            {
                if (mokinys.Id == id)
                {
                    return mokinys;
                }
            }
            return null;
        }
    }
}