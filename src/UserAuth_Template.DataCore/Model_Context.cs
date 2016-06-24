using Microsoft.EntityFrameworkCore;
using UserAuth_Template.ModelCore.Entities;

namespace UserAuth_Template.DataCore
{
    public class Model_Context : DbContext
    {
        string _connectionStr;      //"Data Source=localhost;Initial Catalog=UserAuthTest;User ID=sa;Password=test; MultipleActiveResultSets=True;"

        public DbSet<User> Users { get; set; }

        
        public Model_Context() : base()
        {            
        }

        public Model_Context(string connectionString) : this()
        {
            _connectionStr = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!string.IsNullOrEmpty(_connectionStr))
                optionsBuilder.UseSqlServer(_connectionStr);
        }
    }
}
