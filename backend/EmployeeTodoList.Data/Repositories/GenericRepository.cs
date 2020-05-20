using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeTodoList.Data.Domains;
using EmployeeTodoList.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace EmployeeTodoList.Data.Repositories
{
    internal class GenericRepository<TContext, TEntity> : IGenericRepository<TEntity>, IDisposable
        where TContext : DbContext
        where TEntity : BaseEntity
    {
        public GenericRepository(TContext context)
        {
            Context = context;
            Items = Context.Set<TEntity>();
        }

        protected TContext Context { get; }

        protected DbSet<TEntity> Items { get; }

        public virtual void Add(TEntity entity)
        {
            Items.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            Items.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            Items.Remove(entity);
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await Items.ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await Items.FindAsync(id);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Context?.Dispose();
            }
        }
    }
}