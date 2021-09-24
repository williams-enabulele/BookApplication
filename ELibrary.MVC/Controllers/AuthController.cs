using Microsoft.AspNetCore.Mvc;
using ELibrary.MVC.Repository.Implementations;
using ELibrary.MVC.Model.DTO.RequestDTO;
using ELibrary.MVC.Repository.Interfaces;
using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ELibrary.MVC.Controllers
{
    
    public class AuthController : Controller
    {
      
        private readonly IAuth _auth;
        public AuthController(IAuth auth)
        {
            _auth = auth;
        }

      
        public IActionResult Login(LoginDTO loginDTO)
        {
            
            try
            {
                ViewBag["Email"] = loginDTO.Email;
                ViewBag["Password"] = loginDTO.Password;
                Debug.WriteLine(loginDTO.Email, loginDTO.Password);
                _auth.Login(loginDTO);
                return View(loginDTO);
             
            }
            catch (Exception ex)
            {
                return View(ex);
               
            }
           
        }



     
        
        public IActionResult Register(RegisterDTO registerDTO)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.FirstName = registerDTO.FirstName;
                ViewBag.LastName = registerDTO.LastName;
                ViewBag.Email = registerDTO.Email;
                ViewBag.Password = registerDTO.Password;
                //_auth.Register(registerDTO);
                return View();
            }

           
            return RedirectToAction("Login");
        }


        public IActionResult AdminLogin()
        {
            return View();
        }
    }
}