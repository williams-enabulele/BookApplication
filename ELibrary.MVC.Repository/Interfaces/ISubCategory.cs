using ELibrary.MVC.Model.DTO;
using ELibrary.MVC.Model.DTO.RequestDTO;
using ELibrary.MVC.Model.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.MVC.Repository.Interfaces
{
    public interface ISubCategory
    {
        public List<SubCategoryResponseDTO> GetAllSubCategory();
        public SubCategoryResponseDTO GetSubCategoryDetail(string Id);
        public SubCategoryResponseDTO AddNewCategory(SubCategoryRequestDTO rating);
        public SubCategoryResponseDTO UpdateSubCategory(SubCategoryRequestDTO ratingRequest);
        public HttpResponseMessage DeleteSubCategory(string Id);
    }
}
