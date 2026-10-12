namespace Domain.Entities;

public class ProcedureSchedule
{
		public int Id { get; set; }
		public int ProcedureId { get; set; }
		public int ScheduleId { get; set; }
		public virtual Procedure? Procedure { get; set; }
		public virtual Schedule? Schedule { get; set; }
}
