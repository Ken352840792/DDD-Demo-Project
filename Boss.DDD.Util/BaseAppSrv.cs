using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    /// <summary>
    /// 基本服务对象
    /// </summary>
    public class BaseAppSrv
    {
        protected ResultEntity<T> GetResultEntity<T>(T vobj, string msg = "未成功获取到对象", int errorCode = 0)
        {
            var result = new ResultEntity<T>();
            var isSuccess = true;
            if (vobj is int && Convert.ToInt32(vobj) <= 0)
            {
                isSuccess = false;
            }
            else if (vobj is bool && !Convert.ToBoolean(vobj))
            {
                isSuccess = false;
            }
            else if (vobj is string && string.IsNullOrEmpty(Convert.ToString(vobj)))
            {
                isSuccess = false;
            }
            if (!isSuccess)
            {
                result.Msg = msg;
                result.ErrorCode = 200;
            }
            result.IsSuccess = isSuccess;
            result.Data = vobj;
            return result;
        }
    }
}