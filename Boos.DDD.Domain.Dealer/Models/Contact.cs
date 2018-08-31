using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD.POCOModels
{
    public partial class Contact
    {
        public Contact CreateContact(Guid dealerid, string name, string tel, string sheng, string shi, string qu, string jiedao, int isdefault)
        {
            this.DealersId = dealerid;
            this.ContactName = name;
            this.ContactTel = tel;
            this.sheng = sheng;
            this.shi = shi;
            this.qu = qu;
            this.jiedao = jiedao;
            this.IsDefaultContact = isdefault == 1 ? IsDefaultContact.默认 : IsDefaultContact.非默认;
            return this;
        }
    }
}