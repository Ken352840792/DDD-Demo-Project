using Boss.DDD.POCOModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD.ProductRepositorys
{
    /// <summary>
    /// 产品仓储实现类(其实)
    /// </summary>
    public class ProductEFCoreRepository : IProductRepository
    {
        private readonly DbContext dbContext;

        public ProductEFCoreRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateProduct<T>(T product) where T : class, IAggregationRoot
        {
            var productDbContext = this.dbContext as ProdcutEFCoreContext;
            var productspu = product as ProductSPU;
            try
            {
                productDbContext.ProductSPUs.Add(productspu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}