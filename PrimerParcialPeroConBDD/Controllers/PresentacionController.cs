using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialPeroConBDD.Controllers
{
    public class PresentacionController : Controller
    {
        public IActionResult Bienvenido()
        {
            return View();
        }
    }
}
