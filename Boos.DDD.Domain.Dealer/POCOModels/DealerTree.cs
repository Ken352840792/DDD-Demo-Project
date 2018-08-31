using Boss.DDD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD.POCOModels
{
    public partial class DealerTree : IValueObject
    {
        public DealerTree()
        {
        }

        public Guid Id { get; set; }

        /// <summary>
        /// 经销商的ID
        /// </summary>
        public Guid DealerId { get; set; }

        /// <summary>
        /// 父经销商ID
        /// </summary>
        public Guid? ParentDealerId { get; set; }

        /// <summary>
        /// 当前经销商的层次
        /// </summary>
        public int Layer { get; set; }
    }
}