﻿using Microsoft.EntityFrameworkCore;
using WebApiTrades.Model;
using WebLinkTrades.Dados.Context.ConfigurationContext;

namespace WebLinkTrades.Dados.Context
{
    public class BaseContext : DbContext
    {
        DbSet<Trades> Trades { get; set; }

        public BaseContext(DbContextOptions<BaseContext> dbContext) : base(dbContext)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConfigurationTrades());
        }
    }
}
