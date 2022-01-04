using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositorioDB
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Variables

        protected DbContext dbContext;
        protected log4net.ILog _log = log4net.LogManager.GetLogger(typeof(Repository<T>));

        
        #endregion

        #region Properties

        public string Provider
        {
            get { return "System.Data.SqlClient"; }
        }

        public DbContext Context
        {
            get { return dbContext; }
        }

        #endregion

        #region Constructors

        public Repository() { }

        public Repository(DbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        #endregion

        #region Methods

        virtual public IQueryable<T> GetAll()
        {
            return dbContext.Set<T>().AsQueryable();
        }

        virtual public void Insert(T item)
        {
            dbContext.Set<T>().Add(item);
        }

        virtual public void Delete(T item)
        {
            dbContext.Set<T>().Remove(item);
        }

        virtual public T Create()
        {
            return dbContext.Set<T>().Create();
        }

        virtual public IEnumerable<T> GetFromSqlQuery(string nativeSqlQuery)
        {
            return dbContext.Database.SqlQuery<T>(nativeSqlQuery);
        }

        virtual public IEnumerable<int> GetSeqSqlQuery(string nativeSqlQuery)
        {
            return dbContext.Database.SqlQuery<int>(nativeSqlQuery);
        }

        virtual public IEnumerable<Int64> GetBigSeqSqlQuery(string nativeSqlQuery)
        {
            return dbContext.Database.SqlQuery<Int64>(nativeSqlQuery);
        }

        virtual public T GetById(int id)
        {
            T t = dbContext.Set<T>().Find(id);
            dbContext.Entry<T>(t).Reload();
            return t;
        }

        virtual public void InsertRange(IEnumerable<T> entities)
        {
            dbContext.Set<T>().AddRange(entities);
        }

        virtual public void DeleteRange(IEnumerable<T> entities)
        {
            dbContext.Set<T>().RemoveRange(entities);
        }

        #endregion

    }
}