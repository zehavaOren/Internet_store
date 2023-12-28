using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO 
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string Lastname { get; set; } = null!;

        [Required(ErrorMessage = "The Email is Required")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "The Password is Required")]
        public string Password { get; set; } = null!;
    }
}
