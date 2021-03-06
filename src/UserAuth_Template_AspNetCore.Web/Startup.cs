﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserAuth_Template.DICore;
using UserAuth_Template.ModelCore.Entities;

namespace UserAuth_Template_AspNetCore.Web
{
    public class Startup
    {
        public IConfiguration AppConfiguration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json");

            AppConfiguration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            //services.Configure<ConnectionOptions>(AppConfiguration.GetSection("Connection"));
            services.Configure<DataOptions>(AppConfiguration.GetSection("Data"));

            services.ConfigureDI(AppConfiguration.GetValue<string>("Connection:ConnectionString"));

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
        /*ASP.NET 5 предоставляет следующие встроенные компоненты middleware:
            Authentication: предоставляет поддержку аутентификации
            CORS: обеспечивает поддержку кроссдоменных запросов
            Diagnostics: предоставляет страницы ошибок и некоторую информацию выполнения запроса
            Routing: определяет маршруты, используемые в приложении
            Session: предоставляет поддержку сессий
            Static Files: предоставляет поддержку обработки статических файлов
         */
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();

            app.UseMvc(ConfigureRoutes);            
        }

        private void ConfigureRoutes(IRouteBuilder routes)
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
            routes.MapRoute(
                name: "GetItems",
                template: "GetItems",
                defaults: new { controller = "Home", action = "GetItems" }
            );            
        }        
    }
}
