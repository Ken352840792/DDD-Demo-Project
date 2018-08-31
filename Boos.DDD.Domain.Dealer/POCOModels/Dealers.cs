using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Boss.DDD;

namespace Boss.DDD.POCOModels
{
    public partial class Dealers : IAggregationRoot
    {
        public string Code { get; set; }

        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// 经销商名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 经销商电话
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 剩余多少电子币
        /// </summary>
        public decimal TotalEleMoney { get; set; }

        /// <summary>
        /// 剩余多少PV币
        /// </summary>
        public decimal TotalPV { get; set; }

        /// <summary>
        /// 奖金
        /// </summary>
        public decimal JangJingMoney { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        public CardType CardType { get; set; }

        /// <summary>
        /// 经销商级别
        /// </summary>
        public Level Level { get; set; }

        /// <summary>
        /// 下级经销商个数
        /// </summary>
        public int SubCount { get; set; }

        /// <summary>
        /// 经销商的联系人
        /// </summary>
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// 经销商上下级关系
        /// </summary>
        public DealerTree DealerTree { get; set; }
    }

    public enum CardType : int
    {
        普通会员 = 1,
        银卡会员 = 2,
        金卡会员 = 3
    }

    public enum Level : int
    {
        片区经理 = 1,
        省区经理 = 2,
        大区经理 = 3,
        总部经理 = 4
    }
}