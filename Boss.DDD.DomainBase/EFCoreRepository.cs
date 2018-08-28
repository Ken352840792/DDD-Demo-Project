using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    /// <summary>
    /// 针对EFCore的仓储层设计
    /// </summary>
    public class EFCoreRepository : IRepository
    {
        private readonly DbContext _dbContext;

        public EFCoreRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}