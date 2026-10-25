using Domain.Entities;

namespace Application.Dtos;

public class ProcedureScheduleDto
{
	public int Id { get; set; }
	public int ProcedureId { get; set; }
	public int ScheduleId { get; set; }
	public Procedure? Procedure { get; set; }
	public Schedule? Schedule { get; set; }
}

public class CreateProcedureScheduleDto
{
	public int ProcedureId { get; set; }
	public int ScheduleId { get; set; }
}

public class UpdateProcedureScheduleDto
{
	public int Id { get; set; }
	public int ScheduleId { get; set; }
}

public class SimpleProcedureScheduleDto
{
	public int Id { get; set; }
	public string? ProcedureName { get; set; }
	public string? ScheduleName { get; set; }
	public string? ProfessionName { get; set; }
}
