using System.ComponentModel.DataAnnotations;

namespace AcademyCode.ModelsVM
{
    public class ResetBasword
    {
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "pasword not match")]
        public string ConfirmPassword { get; set; }
        public string Token{ get; set;}
    }
}
