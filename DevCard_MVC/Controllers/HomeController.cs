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
            if (ModelState.IsValid==false)
            {
                ViewBag.errore = "اطلاعات وارد شده صحیح نمی باشد. لطفا دوباره تلاش کنید";
                return View(form);
            }

            ViewBag.success = "پیغام شما با موفقیت ثبت شد :)";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}