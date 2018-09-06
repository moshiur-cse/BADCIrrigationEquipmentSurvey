using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity.UI.Services;

using BADCIrrigationEquipmentSurvey.DbContexts;
using BADCIrrigationEquipmentSurvey.Models;
using BADCIrrigationEquipmentSurvey.Models.BasicModels;
using BADCIrrigationEquipmentSurvey.Models.Services;


namespace BADCIrrigationEquipmentSurvey
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
            string dbConnStr = Configuration.GetConnectionString("BadcDbConnStr");

            if (string.IsNullOrEmpty(dbConnStr))
            {
                dbConnStr = @"Server=AHI\SQLEXPRESS;Database=badc_ies_db;User ID=ahi_admin;Password=mhf@013;Integrated Security=True;Trusted_Connection=True;";
                //dbConnStr = @"Server=AL-HADI\SQLEXPRESS;Database=badc_ies_db;User ID=ahi_admin;Password=mhf@013;Integrated Security=True;Trusted_Connection=True;";
            }


            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddDbContext<BadcDbContext>(options => options.UseSqlServer(dbConnStr));

            services.AddDbContext<UserDbContext>(options => options.UseSqlServer(dbConnStr));

            services.AddIdentity<BadcAppUser, IdentityRole>(options =>
                {
                    // User settings
                    options.User.RequireUniqueEmail = false;
                    options.Stores.MaxLengthForKeys = 128;

                    //// Lockout settings
                    //options.Lockout.AllowedForNewUsers = true;
                    //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(20);
                    //options.Lockout.MaxFailedAccessAttempts = 10;

                    // Password settings
                    options.Password.RequireDigit = false;
                    options.Password.RequiredLength = 4;
                    options.Password.RequiredUniqueChars = 1;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;

                    //// Signin settings
                    //options.SignIn.RequireConfirmedEmail = false;
                    //options.SignIn.RequireConfirmedPhoneNumber = false;
                })
                .AddEntityFrameworkStores<UserDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddRazorPagesOptions(options =>
                {
                    options.AllowAreas = true;
                    options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
                    options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
                })
                .AddSessionStateTempDataProvider();

            //services.Configure<IdentityOptions>(options =>
            //{
            //    // Password settings
            //    options.Password.RequireDigit = true;
            //    options.Password.RequiredLength = 4;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireUppercase = true;
            //    options.Password.RequireLowercase = false;
            //    options.Password.RequiredUniqueChars = 2;

            //    // Lockout settings
            //    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(20);
            //    options.Lockout.MaxFailedAccessAttempts = 10;
            //    options.Lockout.AllowedForNewUsers = true;

            //    // User settings
            //    options.User.RequireUniqueEmail = true;
            //});

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.Name = ".BADC-IES.Session";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(25);
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });

            // Add application services.
            //services.AddTransient<IEmailSender, EmailSender>();

            services.AddTransient<IEmailSender, EmailSender>(i =>
                new EmailSender(
                    Configuration["EmailSender:Host"],
                    Configuration.GetValue<int>("EmailSender:Port"),
                    Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                    Configuration["EmailSender:UserName"],
                    Configuration["EmailSender:Password"]
                )
            );


            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.Name = ".BADC-IES.Session";
                options.IdleTimeout = TimeSpan.FromMinutes(20);
                options.IOTimeout = TimeSpan.FromMinutes(20);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                //app.UseExceptionHandler(
                //    new ExceptionHandlerOptions
                //    {
                //        ExceptionHandler = async context =>
                //        {
                //            context.Response.ContentType = "text/plain";
                //            await context.Response.WriteAsync("Welcome to the error page.");
                //        }
                //    });
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                app.UseExceptionHandler(
                    new ExceptionHandlerOptions
                    {
                        ExceptionHandler = async context =>
                        {
                            context.Response.ContentType = "text/plain";
                            await context.Response.WriteAsync("Welcome to the error page.");
                        }
                    });
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseSession();

            app.UseMvcWithDefaultRoute();
            //app.UseHttpContextItemsMiddleware();

            //app.UseMiddleware(typeof(ErrorHandlingMiddleware));
            //app.UseMiddleware(typeof(ExceptionHandlerMiddleware));

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

    }
}
