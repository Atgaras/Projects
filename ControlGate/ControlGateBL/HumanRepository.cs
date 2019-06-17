using System;
using System.Collections.Generic;
using System.Text;

namespace ControlGateBL
{
    public class HumanRepository
    {
        private List<Human> humans = new List<Human>();
        public HumanRepository()
        {
            humans.Add(new Human());
        }
    }
}
