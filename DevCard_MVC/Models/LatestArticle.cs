using System.Collections.Generic;

namespace DevCard_MVC.Models
{
    public class LatestArticle
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }

        public LatestArticle(long id, string title, string description, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
        }

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
    }
}