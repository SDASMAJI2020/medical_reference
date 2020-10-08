using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ERPMEDICAL.Controllers
{
    public class PuchaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vendor()
        {
            return View();
        }

        public IActionResult Item()
        {
            return View();
        }
    }
}
