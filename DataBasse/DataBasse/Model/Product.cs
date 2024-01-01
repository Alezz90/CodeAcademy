using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasse.Model
{
    public class Product
    {


        [Key]
        public int ProductId { get; set; }
        
        public string Product_Name { get; set; }
      
        public int stack { get; set; }
        [ForeignKey("EmpID")]
        public int EmpID { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
