using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabinBende.Business.Abstract;
using KitabinBende.Business.Concrete;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace KitabinBende.MvcWeb
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAuthorTypeService, AuthorTypeManager>();
            services.AddScoped<IAuthorTypeDal, EfAuthorTypeDal>();
            services.AddScoped<IAuthorService, AuthorManager>();
            services.AddScoped<IAuthorDal, EfAuthorDal>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
            
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

        }
    }
}
