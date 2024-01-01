using System;
using System.Collections.Generic;

namespace Day20.Models
{
    public partial class Terminal
    {
        public int TerId { get; set; }
        public string? TerName { get; set; }
        public string? Locatio { get; set; }
        public int? Capcity { get; set; }
        public int? GateId { get; set; }

        public virtual Gate? Gate { get; set; }
    }
}
