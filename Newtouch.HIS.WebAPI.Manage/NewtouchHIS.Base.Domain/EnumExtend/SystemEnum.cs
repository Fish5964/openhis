﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtouchHIS.Base.Domain.EnumExtend
{
    /// <summary>
    /// 日志记录类型
    /// </summary>
    public enum DbLogType
    {
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other = 0,
        /// <summary>
        /// 登录
        /// </summary>
        [Description("登录")]
        Login = 1,
        /// <summary>
        /// 退出
        /// </summary>
        [Description("退出")]
        Exit = 2,
        /// <summary>
        /// 访问
        /// </summary>
        [Description("访问")]
        Visit = 3,
        /// <summary>
        /// 新增
        /// </summary>
        [Description("新增")]
        Create = 4,
        /// <summary>
        /// 删除
        /// </summary>
        [Description("删除")]
        Delete = 5,
        /// <summary>
        /// 修改
        /// </summary>
        [Description("修改")]
        Update = 6,
        /// <summary>
        /// 提交
        /// </summary>
        [Description("提交")]
        Submit = 7,
        /// <summary>
        /// 异常
        /// </summary>
        [Description("异常")]
        Exception = 8,
    }

    /// <summary>
    /// 菜单目标类型
    /// </summary>
    public enum EnumModuleTargetType
    {
        /// <summary>
        /// 无页面
        /// </summary>
        expand,
        /// <summary>
        /// 框架页
        /// </summary>
        iframe,
        /// <summary>
        /// 弹出页
        /// </summary>
        open,
        /// <summary>
        /// 新窗口
        /// </summary>
        blank,
        /// <summary>
        /// 子页面（不显示在菜单中）
        /// </summary>
        subpage,
        /// <summary>
        /// 当前窗口
        /// </summary>
        toplocation,
    }


    public enum EnumDBJoinFuncType
    {
        Equals=1
    }
}
