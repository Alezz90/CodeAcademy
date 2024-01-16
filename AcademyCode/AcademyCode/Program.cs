using AcademyCode.BLL.Interface;
using AcademyCode.BLL.Repo;
using AcademyCode.DAL.Data;
using AcademyCode.DAL.Model;
using AcademyCode.ModelProfile;
using Microsoft.EntityFrameworkCore;


namespace AcademyCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AcademyDBContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("defultConnection")));

            builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
            builder.Services.AddAutoMapper(m=>m.AddProfile(new DepatmentProfile()));
            /*
            builder.Services.AddScoped<IEmployee, EmployeeRepo>();
            builder.Services.AddScoped<IDepartment, DepartmentRepo>();

            **/
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}