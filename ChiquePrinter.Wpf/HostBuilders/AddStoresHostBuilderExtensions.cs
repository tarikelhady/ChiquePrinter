using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ChiquePrinter.WPF.State.Users;
using ChiquePrinter.WPF.State.Authenticators;
using ChiquePrinter.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChiquePrinter.WPF.HostBuilders
{
    public static class AddStoresHostBuilderExtensions
    {
        public static IHostBuilder AddStores(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddSingleton<INavigator, Navigator>();
                services.AddSingleton<IAuthenticator, Authenticator>();
                services.AddSingleton<IUserStore, UserStore>();
            });

            return host;
        }
    }
}
