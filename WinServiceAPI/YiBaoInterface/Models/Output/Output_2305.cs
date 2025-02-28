﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQYiBaoInterface.Models.Output
{
    public class Output_2305 : OutputBase
    {
        public setlinfo2305 setlinfo { get; set; }

        /// <summary>
        ///  输出-结算基金分项信息（节点标识：setldetail）
        /// </summary>
        public List<setldetail> setldetail { get; set; }
    }
    public class setlinfo2305
    {
        /// <summary>
        /// 1|就诊ID|字符型|30|  |Y|  
        /// </summary> 
        public string mdtrt_id { get; set; }

        /// <summary>
        /// 2|结算ID|字符型|30||Y|
        /// </summary> 
		public string setl_id { get; set; }

        /// <summary>
        /// 3|清算经办机构|字符型|6||  |
        /// </summary> 
		public string clr_optins { get; set; }

        /// <summary>
        /// 4|结算时间|日期时间型|  |  |Y|yyyy-MM-dd HH:mm:ss
        /// </summary> 
		public string setl_time { get; set; }

        /// <summary>
        /// 5|医疗费总额|数值型|16,2|  |Y|  
        /// </summary> 
		public string medfee_sumamt { get; set; }

        /// <summary>
        /// 6|全自费金额|数值型|16,2|  |Y|  
        /// </summary> 
        public string fulamt_ownpay_amt { get; set; }

        /// <summary>
        /// 7|超限价自费费用|数值型|16,2|  |Y|  
        /// </summary> 
        public string overlmt_selfpay { get; set; }

        /// <summary>
        /// 8|先行自付金额|数值型|16,2|  |Y|  
        /// </summary> 
		public string preselfpay_amt { get; set; }

        /// <summary>
        /// 9|符合政策范围金额|数值型|16,2|  |Y|  
        /// </summary> 
		public string inscp_scp_amt { get; set; }

        /// <summary>
        /// 10|实际支付起付线|数值型|16,2|  |  |  
        /// </summary> 
		public string act_pay_dedc { get; set; }

        /// <summary>
        /// 11|基本医疗保险统筹基金支出|数值型|16,2|  |Y|  
        /// </summary> 
        public string hifp_pay { get; set; }

        /// <summary>
        /// 12|基本医疗保险统筹基金支付比例|数值型|5,4|  |Y|  
        /// </summary> 
        public string pool_prop_selfpay { get; set; }

        /// <summary>
        /// 13|公务员医疗补助资金支出|数值型|16,2|  |Y|  
        /// </summary> 
		public string cvlserv_pay { get; set; }

        /// <summary>
        /// 14|企业补充医疗保险基金支出|数值型|16,2|  |Y  |  
        /// </summary> 
        public string hifes_pay { get; set; }

        /// <summary>
        /// 15|居民大病保险资金支出|数值型|16,2|  |Y  |  
        /// </summary> 
        public string hifmi_pay { get; set; }

        /// <summary>
        /// 16|职工大额医疗费用补助基金支出|数值型|16,2|  |Y  |  
        /// </summary> 
        public string hifob_pay { get; set; }

        /// <summary>
        /// 17|医疗救助基金支出|数值型|16,2|  |Y  |  
        /// </summary> 
        public string maf_pay { get; set; }

        /// <summary>
        /// 18|其他支出|数值型|16,2|  |Y  |  
        /// </summary> 
        public string oth_pay { get; set; }

        /// <summary>
        /// 19|基金支付总额|数值型|16,2|  |Y|  
        /// </summary> 
        public string fund_pay_sumamt { get; set; }

        /// <summary>
        /// 20|个人负担总金额|数值型|16,2|  ||  
        /// </summary> 
		public string psn_part_amt { get; set; }

        /// <summary>
        /// 21|个人账户支出|数值型|16,2|  |Y|  
        /// </summary> 
        public string acct_pay { get; set; }

        /// <summary>
        /// 22|个人现金支出|数值型|16,2|  |Y|  
        /// </summary> 
        public string psn_cash_pay { get; set; }

        /// <summary>
        /// 23|医院负担金额|数值型|16,2|||
        /// </summary> 
        public string hosp_part_amt { get; set; }

        /// <summary>
        /// 24|余额|数值型|16,2||Y|
        /// </summary> 
		public string balc { get; set; }

        /// <summary>
        /// 25|个人账户共济支付金额|数值型|16,2||Y|
        /// </summary> 
        public string acct_mulaid_pay { get; set; }

        /// <summary>
        /// 26|医药机构结算ID|字符型|30||Y|存放发送方报文ID
        /// </summary> 
		public string medins_setl_id { get; set; }

        /// <summary>
        /// 27|伤残人员医疗保障基金支出|字符型|16，2|||
        /// </summary> 
		public string hifdm_pay { get; set; }

    }
    /*
    public class setldetail
    {

        /// <summary>
        /// 1|基金支付类型|字符型|6|Y  |Y  |  
        /// </summary> 
        public string fund_pay_type { get; set; }

        /// <summary>
        /// 2|符合政策范围金额|数值型|16,2|  |Y  |  
        /// </summary> 
		public string inscp_scp_amt { get; set; }

        /// <summary>
        /// 3|本次可支付限额金额|数值型|16,2|  |Y  |  
        /// </summary> 
		public string crt_payb_lmt_amt { get; set; }

        /// <summary>
        /// 4|基金支付金额|数值型|16,2|  |Y  |  
        /// </summary> 
		public string fund_payamt { get; set; }

        /// <summary>
        /// 5|基金支付类型名称|字符型|200|||
        /// </summary> 
		public string fund_pay_type_name { get; set; }

        /// <summary>
        /// 6|结算过程信息|字符型|4000|  |  |  
        /// </summary> 
		public string setl_proc_info { get; set; }

    }
    */

}
