using Boss.DDD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD.POCOModels
{
    public partial class Contact : IValueObject
    {
        public Contact()
        {
        }

        public Guid Id { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        public string ContactTel { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string sheng { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string shi { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        public string qu { get; set; }

        /// <summary>
        /// 街道地址
        /// </summary>
        public string jiedao { get; set; }

        public IsDefaultContact IsDefaultContact { get; set; }

        public Guid DealersId { get; set; }
    }

    public enum IsDefaultContact : int
    {
        默认 = 1,
        非默认 = 2
    }
}