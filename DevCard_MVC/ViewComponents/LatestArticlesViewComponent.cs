using DevCard_MVC.Data;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent  :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var latestArticles = LatestArticleStore.GetLatestArticles();
            return View("_LatestArticles",latestArticles);
        }
    }
}