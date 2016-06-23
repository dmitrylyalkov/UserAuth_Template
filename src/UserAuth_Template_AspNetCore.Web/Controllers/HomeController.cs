using Microsoft.AspNetCore.Mvc;
using UserAuth_Template.ManagersCore.Managers;
using UserAuth_Template_AspNetCore.Web.ViewModels;

namespace UserAuth_Template_AspNetCore.Web.Controllers
{
    public class HomeController : Controller
    {
        //IConfiguration _config;

        //public HomeController(IConfiguration configuration)
        //{
        //    _config = configuration;
        //}

        public IActionResult Index()
        {
            return View("Index");            
        }

        public IActionResult Test()
        {
            var manager = new UserManager();
            var users = manager.GetUsers();

            return View("Test", new UsersViewModel { Users = users });
        }
    }
}
