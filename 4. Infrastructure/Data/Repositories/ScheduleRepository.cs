using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repositories;

public class ScheduleRepository(AppDbContext context) : BaseRepository<Schedule>(context), IScheduleRepository;