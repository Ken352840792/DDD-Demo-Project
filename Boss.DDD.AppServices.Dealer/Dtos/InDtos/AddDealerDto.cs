using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD.Dtos
{
    public class AddDealerDto
    {
        public string Name { get; set; }

        public string Tel { get; set; }

        public dynamic EleMoney { get; set; }

        public Guid? Parentid { get; set; }

        public List<string> ContactName { get; set; }

        public List<string> ContactTel { get; set; }

        public List<string> ContactSheng { get; set; }

        public List<string> ContactShi { get; set; }

        public List<string> ContactQu { get; set; }

        public List<string> ContactJiedao { get; set; }

        public List<int> ContactIsDefault { get; set; }
    }
}