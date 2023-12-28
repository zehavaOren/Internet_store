using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entity
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "The First name is Required"), MinLength(5)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "The Password is Required")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "The Last name is Required"),MinLength(5)]
        public string Lastname { get; set; } = null!;

        [EmailAddress(ErrorMessage = "The Email is not valid")]
        public string Email { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
