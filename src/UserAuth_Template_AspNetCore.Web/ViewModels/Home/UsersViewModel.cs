using System.Collections.Generic;
using UserAuth_Template.Model.Entities;

namespace UserAuth_Template_AspNetCore.Web.ViewModels
{
    public class UsersViewModel
    {
        public IList<User> Users { get; set; }
    }
}
