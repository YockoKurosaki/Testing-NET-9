using Domain.Entities;
using Application.IRepositories;

namespace Data.Repositories;

public class ScheduleRepository(AppDbContext context) : BaseRepository<Schedule>(context), IScheduleRepository;