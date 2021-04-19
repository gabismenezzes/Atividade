using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication.Controllers
{
    public class AjudaController
    {
        public AjudaController(){
        }

        public IActionResult Index()
        {   
            return View();
        }
    }
}