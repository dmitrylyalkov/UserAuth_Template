using System.Collections.Generic;
using UserAuth_Template.ModelCore.Entities;

namespace UserAuth_Template_AspNetCore.Web.ViewModels
{
    public class UsersViewModel
    {
        public IList<User> Users { get; set; }
    }
}
