using Repositories.Dapper;

namespace Services.Core
{
    public class DbOperator<T> : GeneralQuery<T> where T : class
    {
        
    }
}