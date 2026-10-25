namespace Domain.Entities;

public class ProcedureProfession
{
	public int Id { get; set; }
	public int ProfessionId { get; set; }
	public int ProcedureId { get; set; }
	public virtual Procedure? Procedure { get; set; }
	public virtual Profession? Profession { get; set; }

}
