using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boss.DDD;
using Boss.DDD.Dtos;
using Boss.DDD.ProductRepositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Unity.Resolution;

namespace Boos.DDD.WebApi.Controllers
{
    [Route("api/Product")]
    [Produces("application/json")]
    public class ProductController : Controller
    {
        private ServiceLocator _serviceLocator = new ServiceLocator();

        [HttpPost]
        [Route("AddProduct")]
        public ResultEntity<bool> AddProduct([FromBody]AddProductSPUDto addProductSPUDto)
        {
            var result = new ResultEntity<bool>();
            var productDbContext = _serviceLocator.GetService<IProdcutContext>();

            var repository = _serviceLocator.GetService<IRepository>(new ParameterOverrides() { { "dbContext", productDbContext } });

            var productEFCoreRepository = _serviceLocator.GetService<IProductRepository>(new ParameterOverrides() { { "dbContext", productDbContext } });

            ////创建产品EF 连接上下文
            //var productDbContext = new ProdcutEFCoreContext();
            ////EF仓储
            //var repository = new EFCoreRepository(productDbContext);
            ////产品EF仓库
            //var productEFCoreRepository = new ProductEFCoreRepository(productDbContext);
            ////添加产品SPU 服务用例
            var addProductSPUUseCase = new AddProductSPUUseCase(repository, productEFCoreRepository);
            try
            {
                result = addProductSPUUseCase.AddProduct(addProductSPUDto);
                result.IsSuccess = true;
                result.Count = 1;
                result.Msg = "成功添加产品";
            }
            catch (Exception ex)
            {
                result.ErrorCode = 100;
                result.Msg = ex.Message;
            }
            return result;
        }
    }
}