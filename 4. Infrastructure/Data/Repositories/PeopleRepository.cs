using Domain.Entities;
using Application.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class PeopleRepository(AppDbContext context) : BaseRepository<People>(context), IPeopleRepository
{
	public async Task<People?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default)
	{
		return await _dbSet
			.Include(ps => ps.IdentityType)
			.FirstOrDefaultAsync(ps => ps.Id == id, cancellationToken);
	}
}
