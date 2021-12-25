using ChiquePrinter.Domain.Models;
using ChiquePrinter.Domain.Services;
using ChiquePrinter.Infrastructure;
using ChiquePrinter.Infrastructure.Services;
using ChiquePrinter.WPF.HostBuilders;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ChiquePrinter.WPF
{
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = CreateHostBuilder().Build();
        }

        public static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args)
                .AddConfiguration()
                .AddDbContext()
                .AddServices()
                .AddStores()
                .AddViewModels()
                .AddViews();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();

            DbContextFactory contextFactory = _host.Services.GetRequiredService<DbContextFactory>();
            using (ChiquePrinterDbContext context = contextFactory.CreateDbContext())
            {
                context.Database.Migrate();
            }
            Window window = _host.Services.GetRequiredService<MainWindow>();
            window.Show();
            base.OnStartup(e);
        }

        private static void AddUserByCode(DbContextFactory contextFactory)
        {
            IDataService<User> UserDataService = new GenericDataService<User>(contextFactory);
            IPasswordHasher passwordHasher = new PasswordHasher();
            new GenericDataService<User>(contextFactory);
            User usercarmin = new User
            {
                Name = "Mohsen",
                Password = passwordHasher.HashPassword("123456"),
                Username = "mohsen",
                Email = "mohsen@gmail.com",
                No = 3,
                CreateById = new Guid("112C8DD8-346B-426E-B06C-75BBA97DCD63"),
                CreateDate = DateTime.Now,
                ModifyDate = DateTime.Now
            };


            UserDataService.Create(usercarmin);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }
    }
}
