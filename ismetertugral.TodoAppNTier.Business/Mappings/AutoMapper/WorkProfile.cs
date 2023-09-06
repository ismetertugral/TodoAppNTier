using AutoMapper;
using ismetertugral.TodoAppNTier.Dtos.WorkDtos;
using ismetertugral.TodoAppNTier.Entities.Domains;

namespace ismetertugral.TodoAppNTier.Business.Mappings.AutoMapper
{
    public class WorkProfile : Profile
    {
        public WorkProfile()
        {
            CreateMap<Work,WorkListDto>().ReverseMap();
            CreateMap<Work,WorkCreateDto>().ReverseMap();
            CreateMap<Work,WorkUpdateDto>().ReverseMap();
            CreateMap<WorkListDto, WorkUpdateDto>().ReverseMap();
        }
    }
}
