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
    public interface IAuth
    {
        public HttpResponseMessage Register(UserRequestDTO userRequestDTO);
        public HttpResponseMessage Login(LoginDTO loginDTO);

    }
}
