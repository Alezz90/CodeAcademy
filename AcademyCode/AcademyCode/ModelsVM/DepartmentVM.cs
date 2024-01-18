using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AcademyCode.DAL.Model;

namespace AcademyCode.ModelsVM
{
    public class DepartmentVM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50)]
        [MinLength(5)]
        public string Name { get; set; }
        public int numberOfemp { get; set; }
        ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    }
}
