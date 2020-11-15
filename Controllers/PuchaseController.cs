using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreModel.Model;
using Microsoft.AspNetCore.Mvc;

namespace ERPMEDICAL.Controllers
{
    public class PuchaseController : Controller
    {
        private ErpMedical _Context;
        public PuchaseController(ErpMedical Context)
        {
            _Context = Context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vendor()
        {
            var vendor = _Context.Vendor.ToList();
            return View(vendor);
        }

        public IActionResult Item()
        {
            return View();
        }
    }
}
