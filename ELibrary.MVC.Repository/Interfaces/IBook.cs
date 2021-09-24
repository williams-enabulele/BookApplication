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
    public interface IBook
    {
        public List<BookResponseDTO> GetAllBooks();
        public BookResponseDTO GetBookDetail(string Id);
        public BookResponseDTO AddNewBook(BookRequestDTO bookRequestDTO);
        public BookResponseDTO UpdateBook(BookRequestDTO bookRequestDTO);
        public HttpResponseMessage DeleteBook(string Id);
        public List<BookResponseDTO> SearchBook(string term);
    }
}
