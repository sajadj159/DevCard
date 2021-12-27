using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DevCard_MVC.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var _services = Service.GetServices();
            var form = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(form);
        }

        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            var _services = Service.GetServices();
            form.Services = new SelectList(_services, "Id", "Name");
            if (ModelState.IsValid == false)
            {
                ViewBag.errore = "اطلاعات وارد شده صحیح نمی باشد. لطفا دوباره تلاش کنید";
                return View(form);
            }

            ModelState.Clear();
            form = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ViewBag.success = "پیغام شما با موفقیت ثبت شد :)";
            return View(form);
        }

        public IActionResult ProjectDetail(long id)
        {
            var project = ProjectStore.GetProjectBy(id);
            return View(project);
        }

        public IActionResult LatestArticleDetail(long id)
        {
            var latestArticle = LatestArticleStore.GetLatestArticleBy(id);
            return View(latestArticle);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}