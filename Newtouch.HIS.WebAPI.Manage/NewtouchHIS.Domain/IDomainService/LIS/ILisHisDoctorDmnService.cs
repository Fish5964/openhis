﻿using NewtouchHIS.Domain.Entity.LIS;
using NewtouchHIS.Lib.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtouchHIS.Domain.IDomainService.LIS
{
    public interface ILisHisDoctorDmnService : IScopedDependency
    {
        Task<List<HisDoctorEntity>> HisDoctorQuery();
    }
}