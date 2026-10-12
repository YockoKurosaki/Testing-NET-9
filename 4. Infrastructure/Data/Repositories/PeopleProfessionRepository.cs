using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class PeopleProfessionRepository(AppDbContext context) : BaseRepository<PeopleProfession>(context), IPeopleProfessionRepository
{
	public async Task<PeopleProfession?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default)
	{
		return await _dbSet
			.Include(ps => ps.People)
			.Include(ps => ps.Profession)
			.FirstOrDefaultAsync(ps => ps.Id == id, cancellationToken);
	}
}
