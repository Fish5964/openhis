﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Newtouch.HIS.Domain.Entity
{
    /// <summary>
    /// 抗生素类别
    /// </summary>
    [Table("xt_kssType")]
    public class SysMedicineAntibioticTypeEntity : IEntity<SysMedicineAntibioticTypeEntity>
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OrganizeId { get; set; }

        /// <summary>
        /// 类别名称
        /// </summary>
        public string typeName { get; set; }

        /// <summary>
        /// 类别等级
        /// </summary>
        public string typelevel { get; set; }

        /// <summary>
        /// 权限级别(0 非限制使用药物,1 限制使用药物,2 特殊使用药物)
        /// </summary>
        public string qxjb { get; set; }

        /// <summary>
        /// 权限级别名称
        /// </summary>
        public string qxjbmc { get; set; }

        /// <summary>
        /// 上级类别Id
        /// </summary>
        public string parentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CreatorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? LastModifyTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastModifierCode { get; set; }

        /// <summary>
        /// 1：有效 0：无效
        /// </summary>
        public string zt { get; set; }
    }
}