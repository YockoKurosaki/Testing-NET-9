using Domain.Entities;
using Application.IRepositories;

namespace Data.Repositories;

public class ProfessionRepository(AppDbContext context) : BaseRepository<Profession>(context), IProfessionRepository;