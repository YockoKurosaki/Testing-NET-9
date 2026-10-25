namespace Application.Dtos;

public class CreateAppointmentDto
{
	public int ClientId { get; set; }
	public int ProfessionalId { get; set; }
	public int ProcedureId { get; set; }
	public int StatusId { get; set; }
	public DateTime StartAt { get; set; }
	public DateTime EndAt { get; set; }
}

public class UpdateAppointmentDto
{
	public int Id { get; set; }
	public int? ProfessionalId { get; set; }
	public int? StatusId { get; set; }
	public DateTime? StartAt { get; set; }
	public DateTime? EndAt { get; set; }
}

public class SimpleAppointmentDto
{
	public int Id { get; set; }
	public string? ClientName{ get; set; }
	public string? ProfessionalName { get; set; }
	public string? ProcedureName { get; set; }
	public string? StatusName { get; set; }
	public DateTime StartAt { get; set; }
	public DateTime EndAt { get; set; }
}