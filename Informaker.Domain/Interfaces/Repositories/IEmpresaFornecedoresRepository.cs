using System.Threading.Tasks;
using Informaker.Domain.Entities;

namespace Informaker.Domain.Interfaces.Repositories
{
    public interface IEmpresaFornecedoresRepository : IRepositoryBase<EmpresaFornecedores>
    {
         Task<EmpresaFornecedores> GetById(int id);
    }
}