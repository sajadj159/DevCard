using System;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var form = new Contact();
            return View(form);
        }

        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            
            Console.WriteLine(form);
            return Json(Ok());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}