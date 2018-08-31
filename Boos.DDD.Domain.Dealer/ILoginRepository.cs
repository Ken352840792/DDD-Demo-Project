using Boss.DDD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    public interface ILoginRepository
    {
        void CreateLogin<T>(T login) where T : class, IAggregationRoot;

        bool UserLogin(string tel, string password);
    }
}