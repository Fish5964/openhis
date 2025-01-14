﻿using System;
using System.Threading;
using Newtouch.HIS.Domain.DTO.OutputDto;
using Newtouch.HIS.Domain.ValueObjects.OutpatientManage;
using Newtouch.HIS.Repository;

namespace Newtouch.HIS.Application.Strategy.MzBespeakRegister
{
    /// <summary>
    /// 普通门诊
    /// </summary>
    public class GeneralBespeakStrategy : ICommitStrategy
    {
        #region 单例
        private static GeneralBespeakStrategy _instance;
        private GeneralBespeakStrategy()
        {
        }
        public static GeneralBespeakStrategy Instance()
        {
            return _instance ?? (_instance = new GeneralBespeakStrategy());
        }

        #endregion

        private string mzyyghId;
        private string userCode;

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="cts"></param>
        /// <param name="request"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool Process(CancellationTokenSource cts, dynamic request, ActResult result)
        {
            try
            {
                mzyyghId = "";
                userCode = "";
                var mzBespeakRegister = request as MzBespeakRegisterVO;
                //预约挂号是否排班 未排班的放过               
                if (mzBespeakRegister.bespeakRegSchedulingDetail == null || mzBespeakRegister.bespeakRegSchedulingDetail.Count <= 0) return true; //该科室没有排班，可以直接挂号
                //是否预约 有预约的放过
                var todayDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                if (mzBespeakRegister.bespeakRegDetail != null && mzBespeakRegister.bespeakRegDetail.Count > 0) //有预约
                {
                    var data = mzBespeakRegister.bespeakRegDetail.FindAll(p => p.regDate == todayDate && p.ksCode == mzBespeakRegister.registerInfo.ksCode && p.ysgh == "" && (p.arrivalDate == null || p.arrivalDate <= Convert.ToDateTime("1971-01-01")));
                    if (data != null && data.Count > 0)
                    {
                        mzyyghId = data[0].mzyyghId;
                        userCode = mzBespeakRegister.userCode;
                        return true; //预约过
                    }
                }

                //没有预约
                if (mzBespeakRegister.alreadyBespeakRegisterCount >= mzBespeakRegister.allBespeakMaxCount)
                {
                    //有预约排班，当前患者未预约当前科室，且预约已满
                    result.IsSucceed = false;
                    result.ResultMsg = "该科室预约已满，确定继续挂号吗？";
                    return false;
                }
                if ((mzBespeakRegister.alreadyBespeakRegisterCount + mzBespeakRegister.alreadyRegisterCount) >= mzBespeakRegister.allBespeakMaxCount)
                {
                    //有预约排班，当前患者未预约当前科室，预约未满，但已挂号挂号数+已预约数>=可预约总数
                    result.IsSucceed = false;
                    result.ResultMsg = "该科室挂号已满，确定继续挂号吗？";
                    return false;
                }
                return true; //预约人数 + 实际已挂号人数 < 支持预约最大人数，可以继续挂号

            }
            catch (Exception ex)
            {
                cts.Cancel();
                result.IsSucceed = false;
                result.ResultMsg = ex.ToString();
                return false;
            }
        }

        /// <summary>
        /// 后处理
        /// </summary>
        /// <param name="cts"></param>
        /// <param name="request"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool After(CancellationTokenSource cts, dynamic request, ActResult result)
        {
            if (!string.IsNullOrWhiteSpace(mzyyghId))
            {
                result.Data = mzyyghId;
            }
            return true;
        }
    }
}
