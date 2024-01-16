using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCode.DAL.Model
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }
        public string phoncontact { get; set; }

        public DateTime Datestart { get; set; }

        public int? DepartmentID { get; set; }
        public Department Department { get; set; }
    }
}
