using System.Collections.Generic;
using System.Linq;
using DevCard_MVC.Models;

namespace DevCard_MVC.Data
{
    public class ProjectStore
    {
        public static List<Project> GetProjects()
        {
            return new List<Project>()
            {
                new(1, "تاکسی", "درخواست آنلاین تاکسی برای سفرهای درون شهری ", "Snapp", "project-1.jpg"),
                new(2, "زودفود", "درخواست آنلاین غذا برای سراسر کشور ", "ZoodFood", "project-2.jpg"),
                new(3, "مدارس", "سیتسم مدیریت یکپارچه مدارس ", "MONOP", "project-3.jpg"),
                new(4, "فضاپیما", "برنامه مدیریت فضاپیما های ناسا ", "NASSA", "project-4.jpg"),
            };
        }

        public static Project GetProjectBy(long id)
        {
            return GetProjects().FirstOrDefault(x => x.Id == id);
        }
    }
}