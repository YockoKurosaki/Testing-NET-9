namespace Application.Filters;

public class AppointmentFilter
{
	//Filtros de búsqueda
	public int? ClientId { get; set; }
	public int? ProfessionalId { get; set; }
	public int? ProcedureId { get; set; }
	public int? StatusId { get; set; }
	public DateTime? StartDateFrom { get; set; }
	public DateTime? EndDateTo { get; set; }
	public DateTime? LastUpdated { get; set; }

	// Paginación
	public int Page { get; set; } = 1;
	public int PageSize { get; set; } = 20;

	// Ordenamiento
	public string OrderBy { get; set; } = "StartAt"; // "StartAt", "ClientName", etc.
	public bool OrderDescending { get; set; } = false;

}
