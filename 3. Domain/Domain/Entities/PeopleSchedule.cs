namespace Domain.Entities;

public class PeopleSchedule
{
		public int Id { get; set; }
		public int PeopleProfessionId { get; set; }
		public int ScheduleId { get; set; }
		public virtual PeopleProfession? PeopleProfession { get; set; }
		public virtual Schedule? Schedule { get; set; }
}
