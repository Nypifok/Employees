using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperContract
{
    public interface IDapperContext:IDisposable
    {
        IDbConnection Connection { get; }
        IDbTransaction Transaction { get; }
        void Begin();
        void Commit();
        void Rollback();
    }
}
