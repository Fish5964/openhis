﻿using Autofac;
using Newtouch.HIS.API.Common.Models;

namespace Newtouch.HIS.Base.HOSP.API
{
    /// <summary>
    /// API Controll 基类
    /// </summary>
    public class ApiControllerBase<TControllerType> : FrameworkBase.API.ApiControllerBase<TControllerType>
    {
        public ApiControllerBase(IComponentContext com)
            : base(com)
        {
        }

        /// <summary>
        /// 用户身份
        /// </summary>
        public UserIdentity UserIdentity
        {
            get
            {
                return this.Identity as UserIdentity;
            }
        }
        //public TPAuthIdentity TpIdentity
        //{
        //    get
        //    {
        //        return this.TpIdentity as TPAuthIdentity;
        //    }
        //}

    }

}
