using System.Data.Entity;
using UserAuth_Template.Model.Entities;

namespace UserAuth_Template.Data
{
    public class Model_Context : DbContext
    {
        public DbSet<User> Users { get; set; }

        public Model_Context() : base("Data Source=localhost;Initial Catalog=UserAuthTest;User ID=sa;Password=test; MultipleActiveResultSets=True;")
        {
        }
    }
}
