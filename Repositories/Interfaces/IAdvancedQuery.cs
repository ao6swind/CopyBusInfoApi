namespace Repositories.Interfaces
{
    public interface IAdvancedQuery<T> : IGeneralQuery<T> where T : class
    {
        bool Truncate();
    }
}