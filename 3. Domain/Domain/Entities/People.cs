namespace Domain.Entities;

public class People
{
	public int Id { get; set; }
	public string? Names { get; set; }
	public string? Lastnames { get; set; }
	public int? IdentityTypeId { get; set; }
	public string? Identity { get; set; }
	public string? Email { get; set; }
	public string? Address { get; set; }
	public string? ZipCode { get; set; }
	public string? PhoneNumber { get; set; }
	public DateTime? BirthDate { get; set; }
	public DateTime? DeletedOn { get; set; }
	public virtual IdentityType? IdentityType { get; set; }
}
