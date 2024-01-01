using System;
using System.Collections.Generic;

namespace Day20.Models
{
    public partial class Flight
    {
        public Flight()
        {
            Passengers = new HashSet<Passenger>();
        }

        public int FlightNo { get; set; }
        public string? DepartureCity { get; set; }
        public TimeSpan? DepartureTime { get; set; }
        public string? DestinationCity { get; set; }
        public TimeSpan? ArrivalTime { get; set; }
        public string? FlightStatus { get; set; }
        public int? AirLineNo { get; set; }
        public int? GateNo { get; set; }

        public virtual AirLine? AirLineNoNavigation { get; set; }
        public virtual Gate? GateNoNavigation { get; set; }
        public virtual ICollection<Passenger> Passengers { get; set; }
    }
}
