using Microsoft.Extensions.DependencyInjection;
using UserAuth_Template.DataCore;
using UserAuth_Template.ManagersCore.Managers;

namespace UserAuth_Template.DICore
{
    public static class ServiceCollectionExt
    {
        public static IServiceCollection ConfigureDI(this IServiceCollection services, string connectionString = null)
        {
            services.AddScoped<IUserManager, UserManager>();

            services.AddScoped<IUserRepo, UserRepo>();

            services.AddScoped<Model_Context>(cs => new Model_Context(connectionString));

            return services;
        }
    }
}
