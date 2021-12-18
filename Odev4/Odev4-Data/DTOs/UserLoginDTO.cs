using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4_Data.DTOs
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage ="Email is must!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is must!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password confirmation is must!")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }
    }
}
