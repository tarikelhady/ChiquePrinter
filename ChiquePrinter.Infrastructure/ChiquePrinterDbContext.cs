using ChiquePrinter.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.Infrastructure
{
    public class ChiquePrinterDbContext : DbContext
    {
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankBook> BankBooks { get; set; }
        public DbSet<BankScema> BankScemas { get; set; }
        public DbSet<Chique> Chiques { get; set; }
        public DbSet<ChiqueAddress> Chiqueaddresss { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Payee> payees { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string qonstr = "Data Source=(localdb)\\ProjectModels;Initial Catalog=ChiquePrinterDB;Integrated Security=True;Connect Timeout=30;";
            optionsBuilder.UseSqlServer(qonstr);
            base.OnConfiguring(optionsBuilder);
        }
        public ChiquePrinterDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>()
            .HasOne(a => a.BankScema)
            .WithOne(a => a.Bank)
            .HasForeignKey<BankScema>(c => c.BankId);

            modelBuilder.Entity<User>()
            .HasOne(e => e.CreateBy)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BankBook>()
            .HasOne(e => e.CreateBy)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<BankScema>()
            .HasOne(e => e.CreateBy)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Chique>()
            .HasOne(e => e.CreateBy)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Chique>()
            .HasOne(e => e.Bank)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Chique>()
            .HasOne(e => e.Address)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Chique>()
            .HasOne(e => e.Currency)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Chique>()
            .HasOne(e => e.Payee)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserLog>()
            .HasOne(e => e.Status)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserLog>()
            .HasOne(e => e.User)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
    }
}
