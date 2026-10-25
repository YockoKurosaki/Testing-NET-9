using Domain.Entities;
using Application.IRepositories;

namespace Data.Repositories;

public class IdentityTypeRepository(AppDbContext context) : BaseRepository<IdentityType>(context), IIdentityTypeRepository;
