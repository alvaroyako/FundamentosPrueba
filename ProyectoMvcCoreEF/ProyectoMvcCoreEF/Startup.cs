using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProyectoMvcCoreEF.Data;
using ProyectoMvcCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcCoreEF
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
            string cadenaSqlServer = this.Configuration.GetConnectionString("cadenahospitalsql");
            string cadenaMySql = this.Configuration.GetConnectionString("cadenahospitalmysql");
            DepartamentosContextMySql contextMySql = new DepartamentosContextMySql(cadenaMySql);
            services.AddTransient<IDepartamentosContext>(z => contextMySql);
            
            //Vamos a instanciar un objeto y lo enviamos creado desde aqui
            Deportivo deportivo = new Deportivo();
            deportivo.Marca = "Ninguna";
            deportivo.Modelo = "Invisible";
            deportivo.Imagen = "invisible.jpg";
            deportivo.VelocidadMaxima = 999;
            services.AddSingleton<ICoche>(z=>new Deportivo("Simpson","HomerCoche","homer.jpg",420));
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
