using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace UserAuth_Template_AspNetCore.Web
{
    public class Startup
    {        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore()
                .AddViews()
                .AddRazorViewEngine();            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Index",
                    template: "",
                    defaults: new { controller = "Home", action = "Index" }
                );
            });            
        }
    }
}
