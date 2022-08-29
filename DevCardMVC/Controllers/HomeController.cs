using DevCardMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevCardMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new ContactForm();
            return View(model);
        }

        // [HttpPost]
        // public JsonResult Contact(IFormCollection form)
        // {
        //     var name = form["name"];
        //     return Json(Ok());
        // }

        public JsonResult Contact(ContactForm form)
        {
            Console.WriteLine(form.ToString());
            return Json(Ok());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}