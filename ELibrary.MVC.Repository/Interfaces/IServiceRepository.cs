using ELibrary.MVC.Model.DTO.RequestDTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.MVC.Repository.Interfaces
{
    public interface IServiceRepository
    {
        public HttpResponseMessage GetResponse(string url);
        public HttpResponseMessage PutResponse(string url, object model);
        public HttpResponseMessage PostResponse(string url, object model);
        public HttpResponseMessage DeleteResponse(string url);
        public HttpResponseMessage UploadResponse(string url, ImageRequestDTO model);

    }
}
