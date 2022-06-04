using Microsoft.EntityFrameworkCore;
using POS_Database.Core;
using POS_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace POS_Services.Services
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : class
    {
        protected POSContext db = new POSContext();
        protected POSContext serviceContext { get; set; }
        public ServiceBase(POSContext serviceContext)
        {
            this.serviceContext = serviceContext;
        }
        public IQueryable<T> FindAll()
        {
            return this.serviceContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.serviceContext.Set<T>().Where(expression).AsNoTracking();
        }
        public void Create(T entity)
        {
            this.serviceContext.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            this.serviceContext.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            this.serviceContext.Set<T>().Remove(entity);
        }
        public List<T> ExecuteSP(string query)
        {
            var type = this.serviceContext.Set<T>().FromSqlRaw("EXECUTE " + query).ToList();
            return type;
        }
        public List<T> ExecuteSP(string query, params object[] parameters)
        {
            var type = this.serviceContext.Set<T>().FromSqlRaw("EXECUTE " + query + " {0}", parameters).ToList();
            return type;
        }
        public void ExecuteInsertUpdateSP(string query)
        {
            this.serviceContext.Database.ExecuteSqlRaw(query);
        }


    }
}
