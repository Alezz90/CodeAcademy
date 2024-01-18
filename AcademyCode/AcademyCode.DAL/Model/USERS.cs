using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCode.DAL.Model
{
    public class USERS:IdentityUser
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
    }
}
