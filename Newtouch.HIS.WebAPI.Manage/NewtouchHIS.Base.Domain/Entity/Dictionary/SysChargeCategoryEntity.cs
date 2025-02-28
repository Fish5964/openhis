﻿using NewtouchHIS.Lib.Base.EnumExtend;
using SqlSugar;
using System.ComponentModel.DataAnnotations;

namespace NewtouchHIS.Base.Domain.Entity.Dictionary
{
    ///<summary>
    ///收费大类 
    ///一般按上级主管部门要求分类
    ///    （挂号费00、诊疗费01、磁卡费02、工本费03 等
    ///    门诊医保编码 varchar(2)
    ///    住院医保编码 varchar(2) 
    ///    重新建立表做医保代码对应
    ///</summary>
    [Tenant(DBEnum.BaseDb)]
    [SugarTable("xt_sfdl", "收费大类")]
    public partial class SysChargeCategoryEntity : IEntity
    {

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int dlId { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [Required(ErrorMessage = "dlCode不可为空")]
        [StringLength(20, ErrorMessage = "dlCode长度限制为20")]
        public string dlCode { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [Required(ErrorMessage = "dlmc不可为空")]
        [StringLength(50, ErrorMessage = "dlmc长度限制为50")]
        public string dlmc { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? ParentId { get; set; }

        /// <summary>
        /// Desc:0 通用 1 门诊 2住院
        /// Default:
        /// Nullable:False
        /// </summary>           
        [Required(ErrorMessage = "mzzybz不可为空")]
        [StringLength(1, ErrorMessage = "mzzybz长度限制为1")]
        public string mzzybz { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [Required(ErrorMessage = "mzprintreportcode不可为空")]
        [StringLength(20, ErrorMessage = "mzprintreportcode长度限制为20")]
        public string mzprintreportcode { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [Required(ErrorMessage = "mzprintbillcode不可为空")]
        [StringLength(20, ErrorMessage = "mzprintbillcode长度限制为20")]
        public string mzprintbillcode { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [Required(ErrorMessage = "py不可为空")]
        [StringLength(50, ErrorMessage = "py长度限制为50")]
        public string py { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? px { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        [StringLength(20, ErrorMessage = "reportdlcode长度限制为20")]
        public string? reportdlcode { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? dllb { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        [StringLength(20, ErrorMessage = "fjCode长度限制为20")]
        public string? fjCode { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        [StringLength(50, ErrorMessage = "fjmc长度限制为50")]
        public string? fjmc { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        [StringLength(19, ErrorMessage = "sn长度限制为19")]
        public decimal? sn { get; set; }

    }
}
