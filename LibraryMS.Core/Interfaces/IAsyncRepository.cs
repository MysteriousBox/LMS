using LibraryMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Interfaces
{
    public interface IAsyncRepository<T> where T:BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetByIDAsync(string id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> specification);
        Task<int> GetCountAsync(ISpecification<T> specification);
    }
}
