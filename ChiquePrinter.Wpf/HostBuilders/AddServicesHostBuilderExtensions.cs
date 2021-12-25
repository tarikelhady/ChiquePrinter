using Microsoft.AspNet.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ChiquePrinter.Domain.Models;
using ChiquePrinter.Domain.Services;
using ChiquePrinter.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;
using ChiquePrinter.Domain.Services.AuthenticationServices;

namespace ChiquePrinter.WPF.HostBuilders
{
    public static class AddServicesHostBuilderExtensions
    {
        public static IHostBuilder AddServices(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddSingleton<IPasswordHasher, PasswordHasher>();

                services.AddSingleton<IAuthenticationService, AuthenticationService>();
                services.AddSingleton<IDataService<User>, UserDataService>();
                services.AddSingleton<IUserService, UserDataService>();
            });

            return host;
        }
    }
}
