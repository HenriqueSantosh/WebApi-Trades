using Microsoft.EntityFrameworkCore;
using System;
using WebApiTrades.Model;

namespace WebLinkTrades.DAL
{
    public class TradesContext : DbContext
    {
        public DbSet<Trades> Trades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-IK7193A\\SQLEXPRESS; Database = EPIGEIAS; Trusted_Connection = true; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigurationTrades());

        }
    }
}