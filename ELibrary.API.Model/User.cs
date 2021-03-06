using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ELibrary.API.Model
{
    public class User : IdentityUser
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

        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}