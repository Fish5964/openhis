﻿namespace Newtouch.HIS.Domain.DTO.OutPatientPharmacy
{
    /// <summary>
    /// 处方明细
    /// </summary>
    public class OutPatientpyCfmxDTO
    {
        public string sffymxxh { get; set; }
        public string yp { get; set; }
        public string ypmc { get; set; }
        public string ypgg { get; set; }
        public string ycmc { get; set; }
        public decimal sl { get; set; }
        public decimal dj { get; set; }
        public decimal je { get; set; }
        public decimal zhyz { get; set; }
        public string dw { get; set; }
        public decimal jl { get; set; }
        public string jldw { get; set; }
        public string yfmc { get; set; }
        public string pcmc { get; set; }
        public decimal? yl { get; set; }
        public string yldw { get; set; }
        public string yszt { get; set; }
        public string czh { get; set; }

        /// <summary>
        /// 组织机构ID
        /// </summary>
        public string OrganizeId { get; set; }
    }
}