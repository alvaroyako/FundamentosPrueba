 using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvcCoreMultiplesBBDD.Data;
using MvcCoreMultiplesBBDD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMultiplesBBDD
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
            string cadenaoracle = this.Configuration.GetConnectionString("hospitaloracle");
            string cadenasql = this.Configuration.GetConnectionString("hospitalsqlserver");
            string cadenamysql = this.Configuration.GetConnectionString("hospitalmysql");
            
            //services.AddDbContext<HospitalContext>(options => options.UseSqlServer(cadenasql));
            //services.AddDbContext<HospitalContext>(options=>options.UseOracle(cadenaoracle, options => options
            //.UseOracleSQLCompatibility("11")));
            services.AddDbContext<HospitalContext>(options => options.UseMySQL(cadenamysql));

            services.AddTransient<IRepositoryEmpleados, RepositoryEmpleadosMySql>();

            services.AddControllersWithViews();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
