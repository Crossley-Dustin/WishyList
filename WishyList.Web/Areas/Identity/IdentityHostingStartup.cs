using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WishyList.Web.Data;

[assembly: HostingStartup(typeof(WishyList.Web.Areas.Identity.IdentityHostingStartup))]
namespace WishyList.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WishyListWebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WishyListWebContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<WishyListWebContext>();
            });
        }
    }
}