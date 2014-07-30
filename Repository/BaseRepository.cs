using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Wst.IRepository;
using Wst.Model;

namespace Wst.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly DbContext context;
        private DbContext DbContext { get; set; }
        public DbSet<T> DbSet { get; set; }
        private readonly DbSet<T> dbset;
        public BaseRepository(DbContext context)
        {
            this.context = context;
            this.dbset = this.context.Set<T>();
        }
        ///增加功能
        #region
        //增加单个
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        //增加多个
        public virtual void Add(IEnumerable<T> entity)
        {
            dbset.AddRange(entity);
        }
        #endregion
        ///更新功能
        #region
        //更新单个
        public virtual void Update(T entity)
        {
            DbEntityEntry<T> entry = context.Entry(entity);
            try
            {
                if (entry.State == EntityState.Detached)
                {
                    dbset.Add(entity);
                    context.Entry(entity).State = EntityState.Modified;
                }
            }
            catch
            {
                T oldEntity = dbset.Find(entity);
                context.Entry(oldEntity).CurrentValues.SetValues(entity);
            }
        }
        #endregion
        ///删除功能
        #region
        //删除单个
        public virtual void Delete(T entity)
        {
            DbEntityEntry<T> entry = context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                dbset.Attach(entity);
            }
            dbset.Remove(entity);
        }
        /// <summary>
        /// 根据ID删除
        /// </summary>
        /// <param name="ID"></param>
        public virtual void DeleteByID(int ID)
        {
            dbset.Remove(dbset.Find(ID));     
        }
        //删除多个
        public virtual void Delete(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                DbEntityEntry<T> entry = context.Entry(entity);
                if (entry.State == EntityState.Detached)
                {
                    dbset.Attach(entity);
                }
                dbset.Remove(entity);
            }
        }
        #endregion
        ///获取功能
        #region
        //根据条件获取
        public IEnumerable<T> Get(Expression<Func<T, bool>> where)
        {
            var entities = dbset.Where(where);
            return entities;
        }
        //获取所有
        public IEnumerable<T> GetAll()
        {
            return dbset;
        }
        #endregion
        /// <summary>
        /// 写入到数据库
        /// </summary>
        /// <returns></returns>
        public int Commit()
        {
            return this.context.SaveChanges();
        }
    }
} 