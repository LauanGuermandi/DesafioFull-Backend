using Financeiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeiro.Data.Mappings
{
    public class DividaMap : IEntityTypeConfiguration<Divida>
    {
        public void Configure(EntityTypeBuilder<Divida> builder)
        {
            builder
              .ToTable("Divida");

            builder
              .HasKey(d => d.Id);
            
            builder
              .HasIndex(d => d.NumeroTitulo)
              .IsUnique();
            builder
              .Property(d => d.NumeroTitulo)
              .HasColumnType("varchar(10)")
              .HasMaxLength(10)
              .IsRequired();

            builder
              .Property(d => d.ValorOriginal)
              .HasColumnType("numeric(18,2)")
              .IsRequired();
            
            builder
              .Property(d => d.PorcentagemJuros)
              .IsRequired();
            
            builder
              .Property(d => d.PorcentagemMulta)
              .IsRequired();

            builder
              .Property(d => d.PessoaId)
              .IsRequired();

            builder
              .HasOne(d => d.Pessoa)
              .WithMany(p => p.Dividas);
        }
    }
}
