using Application.Dtos;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CitasServicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController(AppointmentService service) : ControllerBase
    {
        [HttpGet("appointment-list")]
        public IEnumerable<SimpleAppointmentDto> GetByDate(DateTime date)
        {
            
        }
    }
}
