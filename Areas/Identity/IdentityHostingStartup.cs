using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pulp.Areas.Identity;
using Pulp.Areas.Identity.Data;


[assembly: HostingStartup(typeof(IdentityHostingStartup))]
namespace Pulp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<PulpProjectContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PulpProjectContextConnection")));

            });
        }
    }
}