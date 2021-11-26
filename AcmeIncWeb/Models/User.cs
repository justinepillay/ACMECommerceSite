using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AcmeIncWeb.Models
{
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
            Orders = new HashSet<Order>();
        }

        
        public int UserId { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Please ensure email is in the correct format.")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Passwords must contain a lowercase and uppercase letter, a number and a special character.")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string Fname { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string Lname { get; set; }

        [Display(Name = "Role")]
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
