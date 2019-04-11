using System.Collections.Generic;
using Services.Core.Interface;

namespace Services.Core
{
    public class CoreOperator<T> : IDbOperator<T>, IApiOperator<T> where T : class
    {
        DbOperator<T> _dbOperator;
        ApiOperator<T> _apiOperator;
        public CoreOperator()
        {
            _dbOperator = new DbOperator<T>();
            _apiOperator = new ApiOperator<T>();
        }

        public bool Create(T entity)
        {
            return _dbOperator.Create(entity);
        }

        public bool Delete(int id)
        {
            return _dbOperator.Delete(id);
        }

        public T Find(int id)
        {
            return _dbOperator.Find(id);
        }

        public List<T> GetApiResult(string url)
        {
            return _apiOperator.GetApiResult(url);
        }

        public List<T> List()
        {
            return _dbOperator.List();
        }

        public bool Update(int id, T entity)
        {
            return _dbOperator.Update(id, entity);
        }
    }
}