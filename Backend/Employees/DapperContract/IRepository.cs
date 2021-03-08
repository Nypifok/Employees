using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DapperContract
{
    public interface IRepository<T>
    {
        public Task<T> GetByIdAsync(long id);
        public Task<int> AddAsync(T item);
        public Task<int> AddAsync(IEnumerable<T> items);
        public Task<bool> RemoveAsync(T item);
        public Task<bool> RemoveAsync(IEnumerable<T> items);
        public Task<bool> UpdateAsync(T item);
        public Task<bool> UpdateAsync(IEnumerable<T> items);

    }
}
