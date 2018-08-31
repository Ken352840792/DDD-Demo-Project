using Boss.DDD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD.POCOModels
{
    public partial class DealerTree
    {
        private readonly IDealerRepository _dealerRepository;

        public DealerTree(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        public DealerTree CreateDealerTree(Guid? parentdealerid, Guid dealerid)
        {
            this.Id = Guid.NewGuid();
            this.DealerId = dealerid;
            this.ParentDealerId = parentdealerid;
            this.Layer = parentdealerid == null ? 1 : _dealerRepository.GetParentDealerLayer((Guid)parentdealerid) + 1;
            return this;
        }
    }
}