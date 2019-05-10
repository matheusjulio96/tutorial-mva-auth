using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using tutorial_mva_auth.Areas.Identity.Data;

[assembly: HostingStartup(typeof(tutorial_mva_auth.Areas.Identity.IdentityHostingStartup))]
namespace tutorial_mva_auth.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<IdentityDataContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("IdentityDataContextConnection")));

            //    services.AddDefaultIdentity<IdentityUser>()
            //        .AddEntityFrameworkStores<IdentityDataContext>();
            //});
        }
    }
}