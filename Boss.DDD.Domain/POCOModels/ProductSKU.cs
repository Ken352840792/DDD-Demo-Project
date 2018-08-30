using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Boss.DDD.POCOModels
{
    public partial class ProductSKU : IEntity
    {
        /// <summary>
        /// 产品SKU Id
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// 产品SKU 编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 产品规格（如:脉动300毫升）
        /// </summary>
        public string Spec { get; set; }

        /// <summary>
        /// 产品的单位
        /// </summary>
        public Unit Unit { get; set; }

        /// <summary>
        /// 业务PV值 (采购以后价格累加)
        /// </summary>
        public decimal PV { get; set; }

        /// <summary>
        /// 经销商采购的价格
        /// </summary>
        public decimal DealerPrice { get; set; }

        /// <summary>
        /// 产品显示图片
        /// </summary>
        public byte[] Image { get; set; }

        /// <summary>
        /// 产品的SPU ID 外键
        /// </summary>
        public Guid ProductSPUId { get; set; }

        /// <summary>
        /// 冗余SPU的名称
        /// </summary>
        public string ProductSPUName { get; set; }
    }

    public enum Unit : int
    {
        盒 = 1,
        包 = 2,
        瓶 = 3
    }
}