﻿using FrameworkBase.MultiOrg.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtouch.Domain.Entity.Clinic
{
    [Table("zl_zlsq")]
    public class ClinicApplyInfoEntity : IEntity<ClinicApplyInfoEntity>
    {
        [Key]
        public string Id { get; set; }
        public string OrganizeId { get; set; }
        public DateTime? sqsj { get; set; }
        public DateTime? jzsj { get; set; }
        public string ks { get; set; }
        public string ysgh { get; set; }
        public int? sqzt { get; set; }
        public string patid { get; set; }
        public string xm { get; set; }
        public string xb { get; set; }
        public string nl { get; set; }
        public string zjh { get; set; }
        public DateTime? birth { get; set; }
        public string brxz { get; set; }
        public string mettingId { get; set; }
        public string sqr { get; set; }
        public string sqlsh { get; set; }
        public string kh { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CreatorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? LastModifyTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastModifierCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string zt { get; set; }

        public string AppId { get; set; }
        public string ApplyOrg { get; set; }
        public string ApplyOrgName { get; set; }
        public string sqrgh { get; set; }
        public string mzh { get; set; }
    }
}