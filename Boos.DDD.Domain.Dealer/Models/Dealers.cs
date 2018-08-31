using System;
using System.Collections.Generic;
using System.Text;
using Boss.DDD;

namespace Boss.DDD.POCOModels
{
    public partial class Dealers
    {
        private readonly IDealerRepository _dealerRepository;

        public Dealers(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        public Dealers RegisterDealers(Guid id, string name, string tel, decimal telmoney, List<Contact> contacts, Guid? parentid)
        {
            this.Id = id;
            this.Code = "Code " + name;
            this.Name = name;
            this.Tel = tel;
            this.TotalEleMoney = telmoney;
            if (telmoney < 2000)
            {
                this.CardType = CardType.普通会员;
            }
            else if (telmoney < 4000)
            {
                this.CardType = CardType.银卡会员;
            }
            else
            {
                this.CardType = CardType.金卡会员;
            }

            this.TotalPV = 0;
            this.SubCount = 0;
            this.JangJingMoney = 0;
            this.Contacts = contacts;
            this.DealerTree = new DealerTree(_dealerRepository).CreateDealerTree(parentid, id);
            return this;
        }
    }
}