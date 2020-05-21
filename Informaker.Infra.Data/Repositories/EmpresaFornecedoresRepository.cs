using System.Linq;
using System.Threading.Tasks;
using Informaker.Domain.Entities;
using Informaker.Domain.Interfaces.Repositories;
using Informaker.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Informaker.Infra.Data.Repositories
{
    public class EmpresaFornecedoresRepository : RepositoryBase<EmpresaFornecedores>, IEmpresaFornecedoresRepository
    {
        public EmpresaFornecedoresRepository(InformakerDbContext context) : base(context) {}

        public async Task<EmpresaFornecedores> GetById(int id)
        {
            IQueryable<EmpresaFornecedores> query = _context.EmpresaFornecedores.Where(p => p.Id == id);

            return await query.FirstOrDefaultAsync();
        }
    }
}