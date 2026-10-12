using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class ProcedureScheduleRepository(AppDbContext context) : BaseRepository<ProcedureSchedule>(context), IProcedureScheduleRepository
{
	public async Task<ProcedureSchedule?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default)
	{
		return await _dbSet
			.Include(ps => ps.Procedure)
			.Include(ps => ps.Schedule)
			.FirstOrDefaultAsync(ps => ps.Id == id, cancellationToken);
	}
}