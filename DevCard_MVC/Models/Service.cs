using System.Collections.Generic;

namespace DevCard_MVC.Models
{
    public class Service
    {
        public long Id { get; private set; }
        public string Name { get; private set; }

        public Service(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public static List<Service> GetServices()
        {
            return new List<Service>()
            {
                new(1, "نقره ای"),
                new(2, "طلایی"),
                new(3, "پلاتین"),
                new(4, "الماس")

            };
        }
    }
}