using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Controllers
{
    public class LogeoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}