using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.API.Model
{
    public class Rating : BaseModel
    {
        public string UserId { get; set; }
        public string BookId { get; set; }
        [Required]
        public double RatedValue { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
    }
}
