﻿using Microsoft.AspNetCore.Mvc;
using ProyectoTFG.Models;
using System.Diagnostics;


namespace ProyectoTFG.Controllers
{
    public class Management : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
