using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface IGeneralQuery<T> where T : class
    {
        List<T> List();
        T Find(int id);
        bool Create(T entity);
        bool Update(int id, T entity);
        bool Delete(int id);
    }
}