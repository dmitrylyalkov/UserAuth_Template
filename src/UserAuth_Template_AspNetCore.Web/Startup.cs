using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using UserAuth_Template.ModelCore.Entities;

namespace UserAuth_Template_AspNetCore.Web
{
    public class Startup
    {
        //public IConfiguration AppConfiguration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(env.ContentRootPath)
            //    .AddJsonFile("appsettings.json");

            //AppConfiguration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddOptions();
            //services.Configure<Options>(AppConfiguration.GetSection("Data"));

            services.AddMvc()
                //Microsoft bug
                .AddRazorOptions(options =>
                {
                    var previous = options.CompilationCallback;
                    options.CompilationCallback = context =>
                    {
                        previous?.Invoke(context);
                        context.Compilation = context.Compilation.AddReferences(MetadataReference.CreateFromFile(typeof(User).Assembly.Location));
                    };
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();

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
