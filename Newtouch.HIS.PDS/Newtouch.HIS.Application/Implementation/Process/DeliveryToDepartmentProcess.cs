﻿using System;
using System.Collections.Generic;
using Newtouch.Core.Common.Exceptions;
using Newtouch.HIS.Domain.DTO.OutOrInStoredOperate;
using Newtouch.HIS.Domain.Entity;
using Newtouch.HIS.Domain.IDomainServices;
using Newtouch.Infrastructure;
using Newtouch.PDS.Requset;

namespace Newtouch.HIS.Application.Implementation.Process
{
    /// <summary>
    /// 科室发药
    /// </summary>
    public class DeliveryToDepartmentProcess : ProcessorFun<DjInfoDTO>
    {
        private SysMedicineStorageIOReceiptEntity djmain;
        private List<SysMedicineStorageIOReceiptDetailEntity> djmx;
        private readonly IDeliveryToDepartmentDmnService _deliveryToDepartmentDmnService;

        public DeliveryToDepartmentProcess(DjInfoDTO request) : base(request)
        {
        }

        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        protected override ActResult Validata()
        {
            if (Request == null)
            {
                throw new FailedException("单据信息不能为空");
            }
            if (Request.mx == null || Request.mx.Count <= 0)
            {
                throw new FailedException("单据明细不能为空");
            }
            return new ActResult();
        }

        /// <summary>
        /// 预处理
        /// </summary>
        protected override void BeforeAction(ActResult actResult)
        {
            djmain = new SysMedicineStorageIOReceiptEntity
            {
                Ckbm = Request.ckbm,
                Cksj = DateTime.Now,
                Shczy = UserIdentity.UserCode,
                Ckczy = UserIdentity.UserCode,
                CreateTime = DateTime.Now,
                CreatorCode = UserIdentity.UserCode,
                Crkfsdm = Request.fyfs,
                Czsj = DateTime.Now,
                djlx = Request.djlx,
                OrganizeId = OrganizeId,
                Pdh = Request.djh,
                Rkbm = Request.rkbm,
                px = null,
                shzt = ((int)EnumDjShzt.Approved).ToString(),
                Sqsj = DateTime.Now,
                zt = "1"
            };
            djmain.Create(true, Guid.NewGuid().ToString());
            djmx = new List<SysMedicineStorageIOReceiptDetailEntity>();
            Request.mx.ForEach(p =>
            {
                var item = new SysMedicineStorageIOReceiptDetailEntity
                {
                    cd = null,
                    Ckbmkc = p.ckbmkc ?? 0,
                    Ckzhyz = p.ckzhyz ?? 0,
                    ckdw = p.ckdw,
                    CreateTime = DateTime.Now,
                    CreatorCode = UserIdentity.UserCode,
                    crkId = djmain.crkId,
                    jj = p.jj,
                    Lsj = p.lsj,
                    pc = p.pc,
                    Pfj = p.pfj,
                    Ph = p.ph,
                    Sl = p.sl,
                    Thyy = "",
                    Yklsj = p.yklsj,
                    Ykpfj = p.ykpfj,
                    Ypdm = p.ypdm,
                    Yxq = p.yxq,
                    Zje = p.zje,
                    zt = "1"
                };
                item.Create(true, Guid.NewGuid().ToString());
                djmx.Add(item);
            });
        }

        /// <summary>
        /// 主处理
        /// </summary>
        /// <returns></returns>
        protected override void Action(ActResult actResult)
        {
            var result = _deliveryToDepartmentDmnService.SubmitDeliveryToDepartment(djmain, djmx);
            if (!string.IsNullOrWhiteSpace(result))
            {
                actResult.IsSucceed = false;
                actResult.ResultMsg = result;
            }
        }
    }
}
