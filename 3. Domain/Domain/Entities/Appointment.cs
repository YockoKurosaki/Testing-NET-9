namespace Domain.Entities;

public class Appointment
{
		public int Id { get; set; }
		public int ClientPeopleId { get; set; }
		public int ProfessionalPeopleId { get; set; }
		public int ProcedureId { get; set; }
		public int StatusId { get; set; }
		public DateTime StartAt { get; set; }
		public DateTime EndAt { get; set; }
		public DateTime AppointmentDate { get; set; }
		public DateTime LastUpdated { get; set; }
		public DateTime DeletedOn { get; set; }
		public virtual People? ClientPeople { get; set; }
		public virtual People? ProfessionalPeople { get; set; }
		public virtual Procedure? Procedure { get; set; }
		public virtual Status? Status { get; set; }
}
