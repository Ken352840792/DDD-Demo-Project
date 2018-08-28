using Boss.DDD.Dtos;
using Boss.DDD.POCOModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    /// <summary>
    /// 添加产品SPU 服务用例
    /// </summary>
    public class AddProductSPUUseCase : BaseAppSrv
    {
        private readonly IRepository _repositoryContext;
        private readonly IProductRepository _productRepository;

        public AddProductSPUUseCase(IRepository repositoryContext, IProductRepository productRepository)
        {
            _repositoryContext = repositoryContext;
            _productRepository = productRepository;
        }

        public ResultEntity<bool> AddProduct(AddProductSPUDto addProductSPUDto)
        {
            var productSPUGuid = Guid.NewGuid();
            var productSKU = new List<ProductSKU>();
            int index = 0;
            addProductSPUDto.SKUSpecs.ForEach((a) =>
            {
                productSKU.Add(new ProductSKU().CreateProductSKU(addProductSPUDto.SPUName, productSPUGuid,
                    addProductSPUDto.SKUImages[index], addProductSPUDto.SKUDealerPrices[index],
                    addProductSPUDto.SKUPV[index], addProductSPUDto.SKUUnits[index], addProductSPUDto.SKUSpecs[index]));
            });
            var productSPU = new ProductSPU().CreateProductSPU(productSPUGuid, addProductSPUDto.SPUName, addProductSPUDto.SPUDes, productSKU);
            try
            {
                using (_repositoryContext)
                {
                    _productRepository.CreateProduct(productSPU);
                    _repositoryContext.Commit();
                }
                return GetResultEntity(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}