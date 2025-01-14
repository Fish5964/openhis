﻿using Newtouch.HIS.Web.Core.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Newtouch.HIS.Base.SSO.App_Start
{
    /// <summary>
    /// 全局过滤器注册
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// 
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