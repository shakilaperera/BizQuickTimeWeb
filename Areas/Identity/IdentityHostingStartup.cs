using System;
using BizQuickTime.Web.Model;
using BizQuickTime.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BizQuickTime.Web.Areas.Identity.IdentityHostingStartup))]
namespace BizQuickTime.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<BQTDataContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("BQTIdentityDataContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<BQTDataContext>();
            });
        }
    }
}