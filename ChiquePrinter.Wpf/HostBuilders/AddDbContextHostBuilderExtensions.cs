using ChiquePrinter.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChiquePrinter.WPF.HostBuilders
{
    public static class AddDbContextHostBuilderExtensions
    {
        public static IHostBuilder AddDbContext(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                string connectionString = context.Configuration.GetConnectionString("sqlserver");
                Action<DbContextOptionsBuilder> configureDbContext = o => o.UseSqlServer(connectionString);

                services.AddDbContext<ChiquePrinterDbContext>(configureDbContext);
                services.AddSingleton<DbContextFactory>(new DbContextFactory(configureDbContext));
            });

            return host;
        }
    }
}
