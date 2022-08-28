using DevCardMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCardMVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی برای سفر های درون شهری", "Snapp","project-1.jpg"),
                new Project(2, "زود فود", "درخواست آنلاین غذا برای سرار کشور", "ZoodFood","project-2.jpg"),
                new Project(3, "مدارس", "سیستم یکپارچه مدیریت مدارس در سراسر کشور", "SchoolManagment","project-3.jpg"),
                new Project(4, "فضاپیما", "سفر به کره ماه", "NASA","project-4.jpg"),
            };
            return View("_Projects", projects);
        }
    }
}
