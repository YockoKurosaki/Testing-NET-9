namespace Domain.Entities;

public class PeopleProfession
{
		public int Id { get; set; }
		public int PeopleId { get; set; }
		public int ProfessionId { get; set; }
		public virtual People? People { get; set; }
		public virtual Profession? Profession { get; set; }
}
