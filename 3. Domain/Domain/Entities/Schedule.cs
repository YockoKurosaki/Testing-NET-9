namespace Domain.Entities;

public class Schedule
{
		public int Id { get; set; }
		public DateTime Start { get; set; }
		public DateTime End { get; set; }
		public DateTime? DeletedOn { get; set; }
		public string? Description { get; set; }
}
