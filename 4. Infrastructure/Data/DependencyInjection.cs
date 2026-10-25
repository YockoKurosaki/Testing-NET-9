using Application.IRepositories;
using Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Data;

public static class DependencyInjection
{
	public static IServiceCollection AddDataServices(this IServiceCollection services)
	{
		services.AddScoped<IAppointmentRepository, AppointmentRepository>();
		services.AddScoped<IHolidayRepository, HolidayRepository>();
		return services;
	}
}
