using Boss.DDD.Dtos.InDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD.Querys
{
    public class UserLoginQuery:BaseAppSrv
    {
        private readonly IRepository _repository;
        private readonly ILoginRepository _loginRepository;

        public UserLoginQuery(IRepository repository, ILoginRepository loginRepository)
        {
            _repository = repository;
            _loginRepository = loginRepository;
        }
        public bool Login(UserLoginDto userLoginDto) {
            try
            {
                using (_repository)
                {
                    return _loginRepository.UserLogin(userLoginDto.TelPhone, userLoginDto.PassWord);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
