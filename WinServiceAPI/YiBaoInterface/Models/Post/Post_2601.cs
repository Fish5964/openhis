﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQYiBaoInterface.Models.Post
{
    public class Post_2601
    {

        /// <summary>
        /// hisId唯一his的唯一标识
        /// </summary>
        public string hisId { get; set; }

        /// <summary>
        /// 操作员代码
        /// </summary>
        public string operatorId { get; set; }

        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string operatorName { get; set; }

        /// <summary>
        ///  insuplc_admdvs 参保地医保区划 字符型  6 如果交易输入中含有人员编号，此项必填，可通过【1101】人员信息获取交易取得
        /// </summary>
        public string insuplc_admdvs { get; set; }

        /// <summary>
        /// psn_no 人员编号  字符型  30  Y
        /// </summary>
        public string psn_no { get; set; }

        /// <summary>
        ///  omsgid原发送方报文ID字符型  30  Y 
        /// </summary>
        public string omsgid { get; set; }

        /// <summary>
        /// oinfno 原交易编号  字符型  4  Y
        /// </summary>
        public string oinfno { get; set; }
    }
}