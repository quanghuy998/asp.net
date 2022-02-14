using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using QuanLyDaoTao.API.System;
using QuanLyDaoTao.BAL.Account;
using QuanLyDaoTao.BAL.Interface;
using QuanLyDaoTao.BAL.Service;
using QuanLyDaoTao.DAL.Interface;
using QuanLyDaoTao.DAL.Repository;
using QuanLyDaoTao.Domain.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.API
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

            services.AddDbContext<AccountDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("WebAppDbContextConnection")));

            services.AddDefaultIdentity<AppUser>()
                       .AddEntityFrameworkStores<AccountDbContext>() // Thêm triển khai EF lưu trữ thông tin về Idetity (theo AppDbContext -> MS SQL Server).
                       .AddDefaultTokenProviders(); // Thêm Token Provider - nó sử dụng để phát sinh token (reset password, confirm email ...)


            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddTransient<IUserService, UserService>();

            services.AddTransient<IBangDiemService, BangDiemService>();
            services.AddTransient<IBangDiemRepository, BangDiemRepository>();
            services.AddTransient<IBaoLuuService, BaoLuuService>();
            services.AddTransient<IBaoLuuRepository, BaoLuuRepository>();
            services.AddTransient<IBoTriPHService, BoTriPHService>();
            services.AddTransient<IBoTriPHRepository, BoTriPHRepository>();
            services.AddTransient<IChuongTrinhDaoTaoService, ChuongTrinhDaoTaoService>();
            services.AddTransient<IChuongTrinhDaoTaoRepository, ChuongTrinhDaoTaoRepository>();
            services.AddTransient<IDMMonHocService, DMMonHocService>();
            services.AddTransient<IDMMonHocRepository, DMMonHocRepository>();
            services.AddTransient<IFileUploadService, FileUploadService>();
            services.AddTransient<IFileUploadRepository, FileUploadRepository>();
            services.AddTransient<IGiangVienService, GiangVienService>();
            services.AddTransient<IGiangVienRepository, GiangVienRepository>();
            services.AddTransient<IHocVienService, HocVienService>();
            services.AddTransient<IHocVienRepository, HocVienRepository>();
            services.AddTransient<IKhungCTService, KhungCTService>();
            services.AddTransient<IKhungCTRepository, KhungCTRepository>();
            services.AddTransient<IKhungGioHocService, KhungGioHocService>();
            services.AddTransient<IKhungGioHocRepository, KhungGioHocRepository>();
            services.AddTransient<ILophocRepository, LopHocRepository>();
            services.AddTransient<ILopHocService, LopHocService>();
            services.AddTransient<IMonHocRepository, MonHocRepository>();
            services.AddTransient<IMonHocService, MonHocService>();
            services.AddTransient<IPhongHocService, PhongHocService>();
            services.AddTransient<IPhongHocRepository, PhongHocRepository>();
            services.AddTransient<IQLChungChiService, QLChungChiService>();
            services.AddTransient<IQLChungChiRepository, QLChungChiRepository>();
            services.AddTransient<IThiCuService, ThiCuService>();
            services.AddTransient<IThiCuRepository, ThiCuRepository>();
            services.AddTransient<IThoiKhoaBieuService, ThoiKhoaBieuService>();
            services.AddTransient<IThoiKhoaBieuRepository, ThoiKhoaBieuRepository>();
            services.AddTransient<IThongTinHDService, ThongTinHDService>();
            services.AddTransient<IThongTinHDRepository, ThongTinHDRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "QuanLyDaoTao.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "QuanLyDaoTao.API v1"));
            }

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
