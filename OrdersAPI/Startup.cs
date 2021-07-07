using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data; 
using OrdersAPI.Service.Interfaces;
using OrdersAPI.Service.Services;
using OrdersAPI.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MediatR;
using System.Reflection;
using OrdersAPI.Queries.Commands;

namespace OrdersAPI
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
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OrdersAPI V1", Version = "v1" });
            });

            services.AddMediatR(typeof(Startup));

            services.AddMediatR(typeof(Startup).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetOrderByIdQuery).GetTypeInfo().Assembly);

            services.AddTransient<IUnitOfWork, UnitOfWork>();
             
            services.AddTransient<ICustomersRepository, CustomersRepository>(); 
            services.AddTransient<IItemsRepository, ItemsRepository>(); 
            services.AddTransient<IOrdersRepository, OrdersRepository>(); 
            services.AddTransient<IProductsRepository, ProductsRepository>();
             
            services.AddTransient<ICustomersService, CustomersService>(); 
            //services.AddScoped<IItemsService, ItemsService>(); 
            services.AddTransient<IOrdersService, OrdersService>(); 
            services.AddTransient<IProductsService, ProductsService>();

            services.AddDbContext<EFContext>(options => options.UseSqlite(Configuration.GetConnectionString("OrdersAPIConnectionString")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "OrdersAPI V1");
                });
            }

            app.UseCors("AllowAll");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization(); 

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
