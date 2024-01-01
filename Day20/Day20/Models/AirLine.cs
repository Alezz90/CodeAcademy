using System;
using System.Collections.Generic;

namespace Day20.Models
{
    public partial class AirLine
    {
        public AirLine()
        {
            Flights = new HashSet<Flight>();
        }

        public int AirLineNo { get; set; }
        public string? AirlineName { get; set; }
        public int? ContactNumber { get; set; }
        public string? ContactEmail { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}
