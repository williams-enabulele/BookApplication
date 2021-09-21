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
        public Books(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async void GetAllBooks()
        {
           
            List<string> EmpInfo = new List<string>();
            var client = new HttpClient();
            var baseUrl = Configuration.GetSection("BaseUrl").Value;
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage Res = await client.GetAsync("api/string/GetAllEmployees");
            if (Res.IsSuccessStatusCode)
            {
                var BookResponse = Res.Content.ReadAsStringAsync().Result;
                EmpInfo = JsonConvert.DeserializeObject<List<string>>(BookResponse);
            }

        }
    }
}
   

