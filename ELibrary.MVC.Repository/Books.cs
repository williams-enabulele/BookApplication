using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;
using ELibrary.MVC.Repository.Implementations;
using ELibrary.MVC.Repository.Interfaces;
using ELibrary.API.Model.DTO.ResponseDTO;

namespace ELibrary.MVC.Repository
{
    public class Books
    {
        IConfiguration Configuration;
        private readonly IServiceRepository _serviceRepository;
       
        public Books(IConfiguration configuration, IServiceRepository serviceRepository)
        {
            Configuration = configuration;
            _serviceRepository = serviceRepository;
        }

        public async void GetAllBooks()
        {
            HttpResponseMaessage bookResults = _serviceRepository.GetResponse("api/showroom/getallproducts"));
            response.EnsureSuccessStatusCode();
            List<BookResponseDTO> products = response.Content.ReadAsAsync<List<Models.Product>>().Result;


        }

        
    }
}
   

