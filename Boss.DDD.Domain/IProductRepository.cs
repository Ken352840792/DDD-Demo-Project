using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    public interface IProductRepository
    {
        void CreateProduct<T>(T product) where T : class, IAggregationRoot;
    }
}