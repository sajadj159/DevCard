using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent  :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var latestArticles = LatestArticle.GetLatestArticles();
            return View("_LatestArticels",latestArticles);
        }
    }
}