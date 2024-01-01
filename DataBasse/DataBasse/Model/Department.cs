using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasse.Model
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(20), MinLength(5)]
        public string Dep_Name { get; set; }
        [Range(1,4)]
        public string? Floor { get; set; }// ? تسمح بالمجهول في ادخال البيانات
       public List<Employee> Employees { get; set; }=new List<Employee>();
       
    }
}
