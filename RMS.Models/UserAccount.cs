using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "**please enter the first name")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "FirstName must contain only letters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "**please enter the last name")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "LastName must contain only letters")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "**please enter the email")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "**please enter the phone Number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "**please enter the password ")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "**please confirm the Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
