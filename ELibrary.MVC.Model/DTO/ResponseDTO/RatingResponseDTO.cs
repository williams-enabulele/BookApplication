using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.API.Model.DTO
{
    public class RatingResponseDTO
    {
        public string UserId { get; set; }
        public string BookId { get; set; }
        [Required]
        public double RatedValue { get; set; }
        public BookResponseDTO Book { get; set; }
        public UserResponseDTO User { get; set; }
    }
}
