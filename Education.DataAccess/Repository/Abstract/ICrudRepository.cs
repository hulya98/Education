namespace Education.DataAccess.Services.Abstract
{
    public interface ICrudRepository<T>
    {
        Task<T> CreateAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(int id);
    }
}
