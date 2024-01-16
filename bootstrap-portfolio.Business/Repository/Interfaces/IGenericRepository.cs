namespace bootstrap_portfolio.Business.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(bool isTracking = false);
        Task<T> GetById(int id, bool isTracking = false);
        Task AddToDbAsync(T vm);
        void Edit(int id, T vm);
        Task DeleteAsync(int id);
        Task SoftDelete(int id);
        Task SoftDeleteRevert(int id);
        Task SaveAsync();
    }
}
