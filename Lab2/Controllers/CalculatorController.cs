﻿using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult Result(Calculator model)
        { if (!model.IsValid())
            {

                return View("Error");
            }
                return View(model);
            
        }
   
    }
}
