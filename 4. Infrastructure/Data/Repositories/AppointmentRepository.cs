using Domain.Entities;
using Domain.Interfaces;
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
}
