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
    }
}