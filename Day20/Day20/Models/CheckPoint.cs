using System;
using System.Collections.Generic;

namespace Day20.Models
{
    public partial class CheckPoint
    {
        public int? CheackPointId { get; set; }
        public string? Locatio { get; set; }
        public int? StaffId { get; set; }
        public int? TerId { get; set; }
        public int? PassengerId { get; set; }

        public virtual Passenger? Passenger { get; set; }
        public virtual AirportEmp? Staff { get; set; }
        public virtual Terminal? Ter { get; set; }
    }
}
