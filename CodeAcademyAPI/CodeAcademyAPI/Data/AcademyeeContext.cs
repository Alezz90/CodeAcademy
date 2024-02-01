using CodeAcademyAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademyAPI.Data
{
    public class AcademyeeContext: DbContext
    {
        public AcademyeeContext(DbContextOptions<AcademyeeContext> options) : base(options)
        {

        }
        public DbSet<Todo>ToDo { get; set; }
    }
}
