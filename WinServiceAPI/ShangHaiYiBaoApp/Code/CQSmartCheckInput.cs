﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QHDYiBaoInterface.Models
{
    public class QHDSmartCheckInput
    {
        public string jydm { get; set; }
        public string xmldata { get; set; }
        public string jsondata { get; set; }
    }

    public class LisReportInput
    {
        public string type { get; set; }
        /// <summary>
        /// LIS 数据库连接字符串
        /// </summary>
        public string Ado_lis { get; set; }
        /// <summary>
        /// LIS 病人 ID
        /// </summary>
        public string brxx_id { get; set; }
        public string brxx_tmh { get; set; }
        public string zydj_id { get; set; }
    }
}