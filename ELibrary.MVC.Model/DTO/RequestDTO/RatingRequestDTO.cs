using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.MVC.Model.DTO.RequestDTO
{
    public class RatingRequestDTO
    {
        public string UserId { get; set; }
        public string BookId { get; set; }
        [Required]
        public double RatedValue { get; set; }
        public BookRequestDTO Book { get; set; }
        public UserRequestDTO User { get; set; }
    }
}
