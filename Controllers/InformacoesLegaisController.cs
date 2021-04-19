using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication.Controllers
{
    public class InformacoesLegaisController
    {
        public InformacoesLegaisController(){
        }

        public IActionResult TermosDeUso()
        {   
            return View();
        }
        
        public IActionResult PoliticaDePrivacidade()
        {   
            return View();
        }
    }
}