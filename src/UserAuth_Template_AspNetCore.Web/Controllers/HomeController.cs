using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using UserAuth_Template.ManagersCore.Managers;
using UserAuth_Template_AspNetCore.Web.ViewModels;

namespace UserAuth_Template_AspNetCore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<ConnectionOptions> _connectionOptions;
        private readonly IOptions<DataOptions> _dataOptions;


        public HomeController(IOptions<ConnectionOptions> connectionOptions, IOptions<DataOptions> dataOptions)
        {
            _connectionOptions = connectionOptions;
            _dataOptions = dataOptions;
        }
                

        public IActionResult Index()
        {
            return View("Index");            
        }

        public IActionResult Test()
        {
            var connection = _connectionOptions.Value.ConnectionString;
            var manager = new UserManager(connection);
            var users = manager.GetUsers(_dataOptions.Value.UserCount);

            return View("Test", new UsersViewModel { Users = users });
        }
    }
}
