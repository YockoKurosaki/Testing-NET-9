using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repositories;

public class StatusRepository(AppDbContext context) : BaseRepository<Status>(context), IStatusRepository;