using Domain.Entities;

namespace Application.IRepositories;

public interface IPeopleProfessionRepository : IBaseRepository<PeopleProfession>
{
	Task<PeopleProfession?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
}
