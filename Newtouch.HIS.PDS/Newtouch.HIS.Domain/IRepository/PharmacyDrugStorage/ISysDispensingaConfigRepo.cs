﻿using Newtouch.Core.Common;
using Newtouch.HIS.Domain.Entity;
using Newtouch.HIS.Domain.VO;
using System.Collections.Generic;

namespace Newtouch.HIS.Domain.IRepository
{
    /// <summary>
    /// xt_yp_fypz
    /// </summary>
    public interface ISysDispensingaConfigRepo : IRepositoryBase<SysDispensingaConfigEntity>
    {
        List<CodeNameVO> GetCodeName(string organizeId, int yjbmjb);
        List<CodeNameVO> GetYFYKCodeName(string organizeId);
        IList<SysDispensingaConfigEntity> GetPagintionList(Pagination pagination, string keyword,string organizeId);
        void SubmitForm(SysDispensingaConfigEntity FypzDTO, string keyValue);
        void DeleteForm(string keyValue);
    }
}