using Domain.Entities;
using Application.IRepositories;

namespace Data.Repositories;

public class StatusRepository(AppDbContext context) : BaseRepository<Status>(context), IStatusRepository;