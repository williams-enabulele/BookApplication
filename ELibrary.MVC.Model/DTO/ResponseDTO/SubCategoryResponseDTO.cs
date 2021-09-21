using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.API.Model.DTO
{
    public class SubCategoryResponseDTO
    {
        public string MainCategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(150), DataType(DataType.Text)]
        public string Description { get; set; }
        public MainCategoryResponseDTO MainCategory { get; set; }
        public ICollection<BookResponseDTO> Books { get; set; }
    }
}
