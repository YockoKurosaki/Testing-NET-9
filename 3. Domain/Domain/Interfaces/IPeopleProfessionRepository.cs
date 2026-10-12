using Domain.Entities;

namespace Domain.Interfaces;

public interface IPeopleProfessionRepository : IBaseRepository<PeopleProfession>
{
	Task<PeopleProfession?> GetByIdWithDetailsAsync(int id, CancellationToken cancellationToken = default);
}
