using ismetertugral.TodoAppNTier.Common.ResponseObjects;
using ismetertugral.TodoAppNTier.Dtos.Interfaces;
using ismetertugral.TodoAppNTier.Dtos.WorkDtos;

namespace ismetertugral.TodoAppNTier.Business.Interfaces
{
    public interface IWorkService
    {
        Task<IResponse<List<WorkListDto>>> GetAll();

        Task<IResponse<WorkCreateDto>> Create(WorkCreateDto dto);

        Task<IResponse<IDto>> GetById<IDto>(int id);

        Task<IResponse> Remove(int id);

        Task<IResponse<WorkUpdateDto>> Update(WorkUpdateDto dto);
    }
}
