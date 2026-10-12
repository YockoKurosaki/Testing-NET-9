using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
	public DbSet<Appointment> Appointment { get; set; }
	public DbSet<Holiday> Holiday { get; set; }
	public DbSet<IdentityType> IdentityType { get; set; }
	public DbSet<People> People { get; set; }
	public DbSet<PeopleHolidays> PeopleHolidays { get; set; }
	public DbSet<PeopleProfession> PeopleProfession { get; set; }
	public DbSet<PeopleSchedule> PeopleSchedule { get; set; }
	public DbSet<Procedure> Procedure { get; set; }
	public DbSet<ProcedureSchedule> ProcedureSchedule { get; set; }
	public DbSet<Profession> Profession { get; set; }
	public DbSet<Schedule> Schedule { get; set; }
	public DbSet<Status> Status { get; set; }
	
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		//Aplica todas las configuraciones de entidades
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
	}
}
