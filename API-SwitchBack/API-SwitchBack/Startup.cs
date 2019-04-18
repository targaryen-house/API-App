using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using API_SwitchBack.Data;
using API_SwitchBack.Models.Interfaces;
using API_SwitchBack.Models.Service;
using Swashbuckle.AspNetCore.Swagger;

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
            options.UseSqlServer(Configuration["ConnectionStrings:ProductionConnection"]));

            services.AddDbContext<SwitchbackAPIDbContext>(options =>
            options.UseSqlServer(Configuration["BINGAPIKEY"]));
            services.AddScoped<IBingManager, BingService>();
            services.AddScoped<ITrail, TrailServices>();
            services.AddScoped<IGetTrails, GetTrailsService>();
            //DefaultConnection
            //ProdutionConnection

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();

        }
    }
}
