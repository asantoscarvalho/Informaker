using System.Threading.Tasks;
using Informaker.Domain.Entities;

namespace Informaker.Domain.Interfaces.Repositories
{
    public interface IEmpresaRepository  : IRepositoryBase<Empresa>
    {
         Task<Empresa> GetById(int id);

         Task<Empresa> BuscarPorCnpj(string Cnpj);
    }
}