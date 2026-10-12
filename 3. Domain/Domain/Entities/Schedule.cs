namespace Domain.Entities;

public class Schedule
{
		public int Id { get; set; }
		public TimeSpan StartTime { get; set; }
		public TimeSpan EndTime { get; set; }
		public DateTime? DeletedOn { get; set; }
		public string? Description { get; set; }
}
