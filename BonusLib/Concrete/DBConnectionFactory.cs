using BonusLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BonusLib.Concrete
{
    class DBConnectionFactory : IDbConnectionFactory
    {
        public IDbConnection CreateDbConnection()
        {
            throw new NotImplementedException();
        }

        public IDbConnection OpenDbConnection()
        {
            throw new NotImplementedException();
        }
    }
}
