using FluentValidation;
using ismetertugral.TodoAppNTier.Dtos.WorkDtos;

namespace ismetertugral.TodoAppNTier.Business.ValidationRules
{
    public class WorkUpdateDtoValidator : AbstractValidator<WorkUpdateDto>
    {
        public WorkUpdateDtoValidator()
        {
            RuleFor(x=>x.Id).GreaterThanOrEqualTo(1).NotEmpty(); //NotEmpty
            RuleFor(x=>x.Definition).NotEmpty();
        }
    }
}
