using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BonusLib.Interfaces
{
    public interface IDbConnectionFactory
    {
        IDbConnection OpenDbConnection();
        IDbConnection CreateDbConnection();
    }
}
