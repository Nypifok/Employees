using DapperContract;
using DapperImplementation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperImplementation
{
    public class DapperContext : IDapperContext
    {
        protected IDbConnection _connection;
        protected IDbTransaction _transaction;

        public IDbConnection Connection { get { return _connection; } }
        public IDbTransaction Transaction { get { return _transaction; } }

        private BaseRepository<User> _users;
        public BaseRepository<User> Users { get { return _users ?? new BaseRepository<User>(Transaction); } }

        private BaseRepository<Master> _masters;
        public BaseRepository<Master> Masters { get { return _masters ?? new BaseRepository<Master>(Transaction); } }

        private BaseRepository<Schedule> _schedules;
        public BaseRepository<Schedule> Schedules { get { return _schedules ?? new BaseRepository<Schedule>(Transaction); } }

        private BaseRepository<Order> _orders;
        public BaseRepository<Order> Orders { get { return _orders ?? new BaseRepository<Order>(Transaction); } }

        private BaseRepository<Specification> _specifications;
        public BaseRepository<Specification> Specifications { get { return _specifications ?? new BaseRepository<Specification>(Transaction); } }

        private BaseRepository<Service> _services;
        public BaseRepository<Service> Services { get { return _services ?? new BaseRepository<Service>(Transaction); } }



        public DapperContext(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Begin()
        {
            _transaction = _connection.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
            Dispose();
        }

        public void Rollback()
        {
            _transaction.Rollback();
            Dispose();
        }

        public void Dispose()
        {
            if (_transaction != null)
                _transaction.Dispose();
            _transaction = null;
        }
    }
}
