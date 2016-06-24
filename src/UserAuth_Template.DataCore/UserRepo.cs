using System.Collections.Generic;
using System.Linq;
using UserAuth_Template.ModelCore.Entities;

namespace UserAuth_Template.DataCore
{
    public interface IUserRepo
    {
        IList<User> GetUsers(int count = 0);
    }

    public class UserRepo : IUserRepo
    {
        Model_Context _context;

        public UserRepo(string connection = null)
        {
            _context = new Model_Context(connection);
        }

        public IList<User> GetUsers(int count = 0)
        {
            return _context.Users.Take(count == 0 ? 100 : count).ToList();
        }
    }
}
