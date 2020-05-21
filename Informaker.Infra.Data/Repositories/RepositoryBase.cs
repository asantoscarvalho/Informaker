using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Informaker.Domain.Interfaces.Repositories;
using Informaker.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Informaker.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected InformakerDbContext _context;

        public RepositoryBase(InformakerDbContext context) 
        {
            this._context = context;
        }

        public void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            this._context.Dispose();   
        }

        public async Task<TEntity[]> GetAll()
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            return await query.ToArrayAsync();
        }

        

        public void Remove(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}