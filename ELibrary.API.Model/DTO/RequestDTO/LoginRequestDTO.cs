﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.API.Model.DTO.RequestDTO
{
    public class LoginRequestDTO
    {
        public string Email { get; set; }
        public string Passoord { get; set; }
    }
}
