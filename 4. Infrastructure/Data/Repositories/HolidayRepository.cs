using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repositories;

public class HolidayRepository(AppDbContext context) : BaseRepository<Holiday>(context), IHolidayRepository;
