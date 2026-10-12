using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repositories;

public class IdentityTypeRepository(AppDbContext context) : BaseRepository<IdentityType>(context), IIdentityTypeRepository;
