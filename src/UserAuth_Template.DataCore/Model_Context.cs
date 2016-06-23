using Microsoft.EntityFrameworkCore;
using UserAuth_Template.ModelCore.Entities;

namespace UserAuth_Template.DataCore
{
    public class Model_Context : DbContext
    {
        public DbSet<User> Users { get; set; }

        public Model_Context() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=UserAuthTest;User ID=sa;Password=test; MultipleActiveResultSets=True;");
        }
    }
}
