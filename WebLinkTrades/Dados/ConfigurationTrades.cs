using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WebApiTrades.Model;

namespace WebLinkTrades.DAL
{
    public class ConfigurationTrades : IEntityTypeConfiguration<Trades>
    {
        public void Configure(EntityTypeBuilder<Trades> builder)
        {
            builder
                            .ToTable("TORCOMI");

            builder
                .Property(x => x.DateTime)
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(x => x.Ativo)
                .IsRequired();
        }
    }
}