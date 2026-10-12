namespace Domain.Entities;

public class Holiday
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Description { get; set; }
	public bool IsGlobal { get; set; }
	public DateTime Date { get; set; }
	public DateTime? DeletedOn { get; set; }
}
