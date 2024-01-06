using Day2MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Day2MVC.Data
{
    public class TODoContext : DbContext
    {
        public TODoContext(DbContextOptions<TODoContext> options) : base(options)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}

