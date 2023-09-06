using FluentValidation;
using ismetertugral.TodoAppNTier.Dtos.WorkDtos;

namespace ismetertugral.TodoAppNTier.Business.ValidationRules
{
    public class WorkCreateDtoValidator : AbstractValidator<WorkCreateDto>
    {
        public WorkCreateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty();
            //.WithMessage("Definition is required").When(x => x.IsCompleted).Must(isIsmet).WithMessage("Definition İsmet olamaz");
        }

        //private bool isIsmet(string arg)
        //{
        //    var argclone = (arg + "").ToLower();
        //    return argclone != "ismet" && argclone != "ısmet";
        //}
    }
}
