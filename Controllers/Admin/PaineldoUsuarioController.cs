using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplication.Views.Home;
namespace WebApplication.Controllers.Admin
{
    public class PaineldoUsuarioController
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}