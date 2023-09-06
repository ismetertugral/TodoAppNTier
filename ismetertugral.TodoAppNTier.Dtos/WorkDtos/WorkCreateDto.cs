using ismetertugral.TodoAppNTier.Dtos.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ismetertugral.TodoAppNTier.Dtos.WorkDtos
{
    public class WorkCreateDto : IDto
    {
        //[Required(ErrorMessage = "Definition is required")]
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}
