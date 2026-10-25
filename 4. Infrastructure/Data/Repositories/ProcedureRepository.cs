using Domain.Entities;
using Application.IRepositories;

namespace Data.Repositories;

public class ProcedureRepository(AppDbContext context) : BaseRepository<Procedure>(context), IProcedureRepository;