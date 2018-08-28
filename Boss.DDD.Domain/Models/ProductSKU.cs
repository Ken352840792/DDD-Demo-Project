using System;

namespace Boss.DDD.POCOModels
{
    /// <summary>
    /// 产品SKU 逻辑
    /// </summary>
    public partial class ProductSKU
    {
        public ProductSKU CreateProductSKU(string productspuname, Guid proudctspuguid, byte[] image, decimal dealerprice, decimal pv, string unit, string spec)
        {
            this.Id = Guid.NewGuid();
            this.ProductSPUId = proudctspuguid;
            this.Code = "Code " + productspuname;
            this.ProductSPUName = productspuname;
            this.Image = image;
            this.DealerPrice = dealerprice;
            this.PV = pv;
            switch (unit)
            {
                case "盒":
                    this.Unit = Unit.盒;
                    break;

                case "包":
                    this.Unit = Unit.包;
                    break;

                case "瓶":
                    this.Unit = Unit.瓶;
                    break;
            }
            return this;
        }
    }
}