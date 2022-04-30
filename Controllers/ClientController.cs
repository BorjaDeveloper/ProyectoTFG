﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoTFG.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}