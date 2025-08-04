
using BusinesLayer.Abstract;
using BusinesLayer.Concrete;
using DataAcsessLayer.Abstract;
using DataAcsessLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;

namespace Core_ProjeUdmy
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

            services.AddIdentity<WriterUser, WriterRole>()
                    .AddEntityFrameworkStores<Context>();

            services.AddScoped<IWriterMessageService, WriterMessageManager>();
            services.AddScoped<IWriterMessageDal, EfWriterMessageDal>();

            services.AddControllersWithViews();
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                           .RequireAuthenticatedUser()
                           .Build();
                config.Filters.Add(new AuthorizeFilter(policy));


            });
            services.AddMvc();
            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(x =>
            //    {
            //        x.LogoutPath = " /Writer/Login/Index/";

            //    });


            services.ConfigureApplicationCookie(Options =>
            {
                Options.Cookie.HttpOnly = true;
                Options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                Options.AccessDeniedPath = "/ErrorPage/Index/";
                Options.LoginPath = "/Writer/Login/Index/";

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
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/ErrorPage/ErrorPage404");
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();           
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // Default route
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Default}/{action=Index}/{id?}");

                // Area route
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}");
            });
        }
    }
}
