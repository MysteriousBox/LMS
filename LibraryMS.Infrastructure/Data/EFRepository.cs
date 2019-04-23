using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMS.Core.Entities;
using LibraryMS.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryMS.Infrastructure.Data
{
    public class EFRepository <T>: IAsyncRepository<T>where T:BaseEntity
    {
        protected readonly LibraryDbContext _libraryDb;
        public EFRepository(LibraryDbContext libraryDb)
        {
            _libraryDb = libraryDb;
        }
        public async Task<T> AddAsync(T entity)
        {
            _libraryDb.Set<T>().Add(entity);

            await _libraryDb.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _libraryDb.Set<T>().Remove(entity);
            await _libraryDb.SaveChangesAsync();
        }

        public virtual async Task<T> GetByIDAsync(string id)
        {
            return await _libraryDb.Set<T>().FindAsync(id);
        }

        public async Task<int> GetCountAsync(ISpecification<T> specification)
        {
            return await ApplySpecification(specification).CountAsync();
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _libraryDb.Set<T>().ToListAsync();

        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> specification)
        {
            return await ApplySpecification(specification).ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _libraryDb.Set<T>().Update(entity);
            await _libraryDb.SaveChangesAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> specification)
        {
            return SpecificationEvaluator<T>.GetQuery(_libraryDb.Set<T>().AsQueryable(),specification);
        }
    }
}
