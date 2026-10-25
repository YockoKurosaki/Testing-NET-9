using Application.Dtos;
using Application.Response;
using Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace Application.Mapper;

[Mapper]
public partial class ProcedureMapper
{
	public partial UpdateProcedureDto ToUpdateDto(Procedure procedure);
	public partial SimpleProcedureDto ToSimpleDto(Procedure procedure);
	public partial PagedResult<SimpleProcedureDto> ToSimpleListDto(PagedResult<Procedure> procedures);
}
