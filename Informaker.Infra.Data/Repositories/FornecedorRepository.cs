using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Informaker.Domain.Entities;
using Informaker.Domain.Interfaces.Repositories;
using Informaker.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Informaker.Infra.Data.Repositories
{

    public class FornecedorRepository : RepositoryBase<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(InformakerDbContext context) : base(context) {}


        public async Task<Fornecedor> BuscarPorCpfCnpj(string CpfCnpj)
        {
            IQueryable<Fornecedor> query = _context.Fornecedores.Include(p=> p.EmpresaFornecedores).Include(p => p.ContatosFornecedor).Where(p => p.CpfCnpj == CpfCnpj);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Fornecedor> GetById(int id)
        {
            IQueryable<Fornecedor> query = _context.Fornecedores.Include(p=> p.EmpresaFornecedores).Include(p => p.ContatosFornecedor).Where(p => p.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Fornecedor[]>  BuscarPorDataCadastro(DateTime DataInicial,DateTime DataFinal )
        {
            IQueryable<Fornecedor> query =_context.Fornecedores.Include(p=> p.EmpresaFornecedores).Where(p => p.DataCadastro >= DataInicial && p.DataCadastro <= DataFinal );

            return await query.ToArrayAsync() ;
        }

        public async Task<Fornecedor[]>  BuscarPorNome(string nome)
        {
            IQueryable<Fornecedor> query = _context.Fornecedores.Include(p=> p.EmpresaFornecedores).Where(p => p.NomeFornecedor.Contains(nome));
            
            return await query.ToArrayAsync() ;
        }

        

        
    }
}