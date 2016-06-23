using System.Collections.Generic;
using UserAuth_Template.DataCore;
using UserAuth_Template.Model.Entities;

namespace UserAuth_Template.ManagersCore.Managers
{
    public interface IUserManager
    {
        IList<User> GetUsers(int count = 0);
    }

    public class UserManager : IUserManager
    {
        IUserRepo _userRepo;

        public UserManager()
        {
            _userRepo = new UserRepo();
        }

        public IList<User> GetUsers(int count = 0)
        {
            return _userRepo.GetUsers(count);
        }
    }
}
