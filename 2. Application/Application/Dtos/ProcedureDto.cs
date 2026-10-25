using Domain.Entities;

namespace Application.Dtos;

public class ProcedureDto
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public decimal Price { get; set; }
	public string? Description { get; set; }
	public DateTime? DeletedOn { get; set; }
	public int ProfessionId { get; set; }
	public Profession? Profession { get; set; }
}

public class CreateProcedureDto
{
	public string? Name { get; set; }
	public decimal Price { get; set; }
	public string? Description { get; set; }
}

public class UpdateProcedureDto : CreateProcedureDto
{
	public int Id { get; set; }
}

public class SimpleProcedureDto
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public decimal Price { get; set; }
	public string? Description { get; set; }
}
