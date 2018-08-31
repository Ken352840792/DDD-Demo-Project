using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    public interface IDealerRepository
    {
        void CreateDealer<T>(T product) where T : class, IAggregationRoot;

        /// <summary>
        /// 获取上级经销商的ID
        /// </summary>
        /// <param name="dealerid"></param>
        /// <returns></returns>
        int GetParentDealerLayer(Guid dealerid);

        /// <summary>
        /// 将上级经销商的子经销商个数加一
        /// </summary>
        /// <param name="dealerid"></param>
        void AddParentSubCount(Guid? dealerid);

        /// <summary>
        /// 减去经销商的电子币
        /// </summary>
        /// <param name="dealerid"></param>
        /// <param name="submoney"></param>
        void SubParentEleMoney(Guid dealerid, decimal submoney);
    }
}