using Informaker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Informaker.Infra.Data.Mapping
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.NomeFornecedor).HasColumnType("varchar(150)").HasColumnName("NomeFornecedor");
            builder.Property(p => p.TipoPessoa).HasColumnType("char(2)").HasColumnName("TipoPessoa");
            builder.Property(p => p.CpfCnpj).HasColumnType("varchar(15)").HasColumnName("CpfCnpj");
            builder.Property(p => p.Rg).HasColumnType("varchar(15)").HasColumnName("Rg");
            builder.Property(p => p.DataCadastro).HasColumnType("datetime").HasColumnName("DataCadastro");
            builder.Property(p => p.DataNascimento).HasColumnType("datetime").HasColumnName("DataNascimento");
            builder.HasMany(p => p.ContatosFornecedor);
            builder.ToTable("Fornecedor");
        }
    } 
}