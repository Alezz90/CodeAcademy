using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.DAL.Model
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50)]
        [MinLength(5)]
        public string Name { get; set; }
        public string MangerName { get; set; }

        public int numberOfemp { get; set; }
    }
}
