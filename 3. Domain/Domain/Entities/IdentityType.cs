namespace Domain.Entities;

public class IdentityType
{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public DateTime? DeletedOn { get; set; }
}
