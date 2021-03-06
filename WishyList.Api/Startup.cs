using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Api.Models;

namespace WishyList.Api
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
            // Instructions on how to talk to SQL Server
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DbConnection")));
            services.AddRazorPages();
            services.AddServerSideBlazor();

            // Tie Repository interface and Implementation classes together
            // When a call for IMemberRepository comes through, this line tells it which implementation to use, in this case MemberRepository class
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IListRepository, ListRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();

            // Remove formatter that turns nulls into 204 - no content responses
            // https://weblog.west-wind.com/posts/2020/Feb/24/Null-API-Responses-and-HTTP-204-Results-in-ASPNET-Core
            services.AddControllers(opt => opt.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>());
            //services.AddControllers();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Members}");
                    
                    //name: "default",
                //pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
