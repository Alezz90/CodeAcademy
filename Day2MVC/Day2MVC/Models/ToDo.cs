using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day2MVC.Models
{
    public class ToDo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TODOID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }


    }
}
