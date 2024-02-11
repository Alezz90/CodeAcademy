using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeAcademyAPI.Model
{
    public class Todo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string? Description { get; set; }
        [Required(AllowEmptyStrings = true)]
        public Boolean? CheckDone { get; set; }
        [ForeignKey("Day Number")]
        public int DayNumber { get; set; }
       
    }
}
