using Boss.DDD;
using System;

namespace Boss.DDD.POCOModels
{
    public partial class Login
    {
        public Login CreateLogin(string code, Guid dealerid)
        {
            this.Id = Guid.NewGuid();
            this.Code = code;
            this.PassWord = MD5Encrption.GetMD5Str("111111");
            this.DealerId = dealerid;
            return this;
        }
    }
}