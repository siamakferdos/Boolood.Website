using System;
using System.Collections.Generic;
using System.Linq;
using Boolood.Model.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Boolood.Framework.Repository
{
    public abstract class RepositoryBase<TDbContext> 
        where TDbContext: DbContext 
    {
        private readonly TDbContext _appDbContext;
        protected RepositoryBase(TDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        protected TDbContext GetAppDbContext()
        {
            return _appDbContext;
        }

        public void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }

        protected void AddEntity(EntityBase entity)
        {
            _appDbContext.Add(entity);
        }

        protected T GetEntity<T>(Guid id) where T: EntityBase
        {
            return GetAppDbContext().Find<T>(id);
        }

        protected List<T> GetAllEntities<T>() where T : EntityBase
        {
            return GetAppDbContext().Set<T>().ToList();
        }
    }
}
