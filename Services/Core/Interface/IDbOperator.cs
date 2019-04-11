using Repositories.Interfaces;

namespace Services.Core.Interface
{
    public interface IDbOperator<T> : IGeneralQuery<T> where T : class
    {
         
    }
}