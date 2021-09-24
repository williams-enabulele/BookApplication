using System.ComponentModel.DataAnnotations;

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