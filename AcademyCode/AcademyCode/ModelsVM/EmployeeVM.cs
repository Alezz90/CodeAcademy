using AcademyCode.DAL.Model;
using System.ComponentModel.DataAnnotations;

namespace AcademyCode.ModelsVM
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }
        public string phoncontact { get; set; }
        public string? ImagePath { get; set; } = null;
        public IFormFile formFile { get; set; }

        public DateTime Datestart { get; set; }

        public int? DepartmentID { get; set; }
        public Department Department { get; set; }
    }
}
