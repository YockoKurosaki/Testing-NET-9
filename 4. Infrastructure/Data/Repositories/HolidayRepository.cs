using Domain.Entities;
using Application.IRepositories;

namespace Data.Repositories;

public class HolidayRepository(AppDbContext context) : BaseRepository<Holiday>(context), IHolidayRepository;
