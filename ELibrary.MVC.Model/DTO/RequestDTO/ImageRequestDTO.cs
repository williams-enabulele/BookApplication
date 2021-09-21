using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.MVC.Model.DTO.RequestDTO
{
    public class ImageRequestDTO
    {
        public IFormFile Image { get; set; }
    }
}
