using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Boss.DDD.Dtos;
using Unity.Resolution;
using Boss.DDD.UseCases;
using Boss.DDD.DealerRepositorys;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Boss.DDD.WebApi.Dealer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class DealerController : Controller
    {
        //private ServiceLocator _serviceLocator = new ServiceLocator();
        [HttpPost]
        [Route("AddDealer")]
        public ResultEntity<bool> AddDealer([FromBody] AddDealerDto addDealerDto)
        {
            var result = new ResultEntity<bool>();
            //创建经销商EF 连接上下文
            var dealerEFCoreContext = new DealerEFCoreContext();
            //EF仓储
            var repository = new EFCoreRepository(dealerEFCoreContext);
            //经销商EF仓库
            var dealerEFCoreRepository = new DealerEFCoreRepository(dealerEFCoreContext);
            //经销商登陆仓库
            var loginEFCoreRepository = new LoginEFCoreRepository(dealerEFCoreContext);
            AddDealerUseCase addDealerUseCase = new AddDealerUseCase(repository, dealerEFCoreRepository, loginEFCoreRepository);
            try
            {
                result = addDealerUseCase.AddDealer(addDealerDto);
                result.IsSuccess = true;
                result.Count = 1;
                result.Msg = "经销商注册成功";
            }
            catch (OverTwoSubExeption ex) {
                result.IsSuccess = false;
                result.Msg = ex.Message;
                result.ErrorCode = 300;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Msg = ex.Message;
                result.ErrorCode = 200;
            }
            return result;
        }
    }
}
