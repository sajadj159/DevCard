using System.Collections.Generic;
using System.Linq;
using DevCard_MVC.Models;

namespace DevCard_MVC.Data
{
    public class LatestArticleStore
    {
        public static List<LatestArticle> GetLatestArticles()
        {
            return new List<LatestArticle>
            {
                new(1, "آموزش Asp.net core mvc", "کاملترین پکیج آموزش Asp.net core mvc به زبان فارسی ",
                    "blog-post-thumb-card-1.jpg"),
                new(2, "آموزش Git  & Github", "کاملترین پکیج آموزش Git & Github به زبان فارسی ",
                    "blog-post-thumb-card-2.jpg"),
                new(3, "آموزش Onion Architecture", "کاملترین پکیج آموزش Onion Architecture به زبان فارسی ",
                    "blog-post-thumb-card-3.jpg"),
                new(4, "آموزش طراحی سایت", "کاملترین پکیج آموزش طراحی سایت به زبان فارسی",
                    "blog-post-thumb-card-4.jpg")
            };
        }

        public static LatestArticle GetLatestArticleBy(long id)
        {
            return GetLatestArticles().FirstOrDefault(x => x.Id == id);
        }
    }
}