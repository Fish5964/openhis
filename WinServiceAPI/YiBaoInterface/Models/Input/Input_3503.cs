﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQYiBaoInterface.Models.Input
{
   public class Input_3503:InputBase
    {
        public purcinfo3503 purcinfo { get; set; }
    }

    public class purcinfo3503
    {
        public string med_list_codg { get; set; }
        public string fixmedins_hilist_id { get; set; }
        public string fixmedins_hilist_name { get; set; }
        public string dynt_no { get; set; }
        public string fixmedins_bchno { get; set; }
        public string spler_name { get; set; }
        public string spler_pmtno { get; set; }
        public string manu_lotnum { get; set; }
        public string prodentpName { get; set; }
        public string prodentp_name { get; set; }
        public string aprvno { get; set; }
        public string manu_date { get; set; }
        public string expy_end { get; set; }
        public string finl_trns_pric { get; set; }
        public string purc_retn_cnt { get; set; }
        public string purc_invo_codg { get; set; }
        public string purc_invo_no { get; set; }
        public string rx_flag { get; set; }
        public string purc_retn_stointime { get; set; }
        public string purc_retn_stoin_time { get; set; }
        public string purc_retn_opter_name { get; set; }
        public string prod_geay_flag { get; set; }
        public string memo { get; set; }
        public string spec { get; set; }
        public string min_pacunt { get; set; }
        public string pac_cnt { get; set; }
        public string pacunt { get; set; }
        public string rtal_pric { get; set; }

    }
}
