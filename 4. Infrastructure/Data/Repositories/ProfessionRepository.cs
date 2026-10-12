using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repositories;

public class ProfessionRepository(AppDbContext context) : BaseRepository<Profession>(context), IProfessionRepository;