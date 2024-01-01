using System;
using System.Collections.Generic;

namespace Day20.Models
{
    public partial class Passenger
    {
        public Passenger()
        {
            Baggages = new HashSet<Baggage>();
        }

        public int PassengerId { get; set; }
        public int? PassengerPasspoertNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? YearBirth { get; set; }
        public string? Gender { get; set; }
        public string? ContactEmail { get; set; }
        public int? ContactPhone { get; set; }
        public int? Capacity { get; set; }
        public int? FlightNo { get; set; }

        public virtual Flight? FlightNoNavigation { get; set; }
        public virtual ICollection<Baggage> Baggages { get; set; }
    }
}
