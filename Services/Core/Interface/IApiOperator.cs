using System.Collections.Generic;

namespace Services.Core.Interface
{
    public interface IApiOperator<T> where T : class
    {
        List<T> GetApiResult(string url);
    }
}