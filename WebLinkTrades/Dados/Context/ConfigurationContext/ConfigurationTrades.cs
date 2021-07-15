using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WebApiTrades.Model;

namespace WebLinkTrades.Dados.Context.ConfigurationContext
{
    public class ConfigurationTrades : IEntityTypeConfiguration<Trades>
    {
        public void Configure(EntityTypeBuilder<Trades> builder)
        {
            builder.Property(x => x.DateTime)
                .HasDefaultValue(DateTime.Now);

            builder.Property(x => x.Conta)
                .HasColumnType<int>("int")
                .IsRequired();

            builder.Property(x => x.Ativo)
                .HasColumnType<string>("varchar(20)")
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasColumnType<decimal>("decimal(10,2)")
                .IsRequired();

            builder.Property(x => x.Quantidade)
                .HasColumnType<int>("int")
                .IsRequired();

            builder.Property(x => x.TipoOperacao)
                .HasColumnType<char>("nchar(1)")
                .IsRequired();
        }
    }
}