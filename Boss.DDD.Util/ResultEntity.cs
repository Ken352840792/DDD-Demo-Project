using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    /// <summary>
    /// 接口返回值对象
    /// </summary>
    /// <typeparam name="T">可以为List OR Obj</typeparam>
    public class ResultEntity<T>
    {
        /// <summary>
        /// 是否返回成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 返回消息内容
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// 返回数据条数
        /// </summary>
        public int Count { get; set; }
    }
}