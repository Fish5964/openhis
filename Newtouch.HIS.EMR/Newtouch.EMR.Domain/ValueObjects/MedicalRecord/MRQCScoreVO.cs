﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtouch.EMR.Domain.ValueObjects.MedicalRecord
{
    public class MRQCScoreVO
    {
        public string Id { get; set; }
        public string BlmbId { get; set; }
        public string Blmbmc { get; set; }
        public string zklx { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Score { get; set; }
        public string Remark { get; set; }
        public int Px { get; set; }
        public string OrganizeId { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreatorCode { get; set; }
        public DateTime? LastModifyTime { get; set; }
        public string LastModifierCode { get; set; }
        public string zt { get; set; }

        public string zyh { get; set; }
        public string sl { get; set; }
        public string bllxmc { get; set; }
        public string TotalScore { get; set; }

        //public int Id { get; set; }
        //public string Zyh { get; set; }
        //public string WritId { get; set; }
        //public string BllxId { get; set; }
        //public string BlmbId { get; set; }
        //public string Blmc { get; set; }
        //public string ScoreCode { get; set; }
        //public string ScoreMc { get; set; }
        //public decimal ScoreMcValue { get; set; }
        //public int Px { get; set; }
        //public string OrganizeId { get; set; }
        //public DateTime CreateTime { get; set; }
        //public string CreatorCode { get; set; }
        //public DateTime? LastModifyTime { get; set; }
        //public string LastModifierCode { get; set; }
        //public string zt { get; set; }

        //public decimal Socre { get; set; }
        //public string Remark { get; set; }
        //public int sl { get; set; }
        //public decimal TotalScore { get; set; }
        //public string bllxmc { get; set; }
    }
}
