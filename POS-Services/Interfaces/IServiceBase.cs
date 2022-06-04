using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace POS_Services.Interfaces
{
    public interface IServiceBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> ExecuteSP(string query);
        List<T> ExecuteSP(string query, params object[] parameters);
        void ExecuteInsertUpdateSP(string query);
    }
}
