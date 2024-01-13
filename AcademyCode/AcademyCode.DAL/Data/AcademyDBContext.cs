using AcademyCode.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCode.DAL.Data
{
    public class AcademyDBContext : DbContext
    {
        public AcademyDBContext(DbContextOptions<AcademyDBContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Department { get; set; }
    }
}
