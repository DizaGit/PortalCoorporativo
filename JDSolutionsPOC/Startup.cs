using JDInvoiceManager.Helper;
using JDInvoiceManager.Helper.Configuration;
using JDInvoiceManager.Helper.CurrentSystem;
using JDInvoiceManager.Helper.Email;
using JDInvoiceManager.Helper.Logger;
using JDSolutionsPOC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JDSolutionsPOC
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
            services.Configure<ServicesInfo>(Configuration);
            services.Configure<AppsettingsConfiguration>(Configuration);
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAppDataRetriever, WebsiteAppDataRetriever>();
            services.AddSingleton<ISystemIOWrapper, SystemIOWrapper>();
            services.AddScoped<IDataLoggerSQLiteDatabase, DataLoggerSQLiteDatabase>();
            services.AddScoped<IDataLoggerWriter, DataLoggerWriter>();
            services.AddScoped<IMailSender, MailSender>();
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
            app.UseStatusCodePagesWithReExecute("/HandleError/{0}");
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
