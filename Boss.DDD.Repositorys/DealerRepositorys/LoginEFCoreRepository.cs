using Boss.DDD;
using Boss.DDD.POCOModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boss.DDD.DealerRepositorys
{
    public class LoginEFCoreRepository : ILoginRepository
    {
        private readonly DbContext _dbContext;

        public LoginEFCoreRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public bool UserLogin(string tel, string password)
        {
            var dealerContext = this._dbContext as DealerEFCoreContext;
            var enPass = MD5Encrption.GetMD5Str(password);
            return dealerContext.Login.Where(p => p.Code == tel && p.PassWord == enPass).Any();
        }

        public void CreateLogin<T>(T login) where T : class, IAggregationRoot
        {
            var dealerContext = this._dbContext as DealerEFCoreContext;
            var loginNew = login as Login;
            try
            {
                dealerContext.Login.Add(loginNew);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}