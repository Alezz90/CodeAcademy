using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasse.Model
{
    public class Employee
    {

        [Key]
      //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Name must be 5 characters or more"), MaxLength(100)]
        public string Name { get; set; }
        
        public string Address { get; set; }

        [DataType(DataType.Currency)]
        public double salary { get; set; }


        [ForeignKey("Department")]
        //[Column(name:"DepartmentID")]
        public int? depID { get; set; }
       
        public Department? Department { get; set; }
        public List<Product> Products { get; set; }
    }
}
