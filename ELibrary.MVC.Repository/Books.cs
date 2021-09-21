using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;

namespace ELibrary.MVC.Repository
{
    public class Books
    {
        IConfiguration Configuration;
        private HttpClient _client;
        public Books(IConfiguration configuration, HttpClient httpClient)
        {
            Configuration = configuration;
            _client = httpClient;
        }

        public async void GetAllBooks()
        {
           
            List<string> EmpInfo = new List<string>();
            var baseUrl = Configuration.GetSection("BaseUrl").Value;
            _client.BaseAddress = new Uri(baseUrl);
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage Res = await _client.GetAsync("api/string/GetAllEmployees");
            if (Res.IsSuccessStatusCode)
            {
                var BookResponse = Res.Content.ReadAsStringAsync().Result;
                EmpInfo = JsonConvert.DeserializeObject<List<string>>(BookResponse);
            }

        }

        
    }
}
   

