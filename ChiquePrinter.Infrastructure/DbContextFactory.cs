using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChiquePrinter.Infrastructure
{
    public class DbContextFactory : IDesignTimeDbContextFactory<ChiquePrinterDbContext>
    {
        private readonly Action<DbContextOptionsBuilder> _configureDbContext;

        public DbContextFactory()
        {
        }

        public DbContextFactory(Action<DbContextOptionsBuilder> configureDbContext)
        {
            _configureDbContext = configureDbContext;
        }

        //public ChiquePrinterDbContext CreateDbContext()
        //{
        //    DbContextOptionsBuilder<ChiquePrinterDbContext> options = new DbContextOptionsBuilder<ChiquePrinterDbContext>();

        //    _configureDbContext(options);

        //    return new ChiquePrinterDbContext(options.Options);
        //}

        public ChiquePrinterDbContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<ChiquePrinterDbContext>();
            string qonstr = "Data Source=(localdb)\\ProjectModels;Initial Catalog=ChiquePrinterDB;Integrated Security=True;Connect Timeout=30;";
            options.UseSqlServer(qonstr);
            return new ChiquePrinterDbContext(options.Options);
        }
        public ChiquePrinterDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<ChiquePrinterDbContext>();
            string qonstr = "Data Source=(localdb)\\ProjectModels;Initial Catalog=ChiquePrinterDB;Integrated Security=True;Connect Timeout=30;";
            options.UseSqlServer(qonstr);
            return new ChiquePrinterDbContext(options.Options);
        }


    }
}
