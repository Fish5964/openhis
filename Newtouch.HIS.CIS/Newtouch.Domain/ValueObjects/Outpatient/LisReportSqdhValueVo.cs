﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtouch.Domain.ValueObjects.Outpatient
{
    public class LisReportSqdhValueVo
    {
        public string OrganizeId { get; set; }
        public string xm { get; set; }
        //public string xb { get; set; }
        public string lissqdh { get; set; }
        public string sqdh { get; set; }
        //public string xmCode { get; set; }
        //public string xmmc { get; set; }
        public string ztId { get; set; }
        public string ztmc { get; set; }
        public string sqsj { get; set; }
        //public decimal zje { get; set; }
        /// <summary>
        /// 申请状态 0:已申请 1:已接收 2:已完成
        /// </summary>
        public string syncStatus { get; set; }
    }

    public class LisReportSqdyczValueVo
	{
        public string Id { get; set; }
        public string sqdh { get; set; }
        public int? sqdlx { get; set; }
        public string ztmc { get; set; }
        public string xmzwmc { get; set; }
        public string xmywmc { get; set; }
        public string jyjg { get; set; }
        public string gdbj { get; set; }
        public string ckzdx { get; set; }
        public string ckzgx { get; set; }
        public string ckz { get; set; }
    }
}