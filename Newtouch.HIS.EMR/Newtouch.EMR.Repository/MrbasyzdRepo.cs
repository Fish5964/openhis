﻿using Newtouch.EMR.Domain.Entity;
using Newtouch.EMR.Domain.IRepository;
using FrameworkBase.MultiOrg.Infrastructure;
using FrameworkBase.MultiOrg.Repository;

namespace Newtouch.EMR.Repository
{
    /// <summary>
    /// 创 建：chl
    /// 日 期：2020-03-13 11:29
    /// 描 述：病案首页-诊断记录
    /// </summary>
    public class MrbasyzdRepo : RepositoryBase<MrbasyzdEntity>, IMrbasyzdRepo
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="databaseFactory">EF上下文工厂</param>
        public MrbasyzdRepo(IDefaultDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
            
        }

    }
}