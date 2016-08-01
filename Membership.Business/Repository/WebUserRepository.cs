﻿using Membership.Core.Domain.Web;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Membership.Business.Repository
{
    public class WebUserRepository : GenericRepository<WebUser>
    {
        public WebUserRepository(DbContext dbcontext)
            : base(dbcontext)
        {
        }

        public List<WebUser> GetUsersByName(string nameStartsWith)
        {
            return this.GetObjectsByParameters(p => p.IsDeleted == 0 & p.Email.Contains(nameStartsWith)).ToList();
        }
    }
}
