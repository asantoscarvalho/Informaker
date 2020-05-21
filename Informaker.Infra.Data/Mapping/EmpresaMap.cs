using Informaker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Informaker.Infra.Data.Mapping
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.NomeFantasia).HasColumnType("varchar(150)").HasColumnName("NomeFantasia");
            builder.Property(p => p.Cnpj).HasColumnType("varchar(15)").HasColumnName("Cnpj");
            builder.Property(p => p.UF).HasColumnType("char(2)").HasColumnName("UF");
            builder.HasMany(p => p.EmpresaFornecedores);
            builder.ToTable("Empresa");
        }
    } 
}