using Microsoft.AspNetCore.Mvc;

namespace UserAuth_Template_AspNetCore.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Data = "test " + System.DateTime.Now;
            return View("Index");
        }
    }
}
