using System.ComponentModel.DataAnnotations;

namespace AcademyCode.ModelsVM
{
    public class RegesterVM 
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [EmailAddress]
        [Compare("Email", ErrorMessage = "Email not match")]
        public string EmailConfirmed { get; set; }
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="pasword not match")]
        public string ConfirmPassword { get; set; }
    }
}
