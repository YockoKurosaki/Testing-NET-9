using Application.Filters;
using Application.IRepositories;
using Application.Response;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class AppointmentRepository(AppDbContext context) : BaseRepository<Appointment>(context), IAppointmentRepository
{
	public async Task<Appointment?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default)
	{
		return await _dbSet
			.Include(ps => ps.ClientPeople).ThenInclude(cp => cp.IdentityType)
			.Include(ps => ps.ProfessionalPeople).ThenInclude(pp => pp.IdentityType)
			.Include(ps => ps.Procedure)
			.Include(ps => ps.Status)
			.FirstOrDefaultAsync(ps => ps.Id == id, cancellationToken);
	}

	public async Task<PagedResult<Appointment>?> GetFilteredSimpleAsync(AppointmentFilter filter, CancellationToken cancellationToken = default)
	{
		IQueryable<Appointment> queryable = _dbSet
				.Include(a => a.ClientPeople)
				.Include(a => a.ProfessionalPeople)
				.Include(a => a.Procedure)
				.Include(a => a.Status);

		if (filter.ClientId.HasValue)
		{
			queryable = queryable.Where(a => a.ClientPeopleId == filter.ClientId.Value);
		}

		if (filter.ProfessionalId.HasValue)
		{
			queryable = queryable.Where(a => a.ProfessionalPeopleId == filter.ProfessionalId.Value);
		}

		if (filter.StatusId.HasValue)
		{
			queryable = queryable.Where(a => a.StatusId == filter.StatusId.Value);
		}

		if (filter.StartDateFrom.HasValue)
		{
			queryable = queryable.Where(a => a.StartAt >= filter.StartDateFrom.Value);
		}

		if (filter.EndDateTo.HasValue)
		{
			queryable = queryable.Where(a => a.StartAt <= filter.EndDateTo.Value);
		}

		int totalCount = await queryable.CountAsync(cancellationToken);

		// Ordenamiento y paginación
		var items = await queryable
				.OrderByDescending(a => a.Id)
				.Skip((filter.Page - 1) * filter.PageSize)
				.Take(filter.PageSize)
				.ToListAsync(cancellationToken);

		return PagedResult<Appointment>.CreateSuccess(items, totalCount, filter.Page, filter.PageSize);
	}
}
