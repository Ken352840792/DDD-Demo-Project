using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Boss.DDD.POCOModels
{
    /// <summary>
    /// 产品主要信息
    /// </summary>
    public partial class ProductSPU : IAggregationRoot
    {
        /// <summary>
        /// 产品Id
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [Required(ErrorMessage = "必须有SPU代码")]
        [MaxLength(500, ErrorMessage = "产品SPU代码长度过长")]
        public string Code { get; set; }

        /// <summary>
        /// 产品SPU名称
        /// </summary>
        public string ProductSPUName { get; set; }

        /// <summary>
        /// 产品SPU详细
        /// </summary>
        public string ProductSPUDes { get; set; }

        /// <summary>
        /// 保证聚合根对象与值对象的关系，在一次事务的提交中一起
        /// </summary>
        public List<ProductSKU> ProductSKUS { get; set; }
    }
}