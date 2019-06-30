﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksWebApp.Models;
using BusinessLayer;
using BusinessLayer.Implements;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer;

namespace BooksWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PublishingHouseContext>(
                options => options.UseSqlServer(_config.GetConnectionString("BooksConn")));

            services.AddTransient<IBookRepository, SqlBookRepository>();
            services.AddTransient<IAuthorRepository, SqlAuthorRepository>();
            services.AddTransient<IThemeRepository, SqlThemeRepository>();

            services.AddTransient<DataManager>();
            services.AddTransient<ServicesManager>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Error/{0}");

            }


            app.UseStaticFiles();
            app.UseMvc(
                routes => routes.MapRoute(
                    name: "default", template: "{controller=Home}/{action=Index}/{id?}"
            ));

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
