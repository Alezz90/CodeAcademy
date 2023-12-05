using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    internal class OverUser
    {
        public int Mony { get; set; }
        // public int hours { get; set; }

        public OverUser(int m)
        {
            Mony = m;

        }

        public static int operator +(OverUser u, OverUser v)
        {
            int result = u.Mony + v.Mony;
            return result;
        }

        public static bool operator ==(OverUser u, OverUser v)
        {
            bool result = u.Mony == v.Mony;
            return result;
        }
     
        public static bool operator !=(OverUser u, OverUser v) => (u.Mony != v.Mony);

    }
}