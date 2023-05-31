using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyntraApp
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
            services.AddControllersWithViews();
            services.AddTransient<IuserRL,UserRL>();
            services.AddTransient<IuserBL,UserBL>();
            services.AddTransient<IAddressBL,AddressBL>();
            services.AddTransient<IAddressRL,AddressRL>();
            services.AddTransient<IRestaurantRL,RestaurantRL>();
            services.AddTransient<IRestaurantBL,RestaurantBL>();
            services.AddSession(opt =>
           {
               opt.IdleTimeout = TimeSpan.FromMinutes(120);
               opt.Cookie.HttpOnly = true;
               opt.Cookie.IsEssential = true;
           });

             
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=User}/{action=HomePage}/{id?}/{name?}");

                //endpoints.MapControllers();
            });
            
        }
    }
}
