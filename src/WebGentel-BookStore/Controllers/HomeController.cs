using Microsoft.AspNetCore.Mvc;

namespace WebGentel_BookStore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string CustomProp { get; set; }
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
