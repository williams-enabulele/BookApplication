using ELibrary.MVC.Model.DTO.ResponseDTO;
using ELibrary.MVC.Repository.Interfaces;
using System.Collections.Generic;
using System.Net.Http;

namespace ELibrary.MVC.Repository
{
    public class User : IUser
    {
        private readonly IServiceRepository _serviceRepository;

        public User(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public UserResponseDTO AddNewUser(UserRequestDTO userRequestDTO)
        {
            HttpResponseMessage response = _serviceRepository.PostResponse("User/AddNew", userRequestDTO);
            response.EnsureSuccessStatusCode();
            UserResponseDTO user = response.Content.ReadAsAsync<UserResponseDTO>().Result;
            return user;
        }

        public HttpResponseMessage DeleteUser(string Id)
        {
            HttpResponseMessage response = _serviceRepository.DeleteResponse("User/Delete?Id=" + Id);
            response.EnsureSuccessStatusCode();
            return response;
        }

        public List<UserResponseDTO> GetAllUsers()
        {
            HttpResponseMessage results = _serviceRepository.GetResponse("User/GetAll");
            results.EnsureSuccessStatusCode();
            List<UserResponseDTO> user = results.Content.ReadAsAsync<List<UserResponseDTO>>().Result;
            return user;
        }

        public UserResponseDTO GetUserDetail(string Id)
        {
            HttpResponseMessage response = _serviceRepository.GetResponse("User/GetUser?id=" + Id);
            response.EnsureSuccessStatusCode();
            UserResponseDTO user = response.Content.ReadAsAsync<UserResponseDTO>().Result;
            return user;
        }

        public UserResponseDTO UpdateUser(UserRequestDTO userRequestDTO)
        {
            HttpResponseMessage response = _serviceRepository.PutResponse("Review/Update", userRequestDTO);
            response.EnsureSuccessStatusCode();
            UserResponseDTO user= response.Content.ReadAsAsync<UserResponseDTO>().Result;
            return user;
        }
    }
}