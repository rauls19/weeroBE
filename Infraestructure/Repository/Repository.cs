using System;
using System.Collections.Generic;
using Infraestructure.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DbContextBase context;
        public Repository(DbContextBase context)
        {
            this.context = context;
        }
        public Task<T> GetById(long id)
        {
           return context.Set<T>().SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task Add(T entity)
        {
            // await Context.AddAsync(entity);
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public Task Update(T entity)
        {
            // In case AsNoTracking is used
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChangesAsync();
        }

        public Task Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            return context.SaveChangesAsync();
        }

        public async Task<ICollection<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }
    }
}
