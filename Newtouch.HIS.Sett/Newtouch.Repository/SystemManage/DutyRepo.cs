﻿using Newtouch.HIS.Domain.Entity;
using Newtouch.HIS.Domain.IRepository;
using Newtouch.Infrastructure;

namespace Newtouch.HIS.Repository
{
	/// <summary>
    /// 
    /// </summary>
    public class DutyRepo : RepositoryBase<DutyEntity>, IDutyRepository
    {
        public DutyRepo(INewtouchDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }

    }
}


