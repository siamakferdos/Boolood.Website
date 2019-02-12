using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Persistence.DbContext;

namespace Boolood.Read
{
    public class QueryBase
    {
        protected readonly AppDbContext _appDbContext;

        public QueryBase(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
