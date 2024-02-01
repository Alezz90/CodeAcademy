using System.ComponentModel.DataAnnotations;

namespace AcademyCode.ModelsVM
{
    public class ForgotPassword
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
