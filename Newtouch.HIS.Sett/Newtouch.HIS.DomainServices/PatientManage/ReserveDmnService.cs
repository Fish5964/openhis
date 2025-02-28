﻿using FrameworkBase.MultiOrg.DmnService;
using FrameworkBase.MultiOrg.Infrastructure;
using Newtouch.Common;
using Newtouch.HIS.Domain.Entity;
using Newtouch.HIS.Domain.IDomainServices;
using Newtouch.HIS.Domain.ValueObjects;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace Newtouch.HIS.DomainServices.PatientManage
{
    public class ReserveDmnService : DmnServiceBase, IReserveDmnService
    {
        public ReserveDmnService(IDefaultDatabaseFactory databaseFactory)
          : base(databaseFactory)
        {
        }

        /// <summary>
        /// 保存账户事务
        /// </summary>
        /// <param name="vo"></param>
       public void PatAccDB(PatAccDataVO vo, SysAccountEntity zh, FinanceReceiptEntity cwsj, string type)
       {
            try
            {
            using (var db = new EFDbTransaction(this._databaseFactory).BeginTrans())
            {
                if (vo.szjl != null)
                {
                    db.Insert(vo.szjl);
                }

                //病人账户更新
                if (vo.oldzh != null)
                {
                    db.Update(zh);
                }

                //财务收据
                if (type == "insert")
                {
                    db.Insert(cwsj);  // 添加收据凭证号 
                }
                if (type == "update")
                {
                    db.Update(cwsj);  //修改收据凭证号 
                }
                db.Commit();
                }
            }
            catch (System.Exception e)
            {

                throw;
            }

            //病人账户变更日志
            if (vo.oldzh != null)
            {
                AppLogger.WriteEntityChangeRecordLog(vo.oldzh, zh, SysPatientAccountEntity.GetTableName(), vo.oldzh.zhCode.ToString());
            }
            //财务收据变更日志
            if (vo.oldcwsj != null && type == "update")
            {
                AppLogger.WriteEntityChangeRecordLog(vo.oldcwsj, cwsj, FinanceReceiptEntity.GetTableName(), vo.oldcwsj.cwsjId.ToString());
            }
        }

        /// <summary>
        /// 获取病人管理》预交金》获取账户收支记录信息
        /// </summary>
        /// <param name="zh">账户</param>
        /// <param name="zyh">住院号</param>
        /// <returns></returns>
        public List<PatAccPayVO> GetAccPayInfo(int zh, string orgId, string zhxz)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@" SELECT  a.szje ,
                            a.zhye ,
                            a.pzh ,
                            s.Name Creator ,
                            a.CreateTime ,
                            a.szxz ,
                            b.xjzffsmc ,
                            b.xjzffs,
		                    a.Id,szjl.Id tId
                    FROM    xt_zhszjl a WITH ( NOLOCK )
                            LEFT JOIN xt_xjzffs b WITH ( NOLOCK ) ON a.xjzffs = b.xjzffs
		                    LEFT JOIN NewtouchHIS_Base..V_C_Sys_UserStaff s ON               s.Account=a.CreatorCode
                            LEFT JOIN dbo.xt_zhszjl szjl ON szjl.pzh = a.pzh
                                        AND szjl.szje + a.szje = 0
                                        AND a.szje > 0
                                        AND szjl.zt = '1' ");
            var par = new List<DbParameter> {
                  new SqlParameter("@zh", zh),
                  new SqlParameter("@orgId", orgId)
            };
            if (!string.IsNullOrWhiteSpace(zhxz))
            {
                strSql.Append(@" INNER JOIN xt_zh zh WITH ( NOLOCK ) on zh.zhCode=a.zhCode and zh.zhxz=@zhxz");
                par.Add(new SqlParameter("@zhxz", zhxz));
            }
            strSql.Append(@" WHERE   a.zhCode=@zh
			                    and a.OrganizeId = @orgId AND a.zt = '1'
                                ORDER BY a.CreateTime DESC");

            return this.FindList<PatAccPayVO>(strSql.ToString(), par.ToArray());
        }
    }
}
