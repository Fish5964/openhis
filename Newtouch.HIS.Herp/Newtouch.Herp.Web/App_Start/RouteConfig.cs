﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Newtouch.Herp.Web
{
    /// <summary>
    /// 路由注册
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// 路由注册
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
        }
    }

}