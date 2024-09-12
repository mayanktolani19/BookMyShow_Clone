using System;
using BookMyShow_Clone.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow_Clone.Data.Repositories;

public class GenericRepo<T> : IGenericRepo<T>
    where T : class
{
    private readonly ApplicationDbContext _dbContext;

    public GenericRepo(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<T> CreateAsync(T entity)
    {
        await _dbContext.AddAsync(entity);
        return entity;
    }

    public void Delete(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
    }

    public async Task<bool> ExistsAsync(int id)
    {
        var entity = await GetAsync(id);
        return entity != null;
    }

    public async Task<T?> GetAsync(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public void SoftDelete(T entity)
    {
        var isDeletedProp = typeof(T).GetProperty("IsDeleted");
        if (isDeletedProp != null && isDeletedProp.PropertyType == typeof(bool))
        {
            isDeletedProp.SetValue(entity, true);
            Update(entity);
        }
    }

    public void Update(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
    }

    public async Task Save()
    {
        await _dbContext.SaveChangesAsync();
    }
}
