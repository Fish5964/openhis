﻿using FrameworkBase.MultiOrg.Infrastructure;
using Newtouch.Core.Common;
using Newtouch.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Newtouch.Herp.Infrastructure
{
    /// <summary>
    /// 常用到的（放Repo、DmnService都不合适的，但又要请求数据库的）
    /// 比如获取唯一编号（自增，但有不能重复）
    /// </summary>
    public class EFDBBaseFuncHelper
    {
        private EFDBBaseFuncHelper(IDatabaseFactory databaseFactory)
        {
            this._databaseFactory = databaseFactory;
        }
        private IDatabaseFactory _databaseFactory;

        /// <summary>
        /// 默认DB上下文
        /// </summary>
        public static EFDBBaseFuncHelper Instance
        {
            get
            {
                IDatabaseFactory databaseFactory
                    = DependencyDefaultInstanceResolver.GetInstance<IDefaultDatabaseFactory>();
                return new EFDBBaseFuncHelper(databaseFactory);
            }
        }

        /// <summary>
        /// 指定DB上下文
        /// </summary>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public static EFDBBaseFuncHelper GetInstance(EnumDBFactoryType? dbType = null)
        {
            if (!dbType.HasValue)
            {
                dbType = EnumDBFactoryType.DefaultDB;  //默认
            }
            IDatabaseFactory databaseFactory = null;
            switch (dbType)
            {
                case EnumDBFactoryType.DefaultDB:
                    databaseFactory = DependencyDefaultInstanceResolver.GetInstance<IDefaultDatabaseFactory>();
                    break;
            }
            return new EFDBBaseFuncHelper(databaseFactory);
        }

        #region 方法
        //-------------------------------------示例------------------------------------------------
        ///// <summary>
        ///// 获取主键字段唯一Id
        ///// </summary>
        ///// <param name="tableName"></param>
        ///// <returns></returns>
        //public string GetNewPrimaryKeyString(string tableName)
        //{
        //    var sqlParList = new List<SqlParameter>();
        //    sqlParList.Add(new SqlParameter("@tableName", tableName));
        //    var outParameter = new SqlParameter("@NumStr", System.Data.SqlDbType.VarChar, 8);
        //    outParameter.Direction = System.Data.ParameterDirection.Output;
        //    sqlParList.Add(outParameter);
        //    _databaseFactory.Get().Database.ExecuteSqlCommand("exec spGetNewID @tableName, @NumStr out", sqlParList.ToArray());
        //    return outParameter.Value.ToString();
        //}

        /// <summary>
        /// 获取 字段/业务 唯一值
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public string GetNewFieldUniqueValue(string fieldName, string orgId, string initFormat = "", bool dateFlag = false)
        {
            var sqlParList = new List<SqlParameter>
            {
                new SqlParameter("@OrganizeId", orgId),
                new SqlParameter("@TopOrganizeId", Constants.TopOrganizeId),
                new SqlParameter("@FieldName", fieldName),
                new SqlParameter("@DateFlag", dateFlag),
                new SqlParameter("@currDate", DateTime.Now.ToString("yyyyMMdd")),
                new SqlParameter("@InitFormat", initFormat)
            };

            var outParameter1 = new SqlParameter("@NumStr", System.Data.SqlDbType.VarChar, 50)
            {
                Direction = System.Data.ParameterDirection.Output
            };
            sqlParList.Add(outParameter1);
            var outParameter2 = new SqlParameter("@Format", System.Data.SqlDbType.VarChar, 50)
            {
                Direction = System.Data.ParameterDirection.Output
            };
            sqlParList.Add(outParameter2);
            _databaseFactory.Get().Database.ExecuteSqlCommand("exec spFieldGetNewID  @OrganizeId, @TopOrganizeId, @FieldName, @DateFlag, @currDate, @InitFormat, @NumStr out, @Format out", sqlParList.ToArray());

            if (outParameter2.Value == null || string.IsNullOrWhiteSpace(outParameter2.Value.ToString()))
            {
                return outParameter1.Value.ToString();
            }
            return string.Format(outParameter2.Value.ToString(), Convert.ToInt32(outParameter1.Value));
        }

        #endregion
    }
    /// <summary>
    /// 上下文 类型
    /// </summary>
    public enum EnumDBFactoryType
    {
        DefaultDB,
    }
}