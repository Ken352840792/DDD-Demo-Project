using Boss.DDD.Dtos;
using Boss.DDD.POCOModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD.UseCases
{
    public class AddDealerUseCase : BaseAppSrv
    {
        public readonly IRepository _repository;
        public readonly IDealerRepository _dealerRepository;
        public readonly ILoginRepository _loginRepository;

        public AddDealerUseCase(IRepository repository, IDealerRepository dealerRepository, ILoginRepository loginRepository)
        {
            _repository = repository;
            _dealerRepository = dealerRepository;
            _loginRepository = loginRepository;
        }
        public ResultEntity<bool> AddDealer(AddDealerDto addDealerDto)
        {
            //内存中组织对象
            var dealerid = Guid.NewGuid();
            var dealercontact = new List<Contact>();
            for (int i = 0; i < addDealerDto.ContactName.Count; i++)
            {
                var dealercontactmodel = new Contact().CreateContact(dealerid,
                    addDealerDto.ContactName[i],
                    addDealerDto.ContactTel[i],
                    addDealerDto.ContactSheng[i],
                    addDealerDto.ContactShi[i],
                    addDealerDto.ContactQu[i],
                    addDealerDto.ContactJiedao[i],
                    addDealerDto.ContactIsDefault[i]
                    );
                dealercontact.Add(dealercontactmodel);
            }
            var dealer = new Dealers(_dealerRepository).RegisterDealers(dealerid, addDealerDto.Name, addDealerDto.Tel, addDealerDto.EleMoney, dealercontact, addDealerDto.Parentid);
            var login = new Login().CreateLogin(dealer.Tel, dealerid);
            //实际持续化到数据库中
            try
            {
                using (_repository)
                {
                    _dealerRepository.CreateDealer(dealer);
                    if (addDealerDto.Parentid != null)
                    {
                        _dealerRepository.SubParentEleMoney((Guid)addDealerDto.Parentid, addDealerDto.EleMoney);
                    }
                    _dealerRepository.AddParentSubCount(addDealerDto.Parentid);
                    _loginRepository.CreateLogin(login);
                    _repository.Commit();
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
