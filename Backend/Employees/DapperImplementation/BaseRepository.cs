using Dapper;
using Dapper.Contrib.Extensions;
using DapperContract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperImplementation
{
    public class BaseRepository<T> : IRepository<T> where T:class
    {

        protected IDbTransaction Transaction { get; private set; }
        protected IDbConnection Connection { get { return Transaction.Connection; } }
        public BaseRepository(IDbTransaction transaction)
        {
            Transaction = transaction;
        }
        public async Task<int> AddAsync(T item)
        {
            return await Connection.InsertAsync(item, Transaction);
        }

        public async Task<int> AddAsync(IEnumerable<T> items)
        {
            return await Connection.InsertAsync(items, Transaction);
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await Connection.GetAsync<T>(id);
        }

        public async Task<bool> RemoveAsync(T item)
        {
            return await Connection.DeleteAsync(item);
        }

        public async Task<bool> RemoveAsync(IEnumerable<T> items)
        {
            return await Connection.DeleteAsync(items);
        }

        public async Task<bool> UpdateAsync(T item)
        {
            return await Connection.UpdateAsync(item);
        }

        public async Task<bool> UpdateAsync(IEnumerable<T> items)
        {
            return await Connection.UpdateAsync(items);
        }

        
    }
}
