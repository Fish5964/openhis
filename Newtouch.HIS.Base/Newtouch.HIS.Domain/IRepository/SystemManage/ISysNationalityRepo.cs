﻿using Newtouch.HIS.Domain.Entity;
using System.Collections.Generic;

namespace Newtouch.HIS.Domain.IRepository
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISysNationalityRepo : IRepositoryBase<SysNationalityEntity>
    {
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        IList<SysNationalityEntity> GetList(string keyword);

        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        SysNationalityEntity GetForm(int keyValue);

        /// <summary>
        /// 提交保存
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="keyValue"></param>
        void SubmitForm(SysNationalityEntity entity, int? keyValue);
    }
}