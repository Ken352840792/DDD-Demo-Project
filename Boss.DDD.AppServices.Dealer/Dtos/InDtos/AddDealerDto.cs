using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD.Dtos
{
    public class AddDealerDto
    {
        /// <summary>
        /// 行销商名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 剩余电子币
        /// </summary>
        public dynamic EleMoney { get; set; }

        /// <summary>
        /// 父级经销商
        /// </summary>
        public Guid? Parentid { get; set; }

        /// <summary>
        /// 联系人列表
        /// </summary>
        public List<string> ContactName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        public List<string> ContactTel { get; set; }

        public List<string> ContactSheng { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public List<string> ContactShi { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        public List<string> ContactQu { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        public List<string> ContactJiedao { get; set; }

        /// <summary>
        /// 是否默认联系人
        /// </summary>
        public List<int> ContactIsDefault { get; set; }
    }
}