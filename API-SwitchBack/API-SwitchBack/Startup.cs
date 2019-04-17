﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using API_SwitchBack.Data;
using API_SwitchBack.Models.Interfaces;
using API_SwitchBack.Models.Service;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Http;
using API_SwitchBack.Models.Services;

namespace API_SwitchBack
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();


            services.AddDbContext<SwitchbackAPIDbContext>(options =>
            options.UseSqlServer(Configuration["ConnectionStrings:ProdutionConnection"]));
            services.AddScoped<IBingManager, BingService>();
            services.AddScoped<ITrail, TrailServices>();
            services.AddScoped<IGetTrails, GetTrailsService>();
            //DefaultConnection
            //ProdutionConnection
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();


        }
    }
}
