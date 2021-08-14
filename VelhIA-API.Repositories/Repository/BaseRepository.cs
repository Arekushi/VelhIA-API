using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using VelhIA_API.Application.Repositories;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Data.Context;

namespace VelhIA_API.Repositories.Repository
{
    public class BaseRepository<E> : IBaseRepository<E>
        where E : Entity
    {
        protected readonly AppDbContext context;
        protected readonly DbSet<E> dbSet;
        private bool disposed;

        public BaseRepository(AppDbContext context)
        {
            this.context = context;

            dbSet = context.Set<E>();
            disposed = false;
        }

        public virtual async Task<E> Create(E entity)
        {
            var data = await dbSet.AddAsync(entity);
            await SaveChanges();

            return data.Entity;
        }

        public virtual async Task<bool> DeleteById(Guid id)
        {
            E entity = await dbSet
                .FirstOrDefaultAsync(e => e.Id == id);

            dbSet.Remove(entity);
            await SaveChanges();

            return true;
        }

        public virtual async Task<E> Edit(E entity)
        {
            var entry = dbSet.Update(entity);
            await SaveChanges();

            return entry.Entity;
        }

        public virtual async Task<E> GetById(Guid id)
        {
            return await dbSet
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public virtual async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool isDisposing)
        {
            if (!disposed && isDisposing)
            {
                context.Dispose();
            }

            disposed = true;
        }
    }
}
