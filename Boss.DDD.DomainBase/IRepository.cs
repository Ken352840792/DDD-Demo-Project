using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    public interface IRepository : IUnitOfWork, IDisposable
    {
    }
}