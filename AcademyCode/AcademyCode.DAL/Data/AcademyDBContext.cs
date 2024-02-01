using AcademyCode.DAL.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCode.DAL.Data
{
    public class AcademyDBContext : IdentityDbContext<USERS>
    {
        public AcademyDBContext(DbContextOptions<AcademyDBContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Department { get; set; }

       // public DbSet<USERS> USERS { get;set; }
    }
}
