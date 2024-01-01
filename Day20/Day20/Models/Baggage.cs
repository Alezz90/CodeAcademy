using System;
using System.Collections.Generic;

namespace Day20.Models
{
    public partial class Baggage
    {
        public int BaggId { get; set; }
        public int? TrackingNumber { get; set; }
        public int? Weigh { get; set; }
        public int? PassengerId { get; set; }

        public virtual Passenger? Passenger { get; set; }
    }
}
