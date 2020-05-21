using System.Collections.Generic;
using System.Threading.Tasks;

namespace Informaker.Domain.Interfaces.Repositories
{
     public interface IRepositoryBase<TEntity> where TEntity : class

    {
        void Add(TEntity obj);

        

        Task<TEntity[]> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}