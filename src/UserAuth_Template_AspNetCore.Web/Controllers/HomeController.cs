using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using UserAuth_Template.ManagersCore.Managers;
using UserAuth_Template_AspNetCore.Web.ViewModels;

namespace UserAuth_Template_AspNetCore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<DataOptions> _dataOptions;

        private IUserManager _userManager;

        public HomeController(IOptions<DataOptions> dataOptions, IUserManager userManager)
        {
            _dataOptions = dataOptions;
            _userManager = userManager;
        }
                

        public IActionResult Index()
        {
            return View("Index");            
        }

        public IActionResult Test()
        {
            var users = _userManager.GetUsers(_dataOptions.Value.UserCount);

            return View("Test", new UsersViewModel { Users = users });
        }
    }
}
