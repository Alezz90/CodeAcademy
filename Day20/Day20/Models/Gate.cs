using System;
using System.Collections.Generic;

namespace Day20.Models
{
    public partial class Gate
    {
        public Gate()
        {
            Flights = new HashSet<Flight>();
            Terminals = new HashSet<Terminal>();
        }

        public int GateNo { get; set; }
        public int? GateNumber { get; set; }
        public string? Availabil { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Terminal> Terminals { get; set; }
    }
}
