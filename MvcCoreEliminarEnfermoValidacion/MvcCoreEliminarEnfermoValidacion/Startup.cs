using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvcCoreEliminarEnfermoValidacion.Data;
using MvcCoreEliminarEnfermoValidacion.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEliminarEnfermoValidacion
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
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme =
                CookieAuthenticationDefaults.AuthenticationScheme;

                options.DefaultAuthenticateScheme =
                CookieAuthenticationDefaults.AuthenticationScheme;

                options.DefaultChallengeScheme =
                CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie();

            String cadena = this.Configuration.GetConnectionString("cadenasql");
            services.AddTransient<RepositoryEnfermos>();
            services.AddDbContext<EnfermosContext>(options => options.UseSqlServer(cadena));
            
            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
            
            services.AddControllersWithViews
                (options => options.EnableEndpointRouting = false)
                .AddSessionStateTempDataProvider();
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

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
