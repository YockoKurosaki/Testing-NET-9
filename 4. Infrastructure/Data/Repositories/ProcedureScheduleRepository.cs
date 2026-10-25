using Domain.Entities;
using Application.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class ProcedureScheduleRepository(AppDbContext context) : BaseRepository<ProcedureSchedule>(context), IProcedureScheduleRepository
{
	public async Task<ProcedureSchedule?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default)
	{
		return await _dbSet
			.Include(ps => ps.Schedule)
			.Include(ps => ps.Procedure)
			.FirstOrDefaultAsync(ps => ps.Id == id, cancellationToken);
	}

	public Task<IEnumerable<ProcedureSchedule>> GetByProcedureIdAsync(int procedureId, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}
}