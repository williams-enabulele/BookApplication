using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.MVC.Model.DTO.RequestDTO
{
    public class RegisterDTO
    {   

        
   
    public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(45,ErrorMessage ="Name entered is above the maximum letters allowed")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Select Gender")]
        public string Gender { get; set; }
        [EmailAddress(ErrorMessage = "Email field is required")]
        [Required(ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
        [NotMapped]
        [Compare("Password", ErrorMessage = "Password doesn't match.")]
        [Required(ErrorMessage = "Field cannot be left empty")]
        public string ConfirmPassword { get; set; }
    }
}
