using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Boss.DDD;

namespace Boss.DDD.POCOModels
{
    public partial class Login : IAggregationRoot
    {
        public Login()
        {
        }

        /// <summary>
        /// 登陆的电话号码(说白了，就是吧CODE利用起来)
        /// </summary>
        public string Code { get; set; }

        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }

        /// <summary>
        /// 经销商的ID（跟经销商不再同一个聚合中,只是有一个字段存储而已）
        /// </summary>
        public Guid DealerId { get; set; }
    }
}