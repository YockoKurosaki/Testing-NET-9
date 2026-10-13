using Domain.Entities;

namespace Application.IRepositories;

public interface IPeopleRepository : IBaseRepository<People>
{
	Task<People?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
}
