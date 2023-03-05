using System.ComponentModel.DataAnnotations;

using EntityCodeFirstLab.Data;

namespace SimpleSchoolSystem.ViewModel
{
    public class UserRegisterViewModel : ApplicationUser
    {
        [Required]
        [MinLength(1)]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassoword { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
