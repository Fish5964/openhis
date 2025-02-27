﻿using System.Web.Mvc;

namespace Newtouch.MRQC.Web.Areas.SystemManage
{
    public class SystemManageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SystemManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "SystemManage_default",
                "SystemManage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
                , new[] { "Newtouch.MRQC.Web.Areas.SystemManage.Controllers", "FrameworkBase.MultiOrg.Web.Areas.SystemManage.Controllers" } //指定命名空间
            );
        }
    }
}