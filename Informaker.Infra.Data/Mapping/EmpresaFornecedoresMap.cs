using Informaker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Informaker.Infra.Data.Mapping
{
    public class EmpresaFornecedoresMap: IEntityTypeConfiguration<EmpresaFornecedores>
    {
        public void Configure(EntityTypeBuilder<EmpresaFornecedores> builder)
        {
            builder.HasKey(pk => pk.Id);
            
             builder.HasOne(ep => ep.Empresa)
                .WithMany(pc => pc.EmpresaFornecedores)
                .HasForeignKey(p => p.EmpresaId)
                .HasPrincipalKey(p => p.Id);

             builder.HasOne(ep => ep.Fornecedor)
                .WithMany(pc => pc.EmpresaFornecedores)
                .HasForeignKey(p => p.FornecedorId)
                .HasPrincipalKey(p => p.Id);

            builder.ToTable("EmpresaFornecedores");
        }   
    }
}