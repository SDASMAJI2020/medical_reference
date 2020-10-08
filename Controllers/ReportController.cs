using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ERPMEDICAL.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult DailyStock()
        {
            return View();
        }
        public IActionResult MonthlyStock()
        {
            return View();
        }
        public IActionResult Purcahse()
        {
            return View();
        }
        public IActionResult Sales()
        {
            return View();
        }
        public async Task<IActionResult> Get()
        {
            var path = Path.Combine(
            Directory.GetCurrentDirectory(), "wwwroot\\pdf\\game2.pdf");

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/pdf", "Demo.pdf");
        }
    }
}
