using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    /// <summary>
    /// 工作单元接口
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// 提交工作单元
        /// </summary>
        void Commit();
    }
}