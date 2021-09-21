using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.API.Model.DTO
{
    public class UserDTO : IdentityUser
    {

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string ImageUrl { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [StringLength(25)]
        public string Password { get; set; }
        public ICollection<RatingDTO> Ratings { get; set; }
        public ICollection<ReviewDTO> Reviews { get; set; }

    }
}
