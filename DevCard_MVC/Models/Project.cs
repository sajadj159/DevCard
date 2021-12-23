using System.Collections.Generic;

namespace DevCard_MVC.Models
{
    public class Project
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Client { get; private set; }
        public string Image { get; private set; }

        public Project(long id, string name, string description, string client,string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Client = client;
            Image = image;
        }

        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new(1, "تاکسی", "درخواست آنلاین تاکسی برای سفرهای درون شهری ", "Snapp","project-1.jpg"),
                new(1, "زودفود", "درخواست آنلاین غذا برای سراسر کشور ", "ZoodFood","project-2.jpg"),
                new(1, "مدارس", "سیتسم مدیریت یکپارچه مدارس ", "MONOP","project-3.jpg"),
                new(1, "فضاپیما", "برنامه مدیریت فضاپیما های ناسا ", "NASSA","project-4.jpg"),
            };
        }
    }
}