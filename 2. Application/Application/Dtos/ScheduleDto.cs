namespace Application.Dtos;
public class ScheduleDto
{
	public int Id { get; set; }
	public DateTime StartAt { get; set; }
	public DateTime EndAt { get; set; }
	public DateTime? DeletedOn { get; set; }
	public string? Description { get; set; } = null;
}

public class CreateScheduleDto
{
	public DateTime StartAt { get; set; }
	public DateTime EndAt { get; set; }
	public string? Description { get; set; } = null;
}