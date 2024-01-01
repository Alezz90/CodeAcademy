using System;
using System.Collections.Generic;

namespace Day20.Models
{
    public partial class Department
    {
        public Department()
        {
            AirportEmps = new HashSet<AirportEmp>();
        }

        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }

        public virtual ICollection<AirportEmp> AirportEmps { get; set; }
    }
}
