using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MvOrders.Api.Interfaces;
using MvOrders.Api.services;
using MvOrders.Infrastructure;
using MvOrders.Infrastructure.Interfaces;
using MvOrders.Infrastructure.Repositories;
using Swashbuckle.AspNetCore.Swagger;

namespace MvOrders.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Zitro API",
                    Description = "API para pruebas curso NetCore",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Oswaldo Ortiz",
                        Email = "oro8528@gmail.com",
                        Url = "https://zitro.tech/"
                    },
                    License = new License
                    {
                        Name = "Use under LICX",
                        Url = "https://example.com/license"
                    }
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });


            #region Repositories
            services.AddScoped<IProductoRepository, ProductoRepository>();
            #endregion
            #region Services
            services.AddScoped<IProductoService, ProductoService>();
            #endregion

            #region EntityFramework

            string connectionString = Configuration.GetConnectionString("MovilVentasDB");

            services.AddDbContext<MvOrderContext>(options =>
              options
                  .UseSqlServer(connectionString, sqlOptions => {

                      sqlOptions.MigrationsAssembly("MvOrders.Api");
                  }));

            #endregion


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<MvOrderContext>();
                context.Database.EnsureCreated();
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseMvc();
        }
    }
}
