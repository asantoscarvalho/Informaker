using Informaker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Informaker.Infra.Data.Context
{
    public class InformakerDbContext : DbContext
    {
        public InformakerDbContext(DbContextOptions<InformakerDbContext> options) : base (options) {}
        
        public DbSet<Empresa> Empresas {get; set;}
        public DbSet<Fornecedor> Fornecedores {get; set;}
        public DbSet<EmpresaFornecedores> EmpresaFornecedores {get; set;}
        public DbSet<FornecedorContatos> FornecedorContatos {get; set;}

        
    }
}