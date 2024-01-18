using System.ComponentModel.DataAnnotations;

namespace AcademyCode.ModelsVM
{
    public class RegesterVM 
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="pasword not match")]
        public string ConfirmPassword { get; set; }
    }
}
