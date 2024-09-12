using System;

namespace BookMyShow_Clone.Contracts.Repositories;

public interface IGenericRepo<T>
    where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetAsync(int id);
    Task<bool> ExistsAsync(int id);
    Task<T> CreateAsync(T entity);
    void Update(T entity);
    void SoftDelete(T entity);
    void Delete(T entity);
    Task Save();
}
