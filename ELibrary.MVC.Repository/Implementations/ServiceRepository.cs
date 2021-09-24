using ELibrary.MVC.Model.DTO.RequestDTO;
using ELibrary.MVC.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Net.Http;

namespace ELibrary.MVC.Repository.Implementations
{
    public class ServiceRepository : IServiceRepository
    {
        IConfiguration Configuration;
        public HttpClient Client { get; set; }
        
        public ServiceRepository()
        {
            //string baseUrl = Configuration.GetSection("BaseUrl").Value;
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://wwww.facebook.com/");
        }

        public HttpResponseMessage GetResponse(string url, string token = null)
        {
            if (token!=null)
            {
                if (token != null)
                {
                    Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                }
            }
            return Client.GetAsync(url).Result;
        }

        public HttpResponseMessage PutResponse(string url, object model, string token= null)
        {
            if (token != null)
            {
                if (token != null)
                {
                    Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                }
            }
            return Client.PutAsJsonAsync(url, model).Result;
        }

        public HttpResponseMessage PostResponse(string url, object model, string token = null)
        {
            if (token != null)
            {
                if (token != null)
                {
                    Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                }
            }
            return Client.PostAsJsonAsync(url, model).Result;
        }

        public HttpResponseMessage DeleteResponse(string url, string token = null)
        {
            if (token != null)
            {
                if (token != null)
                {
                    Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                }
            }
            return Client.DeleteAsync(url).Result;
        }

        public HttpResponseMessage UploadResponse(string url, HttpContent model, string token = null)
        {
            if (token != null)
            {
                if (token != null)
                {
                    Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                }
            }
            return Client.PatchAsync(url, model).Result;
        }

        
    }
}