using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuongLeHoi.BAL.Interface;
using TuongLeHoi.BAL.Service;
using TuongLeHoi.DAL.Interface;
using TuongLeHoi.DAL.Repository;

namespace TuongLeHoi
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

            services.AddTransient<IKieuDuLieuRepository, KieuDuLieuRepository>();
            services.AddTransient<IKieuDuLieuService, KieuDuLieuService>();
            services.AddTransient<ILoaiTuLieuRepository, LoaiTuLieuRepository>();
            services.AddTransient<ILoaiTuLieuService, LoaiTuLieuService>();
            services.AddTransient<ILuocDoDuLieuRepository, LuocDoDuLieuRepository>();
            services.AddTransient<ILuocDoDuLieuService, LuocDoDuLieuService>();
            services.AddTransient<INhomThuocTinhRepository, NhomThuocTinhRepository>();
            services.AddTransient<INhomThuocTinhService, NhomThuocTinhService>();
            services.AddTransient<IThongTinMoTaRepository, ThongTinMoTaRepository>();
            services.AddTransient<IThongTinMoTaService, ThongTinMoTaService>();
            services.AddTransient<IThuocTinhRepository, ThuocTinhRepository>();
            services.AddTransient<IThuocTinhService, ThuocTinhService>();
            services.AddTransient<ITuLieuRepository, TuLieuRepository>();
            services.AddTransient<ITuLieuService, TuLieuService>();
            services.AddTransient<IThongTinTuLieuRepository, ThongTinTuLieuRepository>();
            services.AddTransient<IThongTinTuLieuService, ThongTinTuLieuService>();
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

                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
