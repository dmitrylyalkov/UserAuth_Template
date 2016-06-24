using System;
using System.Collections.Generic;
using UserAuth_Template.DataCore;
using UserAuth_Template.ModelCore.Entities;

namespace UserAuth_Template.ManagersCore.Managers
{
    public interface IUserManager
    {
        IList<User> GetUsers(int count = 0);
    }

    public class UserManager : IUserManager
    {
        IUserRepo _userRepo;
        
        public UserManager(String connection = null)
        {
            _userRepo = new UserRepo(connection);
        }

        public IList<User> GetUsers(int count = 0)
        {
            return _userRepo.GetUsers(count);
        }
    }
}
