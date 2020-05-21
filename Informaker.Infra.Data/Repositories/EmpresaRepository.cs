using System.Linq;
using System.Threading.Tasks;
using Informaker.Domain.Entities;
using Informaker.Domain.Interfaces.Repositories;
using Informaker.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Informaker.Infra.Data.Repositories
{
    public class EmpresaRepository : RepositoryBase<Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(InformakerDbContext context) : base(context) {}

        public async Task<Empresa> GetById(int id)
        {
            IQueryable<Empresa> query = _context.Empresas.Where(p => p.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Empresa> BuscarPorCnpj(string Cnpj)
        {
            IQueryable<Empresa> query = _context.Empresas.Where(p => p.Cnpj == Cnpj);

            return await query.FirstOrDefaultAsync();
        }
    }
}