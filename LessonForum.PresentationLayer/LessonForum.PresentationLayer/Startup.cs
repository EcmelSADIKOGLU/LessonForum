using LessonForum.BusinessLayer.Abstract;
using LessonForum.BusinessLayer.Concrete;
using LessonForum.DataAccessLayer.Abstract;
using LessonForum.DataAccessLayer.Concrete;
using LessonForum.DataAccessLayer.EntityFramework;
using LessonForum.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonForum.PresentationLayer
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
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
            services.AddControllersWithViews();

            services.AddScoped<ICategoryDAL,EFCategoryDAL>();
            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<ISubCategoryDAL, EFSubCategoryDAL>();
            services.AddScoped<ISubCategoryService, SubCategoryManager>();
            services.AddScoped<ILessonNoteDAL, EFLessonNoteDAL>();
            services.AddScoped<ILessonNoteService, LessonNoteManager>();

            //Kimse giriş yapmadıysa sayfalar açılmaz
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                             .RequireAuthenticatedUser()
                             .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
            services.AddMvc();

            //Giriş yapılmadıysa login sayfasına atılır
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(2);
                options.LoginPath = "/Login/Login/";
                options.AccessDeniedPath = "/ErrorPage/Index/";

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
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
