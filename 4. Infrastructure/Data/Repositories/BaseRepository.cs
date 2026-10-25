using Application.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class BaseRepository<T>(AppDbContext context): IBaseRepository<T> where T : class
{
	protected readonly DbSet<T> _dbSet = context.Set<T>();

	public virtual async Task<T?> GetByIdAsync(int id)
	{
		return await _dbSet.FindAsync(id);
	}

	public virtual async Task<IEnumerable<T>> GetAllAsync()
	{
		return await _dbSet.ToListAsync();
	}

	public virtual async Task AddAsync(T entity)
	{
		await _dbSet.AddAsync(entity);
	}

	public virtual void Update(T entity)
	{
		_dbSet.Update(entity);
	}

	public virtual void SoftDelete(T entity)
	{
		// Assuming the entity has a property named "DeletedOn" of type DateTime?
		var propertyInfo = typeof(T).GetProperty("DeletedOn");
		if (propertyInfo != null && propertyInfo.PropertyType == typeof(DateTime?))
		{
			propertyInfo.SetValue(entity, DateTime.UtcNow);
			Update(entity);
		}
		else
		{
			throw new InvalidOperationException($"Entity of type {typeof(T).Name} does not have a 'DeletedOn' property.");
		}
	}

	public virtual void Delete(T entity)
	{
		_dbSet.Remove(entity);
	}

	public virtual async Task<int> SaveChangesAsync()
	{
		return await context.SaveChangesAsync();
	}
}
