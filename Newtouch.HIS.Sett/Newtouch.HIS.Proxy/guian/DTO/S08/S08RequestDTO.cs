﻿using Newtouch.HIS.Proxy.Attribute;
using System.Xml.Serialization;

namespace Newtouch.HIS.Proxy.guian.DTO
{
    [InterfaceCode("S08")]
    [XmlRoot("body")]
    public class S08RequestDTO
    {
        /// <summary>
        /// 补偿序号
        /// </summary>
        public string inpId { get; set; }
        /// <summary>
        /// 取消登记原因
        /// </summary>
        public string reason { get; set; }
        /// <summary>
        /// 行政编码(跨省)
        /// </summary>
        public string areaCode { get; set; }
        /// <summary>
        /// 是否跨省就医患者1:是0:否(跨省)
        /// </summary>
        public string isTransProvincial { get; set; }
    }
}