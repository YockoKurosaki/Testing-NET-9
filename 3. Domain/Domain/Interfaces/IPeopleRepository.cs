using Domain.Entities;

namespace Domain.Interfaces;

public interface IPeopleRepository : IBaseRepository<People>
{
	Task<People?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
}
