using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD.POCOModels
{
    /// <summary>
    /// 产品SPU 逻辑
    /// </summary>
    public partial class ProductSPU
    {
        public ProductSPU CreateProductSPU(Guid id, string spuname, string spudes, List<ProductSKU> productSKUs)
        {
            this.Id = id;
            this.Code = "Code " + spuname;
            this.ProductSPUName = spuname;
            this.ProductSPUDes = spudes;
            this.ProductSKUS = productSKUs;
            return this;
        }
    }
}