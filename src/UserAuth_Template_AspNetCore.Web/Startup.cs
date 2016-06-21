using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace UserAuth_Template_AspNetCore.Web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Index",
                    template: "",
                    defaults: new { controller = "Home", action = "Index" }
                );
                routes.MapRoute(
                    name: "Next",
                    template: "Test",
                    defaults: new { controller = "Home", action = "Test" }
                );
            });            
        }        
    }
}
