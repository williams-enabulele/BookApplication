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
    public interface IReview
    {
        public List<ReviewResponseDTO> GetAllReviews();
        public ReviewResponseDTO GetReviewDetail(string Id);
        public ReviewResponseDTO AddNewRating(ReviewRequestDTO rating);
        public ReviewResponseDTO UpdateReview(ReviewRequestDTO ratingRequest);
        public HttpResponseMessage DeleteReview(string Id);
    }
}
