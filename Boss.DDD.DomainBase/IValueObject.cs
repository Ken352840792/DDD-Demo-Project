using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    /// <summary>
    /// 值对象接口
    /// </summary>
    public interface IValueObject
    {
        Guid Id { get; set; }
    }
}