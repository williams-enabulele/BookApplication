using ELibrary.MVC.Model.DTO.ResponseDTO;
using ELibrary.MVC.Model.DTO.RequestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.MVC.Repository.Interfaces
{
    public interface IMainCategory
    {
        public List<MainCategoryResponseDTO> GetAllCategory();
        public MainCategoryResponseDTO GetCategoryDetail(string Id);
        public MainCategoryResponseDTO AddNewCategory(MainCategoryRequestDTO bookRequestDTO);
        public MainCategoryResponseDTO UpdateCategory(MainCategoryRequestDTO bookRequestDTO);
        public HttpResponseMessage DeleteCategory(string Id);
    }
}
