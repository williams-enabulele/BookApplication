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
    public interface IRating
    {
        public List<RatingResponseDTO> GetAllRatings();
        public RatingResponseDTO GetRatingDetail(string Id);
        public RatingResponseDTO AddNewRating(RatingRequestDTO rating);
        public RatingResponseDTO UpdateRating(RatingRequestDTO ratingRequest);
        public HttpResponseMessage DeleteRating(string Id);
    }
}
