using System;
using System.Collections.Generic;
using System.Text;

namespace ControlGateBL
{
    public class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<int> GateIdRights { get; set; }
    }
}
