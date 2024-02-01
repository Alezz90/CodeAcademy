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
       
        [MaxLength(50)]

        public string Name { get; set; }
        public string phoncontact { get; set; }

        //[Required(AllowEmptyStrings = true)]
        public string? ImagePath { get; set; }
       // [EmailAddress]
      //  public string? Email { get; set; }

        public DateTime Datestart { get; set; }

        public int? DepartmentID { get; set; }
        public Department Department { get; set; }
    }
}
