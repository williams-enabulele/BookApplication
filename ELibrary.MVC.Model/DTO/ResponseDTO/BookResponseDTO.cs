﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.API.Model.DTO.ResponseDTO
{
    public class BookResponseDTO
    {
        public string SubCategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(50)]
        public string Author { get; set; }
        [Required]
        [StringLength(50)]
        public string Publisher { get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
        [Required]
        [StringLength(10)]
        public string ISBN { get; set; }
        [Required]
        [StringLength(150)]
        public string ThumbnailUrl { get; set; }
        [Required]
        [StringLength(150), DataType(DataType.Text)]
        public string ShortDescription { get; set; }
        [Required]
        [StringLength(500), DataType(DataType.Text)]
        public string LongDescription { get; set; }
        public SubCategoryResponseDTO SubCategory { get; set; }        
        public ICollection<RatingResponseDTO> Ratings { get; set; }
        public ICollection<ReviewResponseDTO> Reviews { get; set; }
    }
}
