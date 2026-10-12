namespace Domain.Entities;

public class PeopleHolidays
{
	public int Id { get; set; }
	public int PeopleId { get; set; }
	public int HolidaysId { get; set; }
	public virtual People? People { get; set; }
	public virtual Holiday? Holidays { get; set; }
}
