using System;
using System.Collections.Generic;
using System.Text;

namespace ControlGateBL
{
    public class Event
    {
        public int Id { get; set; }
        public int HumanId { get; set; }
        public int GateId { get; set; }
        public DateTime Date { get; set; }
        public bool Pass { get; set; }
    }
}
