﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQYiBaoInterface.Models.Output
{
   public class Output_2501:OutputBase
    {
        public result2501 result { get; set; }
    }
    public class result2501
    {
        /// <summary>
        /// 1|待遇申报明细流水号|字符型|30||Y|
        /// </summary> 
        public string trt_dcla_detl_sn { get; set; }
    }
}