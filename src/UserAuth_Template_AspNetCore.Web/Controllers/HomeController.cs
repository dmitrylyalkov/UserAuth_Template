using Microsoft.AspNetCore.Mvc;

namespace UserAuth_Template_AspNetCore.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");            
        }

        public IActionResult Test()
        {
            return View("Test");
        }
    }
}
