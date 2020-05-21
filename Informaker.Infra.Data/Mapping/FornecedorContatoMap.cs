using Informaker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Informaker.Infra.Data.Mapping
{
    public class FornecedorContatoMap: IEntityTypeConfiguration<FornecedorContatos>
    {
        public void Configure(EntityTypeBuilder<FornecedorContatos> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.TipoContato).HasColumnType("varchar(10)").HasColumnName("TipoContato");
            builder.Property(p => p.Descricao).HasColumnType("varchar(30)").HasColumnName("Descricao");

            builder.HasOne(ep => ep.Fornecedor)
                .WithMany(pc => pc.ContatosFornecedor)
                .HasForeignKey(p => p.FornecedorId)
                .HasPrincipalKey(p => p.Id);



            builder.ToTable("FornecedorContatos");
        }
    } 
}