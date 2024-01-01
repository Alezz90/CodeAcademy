using System;
using System.Collections.Generic;

namespace Day20.Models
{
    public partial class AirportEmp
    {
        public int PersonalId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public string? ContactEmail { get; set; }
        public int? ContactNumber { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
    }
}
