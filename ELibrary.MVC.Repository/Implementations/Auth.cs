using ELibrary.MVC.Model.DTO.RequestDTO;
using ELibrary.MVC.Model.DTO.ResponseDTO;
using ELibrary.MVC.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.MVC.Repository.Implementations
{
    public class Auth : IAuth
    {
        private readonly IServiceRepository _serviceRepository;
        public Auth(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public HttpResponseMessage Login(LoginDTO loginDTO)
        {
            HttpResponseMessage response = _serviceRepository.PostResponse("Auth/AddNew",loginDTO);
            response.EnsureSuccessStatusCode();
            HttpResponseMessage login = response.Content.ReadAsAsync<HttpResponseMessage>().Result;
            return login;
        }

        public HttpResponseMessage Register(UserRequestDTO userRequestDTO)
        {
            HttpResponseMessage response = _serviceRepository.PostResponse("Auth/AddNew", userRequestDTO);
            response.EnsureSuccessStatusCode();
            HttpResponseMessage register = response.Content.ReadAsAsync<HttpResponseMessage>().Result;
            return register;
        }
    }
}
