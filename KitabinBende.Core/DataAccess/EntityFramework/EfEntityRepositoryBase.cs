using KitabinBende.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace KitabinBende.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var db = new TContext())
            {
              EntityEntry entityToProcess =  db.Entry(entity);
                entityToProcess.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var db = new TContext())
            {
                EntityEntry entityToProcess = db.Entry(entity);
                entityToProcess.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var db = new TContext())
            {
                return db.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var db = new TContext())
            {
                return filter==null
                    ? db.Set<TEntity>().ToList()
                    : db.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var db = new TContext())
            {
                EntityEntry entityToProcess = db.Entry(entity);
                entityToProcess.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
    
}
