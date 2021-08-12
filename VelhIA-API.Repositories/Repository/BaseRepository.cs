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
            try
            {
                var data = await dbSet.AddAsync(entity);
                await SaveChanges();

                return data.Entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual async Task<bool> DeleteById(Guid id)
        {
            E entity = await dbSet
                .FirstOrDefaultAsync(e => e.Id == id);

            try
            {
                dbSet.Remove(entity);
                await SaveChanges();

                return true;
            } catch (Exception)
            {
                throw;
            }
        }

        public virtual async Task<E> Edit(E entity)
        {
            try
            {
                var entry = dbSet.Update(entity);
                await SaveChanges();

                return entry.Entity;
            } catch (Exception)
            {
                throw;
            }
        }

        public virtual async Task<E> GetById(Guid id)
        {
            E entity = await dbSet.FirstOrDefaultAsync(e => e.Id == id);

            if (entity is null)
            {
                throw new Exception();
            }

            return entity;
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
