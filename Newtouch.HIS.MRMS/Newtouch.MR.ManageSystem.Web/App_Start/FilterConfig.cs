﻿using Newtouch.HIS.Web.Core.ActionFilters;
using System.Web.Mvc;

namespace Newtouch.MR.ManageSystem.Web
{
    /// <summary>
    /// 全局过滤器注册
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// 全局过滤器注册
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //系统访问统计跟踪日志
            filters.Add(new StatisticsTrackerAttribute());

            //全局异常捕获
            filters.Add(new HandlerErrorAttribute());


        }
    }

}