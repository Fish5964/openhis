﻿using FrameworkBase.MultiOrg.Domain.Entity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Newtouch.Domain.Entity.Outpatient
{
    [Table("pacs_jcbw")]
    public  class Pacs_ExamBodyPartsEntity : IEntity<Pacs_ExamBodyPartsEntity>
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public string Id { get; set; }
        public string jcbwCode { get; set; }
        public string jcbw{ get; set; }
        public string jcff { get; set; }

     
        /// <summary>
        /// 
        /// </summary>
        public string OrganizeId { get; set; }

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

        public string bwflCode { get; set; }
        public string bwflmc { get; set; }
    }
}