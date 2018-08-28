using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boss.DDD;
using Boss.DDD.Dtos;
using Boss.DDD.ProductRepositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Boos.DDD.WebApi.Controllers
{
    [Route("api/Product")]
    [Produces("application/json")]
    public class ProductController : Controller
    {
        [HttpPost]
        [Route("AddProduct")]
        public ResultEntity<bool> AddProduct([FromBody]AddProductSPUDto addProductSPUDto)
        {
            var result = new ResultEntity<bool>();
            var productDbContext = new ProdcutEFCoreContext();
            var repository = new EFCoreRepository(productDbContext);
            var productEFCoreRepository = new ProductEFCoreRepository(productDbContext);
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