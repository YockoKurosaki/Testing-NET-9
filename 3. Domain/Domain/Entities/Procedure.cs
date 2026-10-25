namespace Domain.Entities;

public class Procedure
{
	public int Id { get; set; }
	public string? Name { get; set; } // Cardiología, Pediatría, Peluquería, etc.
	public decimal Price { get; set; }
	public string? Description { get; set; }
	public DateTime? DeletedOn { get; set; }
}
