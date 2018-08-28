using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    /// <summary>
    /// 实体接口
    /// </summary>
    public interface IEntity
    {
        string Code { get; set; }
        Guid Id { get; set; }
    }
}