using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Boss.DDD
{
    /// <summary>
    /// AppSetting 配置的读写
    /// </summary>
    public class AppSetting
    {
        private static IConfigurationSection _appsections = null;

        /// <summary>
        /// 设置AppSetting
        /// </summary>
        /// <param name="configurationSection"></param>
        public static void SetAppSetting(IConfigurationSection configurationSection)
        {
            _appsections = configurationSection;
        }

        /// <summary>
        /// 获取AppSetting 配置
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppSetting(string key)
        {
            string str = "";
            if (_appsections.GetSection(key) != null)
            {
                str = _appsections.GetSection(key).Value;
            }
            return str;
        }
    }
}