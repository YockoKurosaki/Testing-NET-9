using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repositories;

public class ProcedureRepository(AppDbContext context) : BaseRepository<Procedure>(context), IProcedureRepository;