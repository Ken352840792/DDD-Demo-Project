using Boss.DDD;
using Boss.DDD.POCOModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boss.DDD;

namespace Boss.DDD.DealerRepositorys
{
    public class DealerEFCoreRepository : IDealerRepository
    {
        private readonly DbContext dbContext;

        public DealerEFCoreRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddParentSubCount(Guid? dealerid)
        {
            if (dealerid != null)
            {
                var dealerContext = this.dbContext as DealerEFCoreContext;
                var pDealer = dealerContext.Dealers.Single(p => p.Id == dealerid);
                pDealer.SubCount += 1;
                if (pDealer.SubCount > 2)
                {
                    throw new OverTwoSubExeption("此经销商已经存在两个直属下级");
                }
                else
                {
                    try
                    {
                        dbContext.Entry(pDealer).State = EntityState.Modified;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        public void CreateDealer<T>(T Dealer) where T : class, IAggregationRoot
        {
            var dealerContext = this.dbContext as DealerEFCoreContext;
            var dealerNew = Dealer as Dealers;
            try
            {
                dealerContext.Dealers.Add(dealerNew);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetParentDealerLayer(Guid dealerid)
        {
            var dealerContext = this.dbContext as DealerEFCoreContext;
            return dealerContext.DealerTree.Single(p => p.DealerId == dealerid).Layer;
        }

        public void SubParentEleMoney(Guid dealerid, decimal submoney)
        {
            var dealerContext = this.dbContext as DealerEFCoreContext;
            var parentdealer = dealerContext.Dealers.Single(p => p.Id == dealerid);
            parentdealer.TotalEleMoney -= submoney;
            try
            {
                dbContext.Entry(parentdealer).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}